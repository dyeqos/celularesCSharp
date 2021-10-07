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
    public class CNCelulares
    {
        private string codigo;
        private string modelo;
        private string rom;
        private string ram;
        private string camara;
        private string frontal;
        private string procesador;
        private string bateria;
        private string so;
        private string huella;
        private string radio;
        private string usb;
        private string ranuras;
        private string marca;
        private string usuario;
        private string opt;

        public string _Opt
        {
            get { return opt; }
            set { opt = value; }
        }
        public string _Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string _Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string _Ranuras
        {
            get { return ranuras; }
            set { ranuras = value; }
        }
        public string _Usb
        {
            get { return usb; }
            set { usb = value; }
        }
        public string _Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public string _Huella
        {
            get { return huella; }
            set { huella = value; }
        }
        public string _So
        {
            get { return so; }
            set { so = value; }
        }
        public string _Bateria
        {
            get { return bateria; }
            set { bateria = value; }
        }
        public string _Procesador
        {
            get { return procesador; }
            set { procesador = value; }
        }
        public string _Frontal
        {
            get { return frontal; }
            set { frontal = value; }
        }
        public string _Camara
        {
            get { return camara; }
            set { camara = value; }
        }
        public string _Ram
        {
            get { return ram; }
            set { ram = value; }
        }
        public string _Rom
        {
            get { return rom; }
            set { rom = value; }
        }
        public string _Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string _Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private CDCelulares objCelulares = new CDCelulares();
        public DataTable mostrarCelulares()
        {
            return objCelulares.verTabla(Convert.ToInt32(_Opt),_Codigo,_Modelo,_Rom,_Ram,_Camara,Convert.ToBoolean(_Radio),Convert.ToInt32(_Ranuras),Convert.ToInt32(_Marca));
        }
        public void transaccionesCelulares()
        {
            objCelulares.transaccionesCelulares(Convert.ToInt32(_Opt),_Codigo,_Modelo,_Rom,_Ram,_Camara,_Frontal,_Procesador,Convert.ToInt32(_Bateria),_So,Convert.ToBoolean(_Huella), Convert.ToBoolean(_Radio),_Usb,Convert.ToInt32(_Ranuras),Convert.ToInt32(_Marca),Convert.ToInt32(_Usuario));

        }
    }
}
