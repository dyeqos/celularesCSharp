using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDVentas
    {
        private CDConexion conexion = new CDConexion();
        private DataTable tabla = new DataTable();
        public DataTable verTabla(int opt, int idVen, int idClien, string fecha)
        {
            SqlDataAdapter comandoVer = new SqlDataAdapter("SPVentas", conexion.abrirConexion());
            comandoVer.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoVer.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdVenta", idVen);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdCliente", idClien);
            comandoVer.SelectCommand.Parameters.AddWithValue("@FechaVenta", fecha);
            tabla.Clear();
            comandoVer.Fill(tabla);
            comandoVer.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();
            return tabla;
        }
        public void transaccionesVentas(int opt, int idVen, int idClien, string fecha, int usuario)
        {
            SqlDataAdapter comandoTransaccion = new SqlDataAdapter("SPVentas", conexion.abrirConexion());
            comandoTransaccion.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdVenta", idVen);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdCliente", idClien);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@FechaVenta", fecha);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Usuario", usuario);
            comandoTransaccion.SelectCommand.ExecuteNonQuery();
            comandoTransaccion.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();

        }
    }
}
