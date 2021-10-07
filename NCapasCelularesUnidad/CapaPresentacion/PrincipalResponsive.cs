using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class PrincipalResponsive : Form
    {
        public PrincipalResponsive()
        {
            InitializeComponent();
        }
        private CNLogin objLogin = new CNLogin();
        private void PrincipalResponsive_Load(object sender, EventArgs e)
        {
            //MOSTRAR LOGO AL CARGAR
            mostrarFormLogo();
            verificarAdm();
        }
        //////mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwndn, int wmsg, int wparam, int lparam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(28, 28, 28));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            //AGREGA LINEAS DIAGONALES
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        private void mostrarLogoalCerrar(object sender, FormClosedEventArgs e)
        {
            mostrarFormLogo();
        }
        //------------------PARA CERRAR EL FORMULARIO
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //---------PARA MAXIMIZAR EL FORMULARIO
        int LX, LY, SW, SH;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        //-----------PARA MINIMIZAR EL FORMULARIO
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }
        //-----------PARA RESTAURAR EL FORMULARIO
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }
        //Para abrir dentro el form 
        private void abrirFormHijo(object formHijo)
        {
            if (this.panelCentro.Controls.Count > 0)
                this.panelCentro.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false; //hace q no sea form padre
            fh.Dock = DockStyle.Fill;
            this.panelCentro.Controls.Add(fh);
            this.panelCentro.Tag = fh;
            fh.Show();
        }
        private void mostrarFormLogo()
        {
            abrirFormHijo(new Inicio());
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Inicio());
        }

        public void btnProveedores_Click(object sender, EventArgs e)
        {
            frmMostrarProveedores frm = new frmMostrarProveedores();
            frm.FormClosed += new FormClosedEventHandler(mostrarLogoalCerrar);
            abrirFormHijo(frm);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmMostrarUsuarios frm = new frmMostrarUsuarios();
            frm.FormClosed += new FormClosedEventHandler(mostrarLogoalCerrar);
            abrirFormHijo(frm);
        }

        private void btnCelulares_Click(object sender, EventArgs e)
        {
            frmMostrarCelulares frm = new frmMostrarCelulares();
            frm.FormClosed += new FormClosedEventHandler(mostrarLogoalCerrar);
            abrirFormHijo(frm);
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMostrarMarcas frm = new frmMostrarMarcas();
            frm.FormClosed += new FormClosedEventHandler(mostrarLogoalCerrar);
            abrirFormHijo(frm);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmMostrarClientes frm = new frmMostrarClientes();
            frm.FormClosed += new FormClosedEventHandler(mostrarLogoalCerrar);
            abrirFormHijo(frm);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmMostrarCompras frm = new frmMostrarCompras();
            frm.FormClosed += new FormClosedEventHandler(mostrarLogoalCerrar);
            abrirFormHijo(frm);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmMostrarVentas frm = new frmMostrarVentas();
            frm.FormClosed += new FormClosedEventHandler(mostrarLogoalCerrar);
            abrirFormHijo(frm);
        }
        private void verificarAdm()
        {
            bool adm;
            objLogin._Opt = "5";
            objLogin._usuario = CNLogin.codUser.ToString();
            adm=Convert.ToBoolean( objLogin.verificarAdm().Rows[0][5]);
            if (adm == false)
            {
                btnUsuarios.Enabled = false;
                btnProveedores.Enabled = false;
                btnCompras.Enabled = false;
                btnInventario.Enabled = false;
                btnConsultas.Enabled = false;
            }
        }
        

        

        


        
    }
}
