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
    public partial class frmMostrarVentas : Form
    {
        public frmMostrarVentas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private CNVentas objVentas = new CNVentas();
        private void mostrarVentas()
        {
            objVentas._Opt = "4";
            dgvVentas.DataSource = objVentas.mostrarVentas();
        }

        private void frmMostrarVentas_Load(object sender, EventArgs e)
        {
            mostrarVentas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea borrar?", "Eliminar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    objVentas._Opt = "3";
                    objVentas._Usuario = CNLogin.codUser.ToString();
                    objVentas._IdCliente = dgvVentas.CurrentRow.Cells[0].Value.ToString();
                    objVentas.transaccionesVentas();
                    mostrarVentas();
                    MessageBox.Show("Se eliminó correctamente");

                }
                else if (result == DialogResult.No)
                {
                }
                else if (result == DialogResult.Cancel)
                {
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarVentas frm = new frmAgregarVentas();
            frm.ShowDialog();
            mostrarVentas();
        }
        
    }
}
