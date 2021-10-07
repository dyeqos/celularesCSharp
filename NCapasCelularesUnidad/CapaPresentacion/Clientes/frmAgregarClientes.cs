using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmAgregarClientes : Form
    {
        public frmAgregarClientes()
        {
            InitializeComponent();
        }
        private CNClientes objCliente = new CNClientes();
        private void frmAgregarClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int entero;
            if(txtCarnet.Text!=""&&txtNombres.Text!=""&&txtApellidos.Text!=""&&txtTelf.Text!=""){
                try
                {
                    entero = Int32.Parse(txtTelf.Text);
                    objCliente._Opt = "1";
                    objCliente._Carnet = txtCarnet.Text.ToUpper();
                    objCliente._Nombres = txtNombres.Text.ToUpper();
                    objCliente._Apellidos = txtApellidos.Text.ToUpper();
                    objCliente._Telefono = txtTelf.Text;
                    objCliente._Usuario = CNLogin.codUser.ToString();
                    objCliente.transaccionesClientes();
                    MessageBox.Show("Se registró correctamente");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("En telefono llene solo números");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los espacios");
            }
        }
    }
}
