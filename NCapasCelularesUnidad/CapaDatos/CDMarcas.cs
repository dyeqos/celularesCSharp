using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDMarcas
    {
        private CDConexion conexion = new CDConexion();
        private DataTable tabla = new DataTable();
        public DataTable verTabla(int opt, int idMarc,string nom)
        {
            SqlDataAdapter comandoVer = new SqlDataAdapter("SPMarcas", conexion.abrirConexion());
            comandoVer.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoVer.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoVer.SelectCommand.Parameters.AddWithValue("@IdMarca", idMarc);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Nombre", nom);
            tabla.Clear();
            comandoVer.Fill(tabla);
            comandoVer.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();
            return tabla;
        }
        public void transaccionesMarcas(int opt, int idMarc, string nom, string desc, int telf, string garan, int user)
        {
            SqlDataAdapter comandoTransaccion = new SqlDataAdapter("SPMarcas", conexion.abrirConexion());
            comandoTransaccion.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@IdMarca", idMarc);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Nombre", nom);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Descripcion", desc);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Telefono", telf);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@DirGarantia", garan);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Usuario", user);
            comandoTransaccion.SelectCommand.ExecuteNonQuery();
            comandoTransaccion.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();

        }
    }
}
