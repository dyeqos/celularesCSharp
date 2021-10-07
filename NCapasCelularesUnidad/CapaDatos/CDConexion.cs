using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDConexion
    {
        //private SqlConnection Conexion = new SqlConnection("Data Source=LocalHost; Initial Catalog=DesSistemasI; User ID=sa; Password=12345"); Server= localhost; Database= employeedetails; Integrated Security = True;
        private SqlConnection Conexion = new SqlConnection("Server= localhost; Database= DesSistemasI; Integrated Security = True;");

        public SqlConnection abrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection cerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}