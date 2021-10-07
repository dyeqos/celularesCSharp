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
    public class CNProveedores
    {
        private string opt;
        private string IdProveedor;
        private string Nombres;
        private string Apellidos;
        private string Telefono;
        private string Direccion;
        private string Usuario;
        public string _Usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public string _Opt
        {
            get { return opt; }
            set { opt = value; }
        }
        public string _IdProveedor
        {
            get { return IdProveedor; }
            set { IdProveedor = value; }
        }
        public string _Nombres
        {
            get { return Nombres; }
            set { Nombres = value; }
        }
        public string _Apellidos
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
        public string _Direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public string _Telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        
        CDProveedores objProvee=new CDProveedores();
        //-------------metodos
        public DataTable mostrarTabla()
        {
            return objProvee.verTabla(Convert.ToInt32(_Opt), _IdProveedor,_Nombres,_Apellidos);
        }
        public void transaccionesProveedores()
        {
            objProvee.transaccionesProveedores(Convert.ToInt32(_Opt), _IdProveedor, _Nombres, _Apellidos, _Direccion, Convert.ToInt32(_Telefono),_Usuario);
        }
    }
}
