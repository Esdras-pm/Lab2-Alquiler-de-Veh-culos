﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Alquiler_de_Vehículos
{
    class Clientes
    {
        string nit;
        string nombre;
        string direccion;

        public string Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
