using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
    public class Cuenta
    {

        private int _id;
        private int _idCliente;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private double _saldo;
        private int _nroCuenta;
        private bool _activo;
        private string _descripcion;
        public Cuenta() { }
        public Cuenta( int idCliente, string descripcion)
        {
            _idCliente = idCliente;
            _descripcion = descripcion;
        }

        public Cuenta(int id, int idCliente, DateTime fechaApertura, DateTime fechaModificacion, double saldo, int nroCuenta, bool activo, string descripcion)
        {
            _id = id;
            _idCliente = idCliente;
            _fechaApertura = fechaApertura;
            _fechaModificacion = fechaModificacion;
            _saldo = saldo;
            _nroCuenta = nroCuenta;
            _activo = activo;
            _descripcion = descripcion;
        }

        public int Id { get => _id; set => _id = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public DateTime FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }
        public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public int NroCuenta { get => _nroCuenta; set => _nroCuenta = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public override string ToString()
        {
            return $"{this.NroCuenta}) {this.Descripcion} $ {this.Saldo}";
        }
    }
}
