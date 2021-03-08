using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Alquiler_de_Vehículos
{
    class Factura : Vehículos
    {
        //Nombre del cliente, los datos del automóvil,
        //la fecha de devolución, y el total a pagar,  de todos los vehículos que están alquilados.
        string nombrec;
        string falquiler;
        string fdevolucion;
        float pagar;

        public string Nombrec { get => nombrec; set => nombrec = value; }
        public string Falquiler { get => falquiler; set => falquiler = value; }
        public string Fdevolucion { get => fdevolucion; set => fdevolucion = value; }
        public float Pagar { get => pagar; set => pagar = value; }
    }
}
