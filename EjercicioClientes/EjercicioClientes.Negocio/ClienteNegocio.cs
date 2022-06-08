using EjercicioClientes.AccesoDatos;
using EjercicioClientes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Negocio
{
    public class ClienteNegocio
    {
        private ClienteDatos _clienteDatos;
        private CuentaDatos _cuentaDatos;

        public ClienteNegocio()
        {
            _clienteDatos = new ClienteDatos();
            _cuentaDatos = new CuentaDatos();
        }

        public List<Cliente> GetLista()
        {
            List<Cliente> list = _clienteDatos.Traer(123);

            return list;
        }

        public Cliente GetById(int idCliente)
        {
            foreach (var item in GetLista())
            {
                if (idCliente == item.id)
                    return item;
            }

            return null;
        }

        public Cliente GetPorTelefono(string telefono)
        {
            Cliente cli = _clienteDatos.TraerPorTelefono(telefono);

            return cli;
        }

        public void Alta(string nombre, string apellido, int dni, string email, 
            string domicilio, string telefono, DateTime fnac)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.DNI = dni;
            cliente.FechaNacimiento = fnac;
            cliente.Email = email;
            cliente.Direccion = domicilio;
            cliente.Telefono = telefono;

            TransactionResult transaction = _clienteDatos.Insertar(cliente);

            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }

       

        public void AltaCuenta(Cliente cliente, string descripcion)
        {
            // validar cliente no nulo
            // validar cliente no tenga cuenta

            Cuenta cuenta = new Cuenta(cliente.id, descripcion);

            TransactionResult transaction = _cuentaDatos.Insertar(cuenta);

            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }

        public Cuenta TraerCuenta(Cliente cliente)
        {
            // validar cliente no nulo

            return _cuentaDatos.Traer(cliente.id);
        }


        public void IngresarDinero(Cliente cliente, Cuenta cuenta, double ingreso)
        {
            // validar cliente no nulo
            // validar cuenta no nula
            // validar cuenta este activa

            cuenta.Saldo += ingreso;

            ActualizarCuenta(cuenta);
        }

        public void RetirarDinero(Cliente cliente, Cuenta cuenta, double retiro)
        {
            // validar cliente no nulo
            // validar cuenta no nula
            // validar cuenta este activa
            // validar saldo sea >= retiro

            cuenta.Saldo -= retiro;

            ActualizarCuenta(cuenta);
        }


        private void ActualizarCuenta(Cuenta cuenta)
        {
            

            TransactionResult transaction = _cuentaDatos.Actualizar(cuenta);

            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }
    }
}
