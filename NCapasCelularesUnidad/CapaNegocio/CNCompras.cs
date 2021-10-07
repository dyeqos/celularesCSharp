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
    public class CNCompras
    {
        private string opt;
        private string idCompra;
        private string idProveedor;
        private string fechaCompra;
        private string usuario;

        public string _Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string _FechaCompra
        {
            get { return fechaCompra; }
            set { fechaCompra = value; }
        }
        public string _IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }
        public string _IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }
        public string _Opt
        {
            get { return opt; }
            set { opt = value; }
        }


        private CDCompras objCompras = new CDCompras();
        public DataTable mostrarCompras()
        {
            return objCompras.verTabla(Convert.ToInt32(_Opt),Convert.ToInt32(_IdCompra),Convert.ToInt32(_IdProveedor),_FechaCompra);
        }
        public void transaccionesCompras()
        {
            objCompras.transaccionesCompras(Convert.ToInt32(_Opt), Convert.ToInt32(_IdCompra), Convert.ToInt32(_IdProveedor), _FechaCompra,Convert.ToInt32(_Usuario));
        }
    }
}
