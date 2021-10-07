using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCelulares
    {
        private CDConexion conexion = new CDConexion();
        private DataTable tabla = new DataTable();
        public DataTable verTabla(int opt, string cod, string mod, string rom, string ram, string cam, Boolean radio,int ranura, int marca)
        {
            SqlDataAdapter comandoVer = new SqlDataAdapter("SPCelulares", conexion.abrirConexion());
            comandoVer.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoVer.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoVer.SelectCommand.Parameters.AddWithValue("@CodCel", cod);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Modelo", mod);
            comandoVer.SelectCommand.Parameters.AddWithValue("@ROM", rom);
            comandoVer.SelectCommand.Parameters.AddWithValue("@RAM", ram);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Camara", cam);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Radio", radio);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Ranuras", ranura);
            comandoVer.SelectCommand.Parameters.AddWithValue("@Marca", marca);
            tabla.Clear();
            comandoVer.Fill(tabla);
            comandoVer.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();
            return tabla;
        }
        public void transaccionesCelulares(int opt, string cod, string mod, string rom, string ram, string cam, string front, string proc, int bateria, string so, Boolean huella, Boolean radio, string usb, int ranura, int marca, int user)
        {
            SqlDataAdapter comandoTransaccion = new SqlDataAdapter("SPCelulares", conexion.abrirConexion());
            comandoTransaccion.SelectCommand.CommandType = CommandType.StoredProcedure;
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Opt", opt);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@CodCel", cod);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Modelo", mod);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@ROM", rom);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@RAM", ram);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Camara", cam);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Frontal", front);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Procesador", proc);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Bateria", bateria);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@SO", so);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Huella", huella);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Radio", radio);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@USB", usb);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Ranuras", ranura);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Marca", marca);
            comandoTransaccion.SelectCommand.Parameters.AddWithValue("@Usuario", user);
            comandoTransaccion.SelectCommand.ExecuteNonQuery();
            comandoTransaccion.SelectCommand.Parameters.Clear();
            conexion.cerrarConexion();

        }
    }
}
