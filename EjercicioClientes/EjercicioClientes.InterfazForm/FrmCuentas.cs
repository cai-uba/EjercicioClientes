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
    public partial class FrmCuentas : Form
    {

        private ClienteNegocio _clienteNegocio;


        public FrmCuentas(Form padre)
        {
            InitializeComponent();

            _clienteNegocio = new ClienteNegocio();

            this.Owner = padre;
        }

        private void _btnAltaCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente =  Convert.ToInt32(_cmbClientes.SelectedValue);
                string desc = _txtDescripcion.Text;

                Cliente cliente = _clienteNegocio.GetById(idCliente);

                if (cliente != null)
                {
                    _clienteNegocio.AltaCuenta(cliente, desc);
                    MessageBox.Show("Cuenta generada");
                }
                else
                    MessageBox.Show("Cliente inex");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnConsulta_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(_cmbClientes.SelectedValue);
            Cliente cliente = _clienteNegocio.GetById(idCliente);
            if (cliente != null) {
                Cuenta cuenta = _clienteNegocio.TraerCuenta(cliente);
                if(cuenta != null)
                MessageBox.Show(cuenta.ToString());
                else
                    MessageBox.Show("Cliente sin cuenta");
            }
            else
            {
                MessageBox.Show("Cliente inex");
            }
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            CargarListas();
        }

        private void CargarListas()
        {
            List<Cliente> lstClientes = _clienteNegocio.GetLista();
            
            _cmbClientes.DataSource = null;
            
            _cmbClientes.DataSource = lstClientes;
            _cmbClientes.DisplayMember = "ComboDisplay";
            _cmbClientes.ValueMember = "Id";
        }

        private void _cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
