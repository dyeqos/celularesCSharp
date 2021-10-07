using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNUsuarios
    {
        //objDatos
        private CDUsuarios objUsuario = new CDUsuarios();
        //atributos
        private string opt;
        private string IdUsuario="0";
        private string carnet;
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private string telfRef;
        private string pass;
        private string administrador;
        private string usuario;
        //encapsulamiento de atributos
        public string _Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string _Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }
        public string _Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string _TelfRef
        {
            get { return telfRef; }
            set { telfRef = value; }
        }
        public string _Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string _Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public string _Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string _Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string _Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }
        public string _IdUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
        public string _Opt
        {
            get { return opt; }
            set { opt = value; }
        }
        //metodos
        public DataTable verUsuario()
        {
            return objUsuario.verTabla(Convert.ToInt32(_Opt),Convert.ToInt32(_IdUsuario),_Carnet,_Nombre,_Apellido);
        }
        public void transacUsuarios()
        {
            objUsuario.transaccionesUsuario(Convert.ToInt32(_Opt), Convert.ToInt32(_IdUsuario), _Carnet, _Nombre, _Apellido, _Domicilio, Convert.ToInt32(_Telefono),
                                            Convert.ToInt32(_TelfRef), _Pass, Convert.ToBoolean(_Administrador), _Usuario);
        }
    }
}
