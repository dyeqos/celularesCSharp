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
    public partial class frmModificarCompras : Form
    {
        public frmModificarCompras()
        {
            InitializeComponent();
        }

        private void frmModificarCompras_Load(object sender, EventArgs e)
        {

        }
        private CNCompras objCompras = new CNCompras();
        private CNProveedores objProveedor = new CNProveedores();
        public void cargarProveedor(){
            objProveedor._Opt = "4";
            txtProveedor.DataSource = objProveedor.mostrarTabla();
            txtProveedor.DisplayMember = "Nombres";
            txtProveedor.ValueMember = "Código";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objCompras._Opt = "2";
            objCompras._IdCompra = txtIdCompra.Text;
            objCompras._IdProveedor = txtProveedor.SelectedValue.ToString();
            objCompras._FechaCompra = txtFecha.Text;
            objCompras._Usuario = CNLogin.codUser.ToString();
            objCompras.transaccionesCompras();
            MessageBox.Show("Se modificó correctamente");
            this.Close();
        }
    }
}
