using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Entidades
{
   
        public class Cliente 
        {
            private int _id;
            protected string _nombre;
            private string _apellido;

            private long _DNI;
            private string _direccion;
            private string _email;
            private string _telefono;
            private DateTime _fechaNac;
            private bool _activo;


            public int id { get => _id; set => _id = value; }
            public string Nombre { get => _nombre; set => _nombre = value; }
            public string Apellido { get => _apellido; set => _apellido = value; }
            public long DNI { get => _DNI; set => _DNI = value; }
            public string Direccion { get => _direccion; set => _direccion = value; }
            public string Email { get => _email; set => _email = value; }
            public string Telefono { get => _telefono; set => _telefono = value; }
            public bool Activo { get => _activo; set => _activo = value; }
            public DateTime FechaNacimiento { get => _fechaNac; set => _fechaNac = value; }

            public string ComboDisplay { get => $"{this.Nombre}/{this.Apellido}"; }

            public override string ToString()
            {
                return this.id + ") " + this.Apellido + ", " + this.Nombre;
            }

    }
}

