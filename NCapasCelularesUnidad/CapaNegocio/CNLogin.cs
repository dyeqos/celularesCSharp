using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNLogin
    {
        //declaracion de variables y encapsulamiento
        private Boolean LogUsuario;
        private CDLogin objetoCD = new CDLogin();
        private string usuario;
        private string password;
        public static string codUser;
        private string opt;

        public string _Opt
        {
            get { return opt; }
            set { opt = value; }
        }
        
        public string _usuario
        {
            set {
                if (value == "USUARIO") { usuario = "No ha ingresado el Usuario"; }
                else usuario = value;
            }
            get { return usuario; }
        }
        public string _password
        {
            set {
                if (value == "CONTRASEÑA") { password = "No ha ingresado el Password"; }
                else password = value;
            }
            get { return password; }
        }
        //verificar el usuario
        public Boolean verificarTabla()
        {
            LogUsuario = objetoCD.VerificarTabla(Convert.ToInt32(_Opt), _usuario, _password);
            codUser = _usuario;
            return LogUsuario;
        }
        public DataTable verificarAdm()
        {
            return objetoCD.VerificarAdm(Convert.ToInt32(_Opt), _usuario);
        }
    }
}
