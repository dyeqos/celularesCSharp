using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        CNLogin objetoCN = new CNLogin();
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwndn, int wmsg, int wparam, int lparam);

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean Logear;
                objetoCN._usuario = txtUser.Text.ToUpper();
                objetoCN._password = txtPass.Text.ToUpper();
                if (objetoCN._usuario == txtUser.Text.ToUpper())
                {
                    lblErrorUsuario.Visible = false;
                    if (objetoCN._password == txtPass.Text.ToUpper())
                    {
                        lblErrorPass.Visible = false;
                        objetoCN._Opt = "6";
                        Logear = objetoCN.verificarTabla();
                        if (Logear == true)
                        {

                            this.Hide();
                            PrincipalResponsive frmPrin = new PrincipalResponsive();
                            frmPrin.Show();
                        }
                        else
                        {
                            lblErrorLogin.Text = "Usuario Password Incorrecto";
                            lblErrorLogin.Visible = true;
                            txtPass.Text = "";
                            txtPass_Leave(null, e);
                            txtUser.Focus();
                        }
                    }
                    else
                    {
                        lblErrorPass.Text = objetoCN._password;
                        lblErrorPass.Visible = true;
                    }
                }
                else
                {
                    lblErrorUsuario.Text = objetoCN._usuario;
                    lblErrorUsuario.Visible = true;
                }

                //fin try
            }
            catch
            {
                MessageBox.Show("no estas conectado base de datos");
            }
        }
    }
}
