using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNClientes
    {
        private string opt;
        private string carnet;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string usuario;
        private string idCliente;

        public string _IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string _Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string _Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string _Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string _Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string _Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }
        public string _Opt
        {
            get { return opt; }
            set { opt = value; }
        }


        private CDClientes objClientes = new CDClientes();
        public DataTable mostrarClientes()
        {
            return objClientes.verTabla(Convert.ToInt32(_Opt),Convert.ToInt32(_IdCliente),_Carnet,_Nombres,_Apellidos);
        }
        public void transaccionesClientes(){
            objClientes.transaccionesClientes(Convert.ToInt32(_Opt), Convert.ToInt32(_IdCliente), _Carnet, _Nombres, _Apellidos, Convert.ToInt32(_Telefono), Convert.ToInt32(_Usuario));
        }
    }
}
