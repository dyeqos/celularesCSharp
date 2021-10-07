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
    public partial class frmAgregarVentas : Form
    {
        public frmAgregarVentas()
        {
            InitializeComponent();
        }
        private CNDetalleVentas objDetalleVenta = new CNDetalleVentas();
        private CNClientes objCliente = new CNClientes();
        private CNVentas objVentas = new CNVentas();
        private CNCelulares objCelulares = new CNCelulares();
        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text != "")
            {
                objCliente._Opt="6";
                objCliente._Carnet = txtCarnet.Text.ToUpper();
                if (objCliente.mostrarClientes().Rows.Count > 0)
                {
                    txtApellido.Text = objCliente.mostrarClientes().Rows[0][3].ToString();
                    btnComprobar.Visible = false;
                    btnEditarCliente.Visible = true;
                }
                else
                {
                    frmAgregarClientes frm = new frmAgregarClientes();
                    frm.txtCarnet.Text = txtCarnet.Text.ToUpper();
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Llene el carnet");
            }
        }
        private frmModificarClientes frmModCliente = new frmModificarClientes();
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            objCliente._Opt = "6";
            frmModCliente.txtIdCliente.Text = objCliente.mostrarClientes().Rows[0][0].ToString();
            frmModCliente.txtCarnet.Text = objCliente.mostrarClientes().Rows[0][1].ToString();
            frmModCliente.txtNombres.Text = objCliente.mostrarClientes().Rows[0][2].ToString();
            frmModCliente.txtApellidos.Text = objCliente.mostrarClientes().Rows[0][3].ToString();
            frmModCliente.txtTelf.Text = objCliente.mostrarClientes().Rows[0][4].ToString();
            frmModCliente.ShowDialog();
            btnComprobar_Click(sender, e);
        }
        
        private void btnAceptarVenta_Click(object sender, EventArgs e)
        {
            if (txtCarnet.Text != "" && txtApellido.Text != "")
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea agregar la venta?", "Venta", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    objVentas._Opt = "1";
                    objCliente._Opt = "6";


                    objVentas._IdCliente = objCliente.mostrarClientes().Rows[0][0].ToString();
                    objVentas._FecVen = txtFechaVenta.Text;
                    objVentas._Usuario = CNLogin.codUser.ToString();
                    objVentas.transaccionesVentas();
                    grupoDetalle.Enabled = true;
                    btnAceptarVenta.Enabled = false;
                    btnCancelarVenta.Enabled = false;
                    txtFechaVenta.Enabled = false;
                    txtCarnet.Enabled = false;
                    txtApellido.Enabled = false;
                    btnEditarCliente.Visible = false;

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
                MessageBox.Show("Llene los espacios obligatorios");
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarCelular()
        {
            objCelulares._Opt = "4";
            txtCodCelular.DataSource = objCelulares.mostrarCelulares();
            txtCodCelular.DisplayMember = "Modelo";
            txtCodCelular.ValueMember = "Código";
        }

        private void frmAgregarVentas_Load(object sender, EventArgs e)
        {
            cargarCelular();
        }

        private void btnDetalleAgregar_Click(object sender, EventArgs e)
        {
            int entero;
            if (txtImei.Text != "" && txtPrecioVenta.Text != "")
            {
                try
                {
                    entero = Int32.Parse(txtPrecioVenta.Text);
                    try
                    {
                        entero = Int32.Parse(txtImei.Text);
                        
                        
                        objDetalleVenta._Usuario = CNLogin.codUser.ToString();
                        objVentas._Opt = "6";
                        objDetalleVenta._IdVenta = objVentas.mostrarVentas().Rows[0][0].ToString();
                        objDetalleVenta._CodCelular = txtCodCelular.SelectedValue.ToString();
                        objDetalleVenta._Imei = txtImei.Text;
                        objDetalleVenta._PrecioVenta = txtPrecioVenta.Text;
                        objDetalleVenta._Opt = "1";
                        objDetalleVenta.transaccionesDetalleVentas();
                        mostrarDetalle();
                        txtImei.Text = "";
                        txtPrecioVenta.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("En imei solo números");
                    }
                }
                catch
                {
                    MessageBox.Show("Solo enteros en precion, no centavos");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los espacios");
            }
        }
        private void mostrarDetalle(){
            objDetalleVenta._Opt = "6";
            objDetalleVenta._IdVenta = objVentas.mostrarVentas().Rows[0][0].ToString();
            dgvVentas.DataSource = objDetalleVenta.mostrarDetalleVentas();

        }

        private void btnTerminarTodo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
