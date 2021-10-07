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
    public partial class frmAgregarUsuarios : Form
    {
        public frmAgregarUsuarios()
        {
            InitializeComponent();
        }
        
        private void frmAgregarUsuarios_Load(object sender, EventArgs e)
        {

        }
        private CNUsuarios objUser = new CNUsuarios();
        private int telefonos;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text != "" && txtNombres.Text != "" && txtApellidos.Text != "" &&txtTelf.Text!=""&&txtTelfRef.Text!=""&&
               txtDomicilio.Text != "" && txtPass1.Text != "" && txtPass2.Text != "")
            {
                try
                {
                    telefonos = Int32.Parse(txtTelf.Text);
                    telefonos = Int32.Parse(txtTelfRef.Text);
                    if (txtPass1.Text == txtPass2.Text)
                    {
                        if (radioUsuario.Checked == true)
                        {
                            objUser._Administrador = "false";
                        }
                        else
                        {
                            objUser._Administrador = "true";
                        }

                        objUser._Opt = "1";
                        objUser._Carnet = txtCarnet.Text.ToUpper();
                        objUser._Nombre = txtNombres.Text.ToUpper();
                        objUser._Apellido = txtApellidos.Text.ToUpper();
                        objUser._Domicilio = txtDomicilio.Text.ToUpper();
                        objUser._Telefono = txtTelf.Text;
                        objUser._TelfRef = txtTelfRef.Text;
                        objUser._Pass = txtPass1.Text.ToUpper();
                        objUser._Usuario = CNLogin.codUser.ToString();
                        objUser.transacUsuarios();
                        MessageBox.Show("Se registró Correctamente");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }
                catch
                {
                    MessageBox.Show("En teléfonos escriba sólo números");
                }
            }
            else {
                MessageBox.Show("Llene todos los espacios (*)");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        

    }
}
