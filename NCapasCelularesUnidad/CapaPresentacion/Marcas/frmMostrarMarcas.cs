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
    public partial class frmMostrarMarcas : Form
    {
        public frmMostrarMarcas()
        {
            InitializeComponent();
        }

        private void frmMostrarMarcas_Load(object sender, EventArgs e)
        {
            mostrarGrid();
        }
        private CNMarcas objMarcas = new CNMarcas();
        private void mostrarGrid()
        {
            objMarcas._Opt = "4";
            dgvMarcas.DataSource = objMarcas.mostrarMarcas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea borrar?", "Eliminar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    objMarcas._Opt = "3";
                    objMarcas._Usuario = CNLogin.codUser.ToString();
                    objMarcas._IdMarca = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
                    objMarcas.transaccionesMarcas();
                    mostrarGrid();
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
            frmAgregarMarcas frm = new frmAgregarMarcas();
            frm.ShowDialog();
            mostrarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarMarcas frm = new frmModificarMarcas();
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                frm.txtMarca.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombre.Text = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
                frm.txtDesc.Text = dgvMarcas.CurrentRow.Cells[2].Value.ToString();
                frm.txtTelf.Text = dgvMarcas.CurrentRow.Cells[3].Value.ToString();
                frm.txtDirecc.Text = dgvMarcas.CurrentRow.Cells[4].Value.ToString();
                frm.ShowDialog();
                mostrarGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar");
            }
        }


    }
}
