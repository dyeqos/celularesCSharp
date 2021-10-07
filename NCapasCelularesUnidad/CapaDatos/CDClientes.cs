using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDClientes
    {
        private CDConexion conexion = new CDConexion();
        private DataTable tabla = new DataTable();
        public DataTable verTabla(int opt, int cod, string ci, string nom, string ape)
        {
            SqlDataAdapter comandoVer = new SqlDataAdapter("SPClientes", conexion.abrirConexion());
            comandoVer.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoVer.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdCliente", cod);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Carnet", ci);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Nombres", nom);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Apellidos", ape);
            tabla.Clear();
            comandoVer.Fill(tabla);
            comandoVer.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();
            return tabla;
        }
        public void transaccionesClientes(int opt, int cod, string ci, string nom, string ape, int telf, int user)
        {
            SqlDataAdapter comandoTransaccion = new SqlDataAdapter("SPClientes", conexion.abrirConexion());
            comandoTransaccion.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdCliente", cod);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Carnet", ci);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Nombres", nom);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Apellidos", ape);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Telefono", telf);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Usuario", user);
            comandoTransaccion.SelectCommand.ExecuteNonQuery();
            comandoTransaccion.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();

        }
    }
}
