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
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        private CNProveedores objProvee = new CNProveedores();
        private void frmProveedores_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwndn, int wmsg, int wparam, int lparam);
        private void frmProveedores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private PrincipalResponsive frm = new PrincipalResponsive();
        int telefono;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "0";
            }
            try
            {
                telefono = Int32.Parse(txtTelefono.Text);
                
                if (txtNombre.Text != "" && txtDomicilio.Text != "")
                {
                    objProvee._Nombres = txtNombre.Text.ToUpper();
                    objProvee._Apellidos = txtApellido.Text.ToUpper();
                    objProvee._Direccion = txtDomicilio.Text.ToUpper();
                    objProvee._Telefono = txtTelefono.Text;
                    objProvee._Usuario = CNLogin.codUser.ToString();
                    objProvee._Opt = "1";
                    objProvee.transaccionesProveedores();
                    MessageBox.Show("Se Registró Correctamente");
                    this.Close();
                    frm.Refresh();
                }
                else
                {
                    MessageBox.Show("Llene los espacios obligatorios * ");
                }
                
            }
            catch
            {
                MessageBox.Show("Llene sólo números en telefono");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
