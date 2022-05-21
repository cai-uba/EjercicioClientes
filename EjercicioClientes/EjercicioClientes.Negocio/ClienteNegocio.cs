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

        public ClienteNegocio()
        {
            _clienteDatos = new ClienteDatos();
        }

        public List<Cliente> GetLista()
        {
            List<Cliente> list = _clienteDatos.Traer(123);

            return list;
        }

        public Cliente GetPorTelefono(string telefono)
        {
            Cliente cli = _clienteDatos.TraerPorTelefono(telefono);

            return cli;
        }

        public void Alta(string nombre, string apellido, int dni)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.DNI = dni;
            TransactionResult transaction = _clienteDatos.Insertar(cliente);

            if (!transaction.IsOk)
                throw new Exception(transaction.Error);
        }
    }
}
