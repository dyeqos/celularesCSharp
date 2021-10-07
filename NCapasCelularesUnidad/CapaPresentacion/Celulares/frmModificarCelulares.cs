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
    public partial class frmModificarCelulares : Form
    {
        public frmModificarCelulares()
        {
            InitializeComponent();
        }
        private CNMarcas objMarcas = new CNMarcas();
        private CNCelulares objCelulares = new CNCelulares();
        private void frmModificarCelulares_Load(object sender, EventArgs e)
        {

        }
        public void cargarMarcas()
        {
            objMarcas._Opt = "4";
            txtMarca.DataSource = objMarcas.mostrarMarcas();
            txtMarca.DisplayMember = "Nombre";
            txtMarca.ValueMember = "Código";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int entero;
            if (txtCod.Text != "" && txtModelo.Text != "" && txtRom.Text != "" && txtRam.Text != "" &&
               txtCamara.Text != "" && txtFrontal.Text != "" && txtProcesador.Text != "" && txtBateria.Text != "" &&
               txtSO.Text != "" && txtUSB.Text != "" && txtRanuras.Text != "")
            {
                try
                {
                    entero = Int32.Parse(txtBateria.Text);
                    try
                    {
                        entero = Int32.Parse(txtRanuras.Text);
                        objCelulares._Opt = "2";
                        objCelulares._Usuario = CNLogin.codUser.ToString();
                        objCelulares._Codigo = txtCod.Text.ToUpper();
                        objCelulares._Modelo = txtModelo.Text.ToUpper();
                        objCelulares._Rom = txtRom.Text.ToUpper();
                        objCelulares._Ram = txtRam.Text.ToUpper();
                        objCelulares._Camara = txtCamara.Text.ToUpper();
                        objCelulares._Frontal = txtFrontal.Text.ToUpper();
                        objCelulares._Procesador = txtProcesador.Text.ToUpper();
                        objCelulares._Bateria = txtBateria.Text;
                        objCelulares._So = txtSO.Text.ToUpper();
                        if (huellaNo.Checked)
                        {
                            objCelulares._Huella = "false";
                        }
                        else
                        {
                            objCelulares._Huella = "true";
                        }
                        if (radioNo.Checked)
                        {
                            objCelulares._Radio = "false";
                        }
                        else
                        {
                            objCelulares._Radio = "true";
                        }
                        objCelulares._Usb = txtUSB.Text.ToUpper();
                        objCelulares._Ranuras = txtRanuras.Text;
                        objCelulares._Marca = txtMarca.SelectedValue.ToString();
                        objCelulares.transaccionesCelulares();
                        MessageBox.Show("Se modificó correctamente");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Llene solo números en ranura");
                    }
                }
                catch
                {
                    MessageBox.Show("Llene solo números en la bateria");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los espacios");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
