using EjercicioClientes.Entidades;
using EjercicioClientes.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClientes.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteNegocio clientes = new ClienteNegocio();

            List<Cliente> listado = clientes.GetLista();

            foreach(Cliente c in listado)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Ingrese telefono: ");
            string tel = Console.ReadLine();

            Cliente c1 = clientes.GetPorTelefono(tel);

            Console.WriteLine("Se encontro el siguiente cliente con el telefono " + tel);
            Console.WriteLine(c1);

            try
            {
                clientes.Alta("Pepe", "sarasa", 456456);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
