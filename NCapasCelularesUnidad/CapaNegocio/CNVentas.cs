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
    public class CNVentas
    {
        private string idVenta;
        private string idCliente;
        private string fechaVenta;
        private string usuario;
        private string opt;
        private string fecVen;

        public string _FecVen
        {
            get { return fecVen; }
            set { fecVen = value; }
        }

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
        public string _FechaVenta
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }
        public string _IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string _IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        private CDVentas objVentas = new CDVentas();
        public DataTable mostrarVentas()
        {
            return objVentas.verTabla(Convert.ToInt32(_Opt),Convert.ToInt32(_IdVenta),Convert.ToInt32(_IdCliente),_FechaVenta);
        }
        public void transaccionesVentas()
        {
            objVentas.transaccionesVentas(Convert.ToInt32(_Opt), Convert.ToInt32(_IdVenta), Convert.ToInt32(_IdCliente),_FecVen,Convert.ToInt32(_Usuario));
        }
    }
}
