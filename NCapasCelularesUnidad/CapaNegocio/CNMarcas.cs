using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNMarcas
    {
        private string opt;
        private string idMarca;
        private string nombre;
        private string descripcion;
        private string telefono;
        private string dirGarantia;
        private string usuario;
        public string _Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string _DirGarantia
        {
            get { return dirGarantia; }
            set { dirGarantia = value; }
        }
        public string _Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string _Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string _Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string _IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }
        public string _Opt
        {
            get { return opt; }
            set { opt = value; }
        }

        private CDMarcas objMarcas = new CDMarcas();
        public DataTable mostrarMarcas()
        {
            return objMarcas.verTabla(Convert.ToInt32(_Opt),Convert.ToInt32(_IdMarca),_Nombre);
        }
        public void transaccionesMarcas()
        {
            objMarcas.transaccionesMarcas(Convert.ToInt32(_Opt), Convert.ToInt32(_IdMarca), _Nombre,_Descripcion,Convert.ToInt32(_Telefono),_DirGarantia,Convert.ToInt32(_Usuario));
        }
    }
}
