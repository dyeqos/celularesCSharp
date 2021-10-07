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
    public partial class frmMostrarProveedores : Form
    {
        public frmMostrarProveedores()
        {
            InitializeComponent();
        }

        private void frmMostrarProveedores_Load(object sender, EventArgs e)
        {
            mostrarTodo();
        }
        private CNProveedores objProvee = new CNProveedores();
        public void mostrarTodo()
        {
            objProvee._Opt = "4";
            dgvProv.DataSource = objProvee.mostrarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmEditarProveed frm = new frmEditarProveed();
            if (dgvProv.SelectedRows.Count > 0)
            {
                frm.txtID.Text = dgvProv.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombre.Text = dgvProv.CurrentRow.Cells[1].Value.ToString();
                frm.txtApellidos.Text = dgvProv.CurrentRow.Cells[2].Value.ToString();
                frm.txtDirecc.Text = dgvProv.CurrentRow.Cells[3].Value.ToString();
                frm.txtTelf.Text = dgvProv.CurrentRow.Cells[4].Value.ToString();
                frm.ShowDialog();
                mostrarTodo();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmProveedores frm = new frmProveedores();
            frm.ShowDialog();
            mostrarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProv.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea borrar?", "Eliminar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    objProvee._Opt = "3";
                    objProvee._Usuario = CNLogin.codUser.ToString();
                    objProvee._IdProveedor=dgvProv.CurrentRow.Cells[0].Value.ToString();
                    objProvee.transaccionesProveedores();
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

    }
}
