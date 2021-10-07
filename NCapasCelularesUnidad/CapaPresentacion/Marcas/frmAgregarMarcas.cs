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
    public partial class frmAgregarMarcas : Form
    {
        public frmAgregarMarcas()
        {
            InitializeComponent();
        }
        private CNMarcas objMarcas = new CNMarcas();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int entero;
            if(txtNombre.Text!=""&&txtDescripcion.Text!=""){
                try
                {
                    entero = Int32.Parse(txtTelf.Text);
                    objMarcas._Opt="1";
                    objMarcas._Usuario=CNLogin.codUser.ToString();
                    objMarcas._Nombre=txtNombre.Text.ToUpper();
                    objMarcas._Descripcion=txtDescripcion.Text.ToUpper();
                    objMarcas._DirGarantia=txtDirGara.Text.ToUpper();
                    objMarcas._Telefono=txtTelf.Text;
                    objMarcas.transaccionesMarcas();
                    MessageBox.Show("Se registro correctamente");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Llene sólo números en teléfono, sino tiene ponga un 0");
                }
            }else{
                MessageBox.Show("Llene los espacios obligatorios");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
