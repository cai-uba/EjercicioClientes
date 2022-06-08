using EjercicioClientes.Entidades;
using EjercicioClientes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClientes.InterfazForm
{
    public partial class FrmPrincipal : Form
    {
        private ClienteNegocio _clienteNegocio;


        public FrmPrincipal()
        {
            InitializeComponent();
            
            _clienteNegocio = new ClienteNegocio();
        }

        private void AltaCliente()
        {
            _clienteNegocio.Alta("Carlos", "Gonzalez", 20123456, "asdqwe@yopmail.com", "moldes 123",
                    "1130604050", DateTime.Now.AddDays(-6000));
        }

        private void MostrarCliente()
        {
            try { 
                    string clientes = string.Empty;

                    List<Cliente> listado = _clienteNegocio.GetLista();

                    foreach (Cliente c in listado)
                    {
                        clientes += c.ToString() + Environment.NewLine;
                    }

                    //MessageBox.Show(clientes);

                _lblListaClientes.Text = clientes;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer clientes: " + ex.Message);
            }

}

        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsValido())
                {
                    _clienteNegocio.Alta(_lblNombre.Text, _txtApellido.Text, 
                        20123456, "asdqwe@yopmail.com", "moldes 123",
                        "1130604050", DateTime.Now.AddDays(-6000));

                    MessageBox.Show("ALTA COMPLETA");
                    
                    Limpiar();
                    
                    MostrarCliente();
                    
                }
                else
                {
                    MessageBox.Show("Complete los campos.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al dar alta al cliente " +ex.Message);
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private bool EsValido()
        {
            if (string.IsNullOrEmpty(_txtNombre.Text))
                return false;

            if (string.IsNullOrEmpty(_txtApellido.Text))
                return false;


            return true;
        }

        private void Limpiar()
        {
            _txtNombre.Text = string.Empty;
            _txtApellido.Text = string.Empty;
        }

        private void _btnCuentas_Click(object sender, EventArgs e)
        {
            FrmCuentas frmCuentas = new FrmCuentas(this);
            frmCuentas.Show();

            this.Hide();
        }
    }
}
