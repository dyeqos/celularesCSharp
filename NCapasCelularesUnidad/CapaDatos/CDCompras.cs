using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCompras
    {
        private CDConexion conexion = new CDConexion();
        private DataTable tabla = new DataTable();
        public DataTable verTabla(int opt, int idCom,int idProv,string fecha)
        {
            SqlDataAdapter comandoVer = new SqlDataAdapter("SPCompras", conexion.abrirConexion());
            comandoVer.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoVer.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdCompra", idCom);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdProveedor", idProv);
            comandoVer.SelectCommand.Parameters.AddWithValue("@FechaCompra", fecha);
            tabla.Clear();
            comandoVer.Fill(tabla);
            comandoVer.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();
            return tabla;
        }
        public void transaccionesCompras(int opt, int idCom, int idProv, string fecha, int usuario)
        {
            SqlDataAdapter comandoTransaccion = new SqlDataAdapter("SPCompras", conexion.abrirConexion());
            comandoTransaccion.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdCompra", idCom);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdProveedor", idProv);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@FechaCompra", fecha);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Usuario", usuario);
            comandoTransaccion.SelectCommand.ExecuteNonQuery();
            comandoTransaccion.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();

        }
    }
}
