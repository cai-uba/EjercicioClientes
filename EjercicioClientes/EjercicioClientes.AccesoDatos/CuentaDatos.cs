using EjercicioClientes.AccesoDatos.Utilidades;
using EjercicioClientes.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.AccesoDatos
{

    public class CuentaDatos
    {
        public Cuenta Traer(int cliente)
        {
            string json2 = WebHelper.Get("Cuenta/" + cliente.ToString()); // trae un texto en formato json de una web
            Cuenta resultado = MapObj(json2);
            return resultado;
        }

        private Cuenta MapObj(string json)
        {
            Cuenta lst = JsonConvert.DeserializeObject<Cuenta>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta); //serializacion -> json

            string json = WebHelper.Post("cuenta", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente", cuenta.IdCliente.ToString());
            n.Add("descripcion", cuenta.Descripcion);
            return n;
        }

        public TransactionResult Actualizar(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMapUpdate(cuenta);

            string json = WebHelper.Put("cuenta", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        

        private NameValueCollection ReverseMapUpdate(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cuenta.Id.ToString());
            n.Add("saldo", cuenta.Saldo.ToString());
            return n;
        }
    }
}
