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
    public partial class frmMostrarClientes : Form
    {
        public frmMostrarClientes()
        {
            InitializeComponent();
        }
        private CNClientes objClientes = new CNClientes();
        private void frmMostrarClientes_Load(object sender, EventArgs e)
        {
            mostrarTodo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea borrar?", "Eliminar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    objClientes._Opt = "3";
                    objClientes._Usuario = CNLogin.codUser.ToString();
                    objClientes._IdCliente = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                    objClientes.transaccionesClientes();
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
            objClientes._Opt = "4";
            dgvClientes.DataSource = objClientes.mostrarClientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarClientes frm = new frmAgregarClientes();
            frm.ShowDialog();
            mostrarTodo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarClientes frm = new frmModificarClientes();
            if (dgvClientes.SelectedRows.Count > 0)
            {

                frm.txtIdCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                frm.txtCarnet.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                frm.txtNombres.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                frm.txtApellidos.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                frm.txtTelf.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                frm.ShowDialog();
                mostrarTodo();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
    }
}
