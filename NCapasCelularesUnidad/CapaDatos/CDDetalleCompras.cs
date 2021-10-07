using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDDetalleCompras
    {
        private CDConexion conexion = new CDConexion();
        private DataTable tabla = new DataTable();
        public DataTable verTabla(int opt,int idDeta, int idCom, int imei)
        {
            SqlDataAdapter comandoVer = new SqlDataAdapter("SPDetalleCompras", conexion.abrirConexion());
            comandoVer.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoVer.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdDetalleCompra", idDeta);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdCompra", idCom);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Imei", imei);
            tabla.Clear();
            comandoVer.Fill(tabla);
            comandoVer.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();
            return tabla;
        }
        public void transaccionesDetalleCompras(int opt, int idDeta, int idCom, string cod, int imei, int precio, int user)
        {
            SqlDataAdapter comandoTransaccion = new SqlDataAdapter("SPDetalleCompras", conexion.abrirConexion());
            comandoTransaccion.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdDetalleCompra", idDeta);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdCompra", idCom);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@CodCel", cod);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Imei", imei);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@PrecioCompra", precio);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Usuario", user);
            comandoTransaccion.SelectCommand.ExecuteNonQuery();
            comandoTransaccion.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();

        }
    }
}
