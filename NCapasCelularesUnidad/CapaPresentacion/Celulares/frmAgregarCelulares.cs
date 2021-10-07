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
    public partial class frmAgregarCelulares : Form
    {
        public frmAgregarCelulares()
        {
            InitializeComponent();
        }
        private void frmAgregarCelulares_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int enteros;
            if(txtCodigo.Text!=""&&txtModelo.Text!=""&&txtRom.Text!=""&&txtRam.Text!=""&&
               txtCamara.Text!=""&&txtFrontal.Text!=""&&txtProcesador.Text!=""&&txtBateria.Text!=""&&
               txtSO.Text!=""&&txtUSB.Text!=""&&txtRanuras.Text!=""){
                   try
                   {
                       enteros = Int32.Parse(txtBateria.Text);
                       try
                       {
                           enteros = Int32.Parse(txtRanuras.Text);
                           objCelulares._Opt = "1";
                           objCelulares._Codigo = txtCodigo.Text.ToUpper();
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
                           objCelulares._Ranuras = txtRanuras.Text.ToUpper();
                           objCelulares._Marca = txtMarca.SelectedValue.ToString();
                           objCelulares.transaccionesCelulares();
                           MessageBox.Show("Se registró correctamente");
                           this.Close();
                       }
                       catch
                       {
                           MessageBox.Show("Llene el número de bandejas solo con numeros", "Solo números enteros");
                       }
                   }
                   catch
                   {
                       MessageBox.Show("Llene la capacidad de bateria solo con numeros", "Solo números enteros");
                   }
                }
            else
            {
                MessageBox.Show("Llene todos los espacios", "Espacios vacios");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private CNCelulares objCelulares = new CNCelulares();
        private CNMarcas objMarcas = new CNMarcas();
        private void cargarMarcas()
        {
            objMarcas._Opt = "4";
            txtMarca.DataSource = objMarcas.mostrarMarcas();
            txtMarca.DisplayMember = "Nombre";
            txtMarca.ValueMember = "Código";
        }

        
    }
}
