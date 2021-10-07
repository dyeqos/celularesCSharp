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
    public partial class frmModificarMarcas : Form
    {
        public frmModificarMarcas()
        {
            InitializeComponent();
        }
        private CNMarcas objMarcas = new CNMarcas();
        private void frmModificarMarcas_Load(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int entero;
            if (txtNombre.Text != "" && txtDesc.Text != "")
            {
                try
                {
                    entero = Int32.Parse(txtTelf.Text);
                    objMarcas._IdMarca = txtMarca.Text;
                    objMarcas._Nombre = txtNombre.Text.ToUpper();
                    objMarcas._Descripcion = txtDesc.Text.ToUpper();
                    objMarcas._DirGarantia = txtDirecc.Text.ToUpper();
                    objMarcas._Telefono = txtTelf.Text;
                    objMarcas._Usuario = CNLogin.codUser.ToString();
                    objMarcas._Opt = "2";
                    objMarcas.transaccionesMarcas();
                    MessageBox.Show("Se modificó correctamente");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Llene solo numeros en teléfono sino tienes ponga un 0");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los espacios *");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
