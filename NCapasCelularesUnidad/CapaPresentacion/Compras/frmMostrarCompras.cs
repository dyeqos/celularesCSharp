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
    public partial class frmMostrarCompras : Form
    {
        public frmMostrarCompras()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private CNCompras objCompras = new CNCompras();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea borrar?", "Eliminar", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    objCompras._Opt = "3";
                    objCompras._Usuario = CNLogin.codUser.ToString();
                    objCompras._IdCompra = dgvCompras.CurrentRow.Cells[0].Value.ToString();
                    objCompras.transaccionesCompras();
                    mostrarTodo();
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
        private void mostrarTodo()
        {
            objCompras._Opt = "4";
            dgvCompras.DataSource = objCompras.mostrarCompras();
        }

        private void frmAgregarCompras_Load(object sender, EventArgs e)
        {
            mostrarTodo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            frmAgregaCompras frm = new frmAgregaCompras();
            frm.ShowDialog();
            mostrarTodo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarCompras frm = new frmModificarCompras();
            if (dgvCompras.SelectedRows.Count > 0)
            {
                frm.cargarProveedor();
                frm.txtIdCompra.Text = dgvCompras.CurrentRow.Cells[0].Value.ToString();
                frm.txtProveedor.Text = dgvCompras.CurrentRow.Cells[1].Value.ToString();
                frm.txtFecha.Text = dgvCompras.CurrentRow.Cells[2].Value.ToString();
                frm.ShowDialog();
                mostrarTodo();
            }
        }
    }
}
