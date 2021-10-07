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
    public partial class frmModificarUsuarios : Form
    {
        public frmModificarUsuarios()
        {
            InitializeComponent();
        }

        private void frmModificarUsuarios_Load(object sender, EventArgs e)
        {

        }
        private int telefono;
        private CNUsuarios objUsuarios = new CNUsuarios();
        private frmMostrarUsuarios frm = new frmMostrarUsuarios();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text != "" && txtNombre.Text != "" && txtApellidos.Text != "" &&
                txtDirecc.Text != "" && txtTelf.Text != "" && txtTelfReg.Text != "")
            {
                try
                {
                    telefono = Int32.Parse(txtTelfReg.Text);
                    telefono = Int32.Parse(txtTelf.Text);
                    objUsuarios._Opt = "2";
                    objUsuarios._IdUsuario = txtID.Text;
                    objUsuarios._Carnet = txtCarnet.Text;
                    objUsuarios._Nombre=txtNombre.Text;
                    objUsuarios._Apellido = txtApellidos.Text;
                    objUsuarios._Domicilio = txtDirecc.Text;
                    objUsuarios._Telefono = txtTelf.Text;
                    objUsuarios._TelfRef = txtTelfReg.Text;
                    objUsuarios._Usuario = CNLogin.codUser.ToString();
                    objUsuarios.transacUsuarios();
                    MessageBox.Show("Se modificó correctamente");
                    this.Close();                   
                    
                }
                catch
                {
                    MessageBox.Show("Sólo números en los espacios de teléfono");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los espacios");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
