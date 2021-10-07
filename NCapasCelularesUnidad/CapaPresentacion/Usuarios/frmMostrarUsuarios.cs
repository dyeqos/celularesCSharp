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
    public partial class frmMostrarUsuarios : Form
    {
        public frmMostrarUsuarios()
        {
            InitializeComponent();
        }

        private void frmMostrarUsuarios_Load(object sender, EventArgs e)
        {
            mostrarTodo();
        }
        private CNUsuarios objUser = new CNUsuarios();
        public void mostrarTodo()
        {
            objUser._Opt = "4";
            dgvUsuarios.DataSource = objUser.verUsuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarUsuarios frm = new frmAgregarUsuarios();
            frm.ShowDialog();
            mostrarTodo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarUsuarios frm = new frmModificarUsuarios();
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                
                frm.txtID.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                frm.txtCarnet.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                frm.txtNombre.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                frm.txtApellidos.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                frm.txtDirecc.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                frm.txtTelf.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
                frm.txtTelfReg.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
                frm.ShowDialog();
                mostrarTodo();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea borrar?", "Eliminar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    objUser._Opt = "3";
                    objUser._Usuario = CNLogin.codUser.ToString();
                    objUser._IdUsuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                    objUser.transacUsuarios();
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
