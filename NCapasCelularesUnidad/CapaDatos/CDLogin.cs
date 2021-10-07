using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDLogin
    {
        private CDConexion conexion = new CDConexion();
        private DataTable tabla = new DataTable();
        private Boolean LogUsuario;
        //con tablas
        public Boolean VerificarTabla(int opt,string usuario, string password)
        {
            SqlDataAdapter comandoLoguin = new SqlDataAdapter("SPUsuarios", conexion.abrirConexion());
            comandoLoguin.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoLoguin.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoLoguin.SelectCommand.Parameters.AddWithValue("@Carnet", usuario);
            comandoLoguin.SelectCommand.Parameters.AddWithValue("@Pass", password);
            tabla.Clear();
            comandoLoguin.Fill(tabla);
            if (tabla.Rows.Count >= 1)
            {
                LogUsuario = true;
            }
            else
            {
                LogUsuario = false;
            }
            conexion.cerrarConexion();
            return LogUsuario;
        }
        public DataTable VerificarAdm(int opt, string usuario)
        {
            SqlDataAdapter comandoLoguin = new SqlDataAdapter("SPUsuarios", conexion.abrirConexion());
            comandoLoguin.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoLoguin.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoLoguin.SelectCommand.Parameters.AddWithValue("@Carnet", usuario);
            tabla.Clear();
            comandoLoguin.Fill(tabla);
            conexion.cerrarConexion();
            return tabla;
        }
        ////con sqldatareader
        //public Boolean VerificarUsuario(string usuario, string password)
        //{
        //    SqlCommand command = new SqlCommand("SPLogin", conexion.abrirConexion());
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@usuario", usuario);
        //    command.Parameters.AddWithValue("@password", password);
        //    leer=command.ExecuteReader();
        //    while (leer.HasRows)
        //    {
                
        //    }
        //    else
        //    {
        //        LogUsuario = false;
        //    }
        //    conexion.cerrarConexion();
        //    tabla.Clear();
        //    return LogUsuario;
        //}
    }
}
