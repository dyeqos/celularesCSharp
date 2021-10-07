using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDDetalleVentas
    {
        private CDConexion conexion = new CDConexion();
        private DataTable tabla = new DataTable();
        public DataTable verTabla(int opt, int idDeta, int idVen, int imei)
        {
            SqlDataAdapter comandoVer = new SqlDataAdapter("SPDetalleVentas", conexion.abrirConexion());
            comandoVer.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoVer.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdDetalleVenta", idDeta);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdVenta", idVen);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Imei", imei);
            tabla.Clear();
            comandoVer.Fill(tabla);
            comandoVer.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();
            return tabla;
        }
        public void transaccionesDetalleVentas(int opt, int idDeta, int idVen, string cod, int imei, int precio, int user)
        {
            SqlDataAdapter comandoTransaccion = new SqlDataAdapter("SPDetalleVentas", conexion.abrirConexion());
            comandoTransaccion.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdDetalleVenta", idDeta);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdVenta", idVen);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@CodCel", cod);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Imei", imei);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@PrecioVenta", precio);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Usuario", user);
            comandoTransaccion.SelectCommand.ExecuteNonQuery();
            comandoTransaccion.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();

        }
    }
}
