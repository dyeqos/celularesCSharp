using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDProveedores
    {
        private CDConexion conexion = new CDConexion();
        private DataTable tabla = new DataTable();
        public DataTable verTabla(int opt,string cod, string nom, string ape)
        {
            SqlDataAdapter comandoVer = new SqlDataAdapter("SPProveedores", conexion.abrirConexion());
            comandoVer.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoVer.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdProveedor", cod);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Nombre", nom);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Apellidos", ape);
            tabla.Clear();
            comandoVer.Fill(tabla);
            comandoVer.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();
            return tabla;
        }
        public void transaccionesProveedores(int opt, string cod, string nom, string ape, string dir, int telf, string user)
        {
            SqlDataAdapter comandoTransaccion = new SqlDataAdapter("SPProveedores", conexion.abrirConexion());
            comandoTransaccion.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdProveedor", cod);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Nombre", nom);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Apellidos", ape);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Direccion", dir);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Telefono", telf);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Usuario", user);
            comandoTransaccion.SelectCommand.ExecuteNonQuery();
            comandoTransaccion.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();

        }
    }
}
