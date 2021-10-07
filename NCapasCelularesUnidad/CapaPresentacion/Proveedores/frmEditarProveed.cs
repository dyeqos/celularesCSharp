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
    public partial class frmEditarProveed : Form
    {
        private CNProveedores objProvee = new CNProveedores();       
        public frmEditarProveed()
        {
            InitializeComponent();
        }

     

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int telefono;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTelf.Text == "")
            {
                txtTelf.Text = "0";
            }
            try
            {
                telefono = Int32.Parse(txtTelf.Text);

                if (txtNombre.Text != "" && txtDirecc.Text != "")
                {
                    objProvee._IdProveedor = txtID.Text;
                    objProvee._Nombres = txtNombre.Text.ToUpper();
                    objProvee._Apellidos = txtApellidos.Text.ToUpper();
                    objProvee._Direccion = txtDirecc.Text.ToUpper();
                    objProvee._Telefono = txtTelf.Text;
                    objProvee._Opt = "2";
                    objProvee._Usuario = CNLogin.codUser.ToString();
                    objProvee.transaccionesProveedores();
                    
                    MessageBox.Show("SE modifico CORRECTAMENTE");
                    this.Close();
                    frmMostrarProveedores frm = new frmMostrarProveedores();
                    frm.mostrarTodo();
                }
                else
                {
                    MessageBox.Show("llene los espacios obligatorios * ");
                }

            }
            catch
            {
                MessageBox.Show("llene solo numeros en telefono");
            }
        }
    }
}
