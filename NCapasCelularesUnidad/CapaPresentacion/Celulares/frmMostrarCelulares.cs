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
    public partial class frmMostrarCelulares : Form
    {
        public frmMostrarCelulares()
        {
            InitializeComponent();
        }

        private void frmMostrarCelulares_Load(object sender, EventArgs e)
        {
            mostrarCelulares();
        }
        private CNCelulares objCelulares = new CNCelulares();
        private void mostrarCelulares()
        {
            objCelulares._Opt = "4";
            dgvCelulares.DataSource = objCelulares.mostrarCelulares();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCelulares frm = new frmAgregarCelulares();
            frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarCelulares frm = new frmModificarCelulares();
            if (dgvCelulares.SelectedRows.Count > 0)
            {
                frm.cargarMarcas();
                frm.txtCod.Text=dgvCelulares.CurrentRow.Cells[0].Value.ToString();
                frm.txtModelo.Text = dgvCelulares.CurrentRow.Cells[1].Value.ToString();
                frm.txtRom.Text = dgvCelulares.CurrentRow.Cells[2].Value.ToString();
                frm.txtRam.Text = dgvCelulares.CurrentRow.Cells[3].Value.ToString();
                frm.txtCamara.Text = dgvCelulares.CurrentRow.Cells[4].Value.ToString();
                frm.txtFrontal.Text = dgvCelulares.CurrentRow.Cells[5].Value.ToString();
                frm.txtProcesador.Text = dgvCelulares.CurrentRow.Cells[6].Value.ToString();
                frm.txtBateria.Text = dgvCelulares.CurrentRow.Cells[7].Value.ToString();
                frm.txtSO.Text = dgvCelulares.CurrentRow.Cells[8].Value.ToString();
                if(dgvCelulares.CurrentRow.Cells[9].Value.ToString()=="SI"){
                    frm.rbtnHuellaSi.Checked=true;
                }else{
                    frm.rbtnHuellaNo.Checked=true;
                }
                if(dgvCelulares.CurrentRow.Cells[10].Value.ToString()=="SI"){
                    frm.radioSi.Checked=true;
                }else{
                    frm.radioNo.Checked=true;
                }
                frm.txtUSB.Text = dgvCelulares.CurrentRow.Cells[11].Value.ToString();
                frm.txtRanuras.Text=dgvCelulares.CurrentRow.Cells[12].Value.ToString();
                frm.txtMarca.Text=dgvCelulares.CurrentRow.Cells[13].Value.ToString();
                frm.ShowDialog();
                mostrarCelulares();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCelulares.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea borrar?", "Eliminar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    objCelulares._Opt = "3";
                    objCelulares._Usuario = CNLogin.codUser.ToString();
                    objCelulares._Codigo = dgvCelulares.CurrentRow.Cells[0].Value.ToString();
                    objCelulares.transaccionesCelulares();
                    mostrarCelulares();
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
