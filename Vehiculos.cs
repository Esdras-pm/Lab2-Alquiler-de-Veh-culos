using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Alquiler_de_Vehículos
{
    class Vehiculos
    {
        string placa;
        string marca;
        string modelo;
        string color;
        float preciopk;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public float Preciopk { get => preciopk; set => preciopk = value; }
    }
}
