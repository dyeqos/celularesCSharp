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
    public partial class frmAgregaCompras : Form
    {
        public frmAgregaCompras()
        {
            InitializeComponent();
        }
        private void cargarProveedorAndCelulares()
        {
            objCelulares._Opt="4";
            txtCodCelular.DataSource = objCelulares.mostrarCelulares();
            txtCodCelular.DisplayMember = "Modelo";
            txtCodCelular.ValueMember = "Código";
            ////////
            objProveedor._Opt = "4";
            txtProveedor.DataSource = objProveedor.mostrarTabla();
            txtProveedor.DisplayMember = "Nombres";
            txtProveedor.ValueMember = "Código";
        }
        private CNCelulares objCelulares = new CNCelulares();
        private CNProveedores objProveedor = new CNProveedores();
        private CNCompras objCompras = new CNCompras();
        private CNDetalleCompra objDetalleCompra = new CNDetalleCompra();

        private void frmAgregaCompras_Load(object sender, EventArgs e)
        {
            cargarProveedorAndCelulares();
        }

        private void btnCompraAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea añadir un nuevo registro de Compra?", "Compras", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                objCompras._Opt = "1";
                objCompras._IdProveedor = txtProveedor.SelectedValue.ToString();
                objCompras._FechaCompra = txtFechaCompra.Text;
                objCompras._Usuario = CNLogin.codUser.ToString();
                objCompras.transaccionesCompras();
                txtProveedor.Enabled = false;
                txtFechaCompra.Enabled = false;
                grupoDetalle.Enabled = true;
                btnCompraAceptar.Enabled = false;
                btnCompraCancelar.Enabled = false;
            }
            else if (result == DialogResult.No)
            {
            }
            else if (result == DialogResult.Cancel)
            {
            }
        }

        private void btnCompraCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetalleAgregar_Click(object sender, EventArgs e)
        {
            int entero;
            if (txtImei.Text != "" && txtPrecioCompra.Text != "")
            {
                try
                {
                    entero = Int32.Parse(txtPrecioCompra.Text);
                    try
                    {
                        entero = Int32.Parse(txtImei.Text);
                        objDetalleCompra._Opt = "1";
                        objDetalleCompra._Usuario = CNLogin.codUser.ToString();
                        objDetalleCompra._CodCelular = txtCodCelular.SelectedValue.ToString();
                        objDetalleCompra._Imei = txtImei.Text;
                        objDetalleCompra._PrecioCompra = txtPrecioCompra.Text;
                        objCompras._Opt = "6";
                        objDetalleCompra._IdCompra = objCompras.mostrarCompras().Rows[0][0].ToString();
                        objDetalleCompra.transaccionesDetalleCompras();
                        
                        mostrarGrid();
                        txtImei.Text = "";
                        txtPrecioCompra.Text = "";

                    }
                    catch
                    {
                        MessageBox.Show("Imei incorrecto, escriba solo números");
                    }
                }
                catch
                {
                    MessageBox.Show("En precio ponga solo enteros, No centavos");
                }
            }
            else
            {
                MessageBox.Show("Llene los espacios obligatorios");
            }
        }
        private void mostrarGrid()
        {
            objDetalleCompra._Opt = "6";
            objDetalleCompra._IdCompra = objCompras.mostrarCompras().Rows[0][0].ToString();
            dgvDetalleCompras.DataSource = objDetalleCompra.mostrarDetalleCompras();
        }

        private void btnTerminarTodo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //private string fecha( da)
        //{
        //    string fechat="",
        //        fechat=  year(da)
        //}

    }
}
