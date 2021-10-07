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
    //@IdDetalleVenta int=0,
    //@IdVenta int=0,
    //@CodCel varchar(15)='',
    //@Imei bigint=0,
    //@PrecioVenta int=0,
    //@Usuario int =0,
    public class CNDetalleVentas
    {
        private string opt;
        private string idDetalleVenta;
        private string idVenta;
        private string codCelular;
        private string imei;
        private string precioVenta;
        private string usuario;

        public string _Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string _PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
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
        public string _IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }
        public string _IdDetalleVenta
        {
            get { return idDetalleVenta; }
            set { idDetalleVenta = value; }
        }
        public string _Opt
        {
            get { return opt; }
            set { opt = value; }
        }

        private CDDetalleVentas objDetalleVentas = new CDDetalleVentas();
        public DataTable mostrarDetalleVentas()
        {
            return objDetalleVentas.verTabla(Convert.ToInt32(_Opt),Convert.ToInt32(_IdDetalleVenta),Convert.ToInt32(_IdVenta),Convert.ToInt32(_Imei));
        }
        public void transaccionesDetalleVentas()
        {
            objDetalleVentas.transaccionesDetalleVentas(Convert.ToInt32(_Opt), Convert.ToInt32(_IdDetalleVenta), Convert.ToInt32(_IdVenta),_CodCelular, Convert.ToInt32(_Imei),Convert.ToInt32(_PrecioVenta),Convert.ToInt32(_Usuario));
        }
    }
}
