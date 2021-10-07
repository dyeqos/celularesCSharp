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
    public class CNDetalleCompra
    {
        private string idDetalleCompra;
        private string idCompra;
        private string codCelular;
        private string imei;
        private string precioCompra;
        private string usuario;
        private string opt;

        public string _Opt
        {
            get { return opt; }
            set { opt = value; }
        }
        public string _Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string _PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }
        public string _Imei
        {
            get { return imei; }
            set { imei = value; }
        }
        public string _CodCelular
        {
            get { return codCelular; }
            set { codCelular = value; }
        }
        public string _IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }
        public string _IdDetalleCompra
        {
            get { return idDetalleCompra; }
            set { idDetalleCompra = value; }
        }

        private CDDetalleCompras objDetalleCompras = new CDDetalleCompras();
        public DataTable mostrarDetalleCompras()
        {
            return objDetalleCompras.verTabla(Convert.ToInt32(_Opt),Convert.ToInt32(_IdDetalleCompra),Convert.ToInt32(_IdCompra),Convert.ToInt32(_Imei));
        }
        public void transaccionesDetalleCompras()
        {
            objDetalleCompras.transaccionesDetalleCompras(Convert.ToInt32(_Opt),Convert.ToInt32(_IdDetalleCompra),Convert.ToInt32(_IdCompra),_CodCelular, Convert.ToInt32(_Imei),Convert.ToInt32(_PrecioCompra),Convert.ToInt32(_Usuario));
        }
    }
}
