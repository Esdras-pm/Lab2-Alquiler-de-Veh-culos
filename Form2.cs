using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Alquiler_de_Vehículos
{
    public partial class Form2 : Form
    {
        List<Facturas> pago = new List<Facturas>();
        public static Form1 f1 = new Form1();
        public static Form2 f2 = new Form2();

        internal List<Facturas> Pago { get => pago; set => pago = value; }

        public Form2()
        {
            InitializeComponent();
        }

        private void regresarAInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void falquiler_txt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturas agregarc = new Facturas();
            int c = 0;
            for (int i = 0; i < f1.Personas.Count; i++)
                if (f1.Personas[i].Nit == nit_cbx.Text) c = i;
            agregarc.Nombrec = f1.Personas[c].Nombre;
            for (int i = 0; i < f1.Carros.Count; i++)
                if (f1.Carros[i].Placa== placa2_cbx.Text) c = i;
            agregarc.Falquiler = falquiler_date.Value.Date.ToString() + " / " + falquiler_date.Value.Month
                + " / " + falquiler_date.Value.Year;
            agregarc.Fdevolucion = fdevolucion_date.Value.Date.ToString() + " / " + fdevolucion_date.Value.Month
                + " / " + fdevolucion_date.Value.Year;
            agregarc.Pagar = f1.Carros[c].Preciopk * float.Parse(krecorridos_txt.Text);
            agregarc.Placa = f1.Carros[c].Placa;
            agregarc.Marca = f1.Carros[c].Marca;
            agregarc.Modelo = f1.Carros[c].Modelo;
            agregarc.Color = f1.Carros[c].Color;
            agregarc.Preciopk = f1.Carros[c].Preciopk;
            Pago.Add(agregarc);
            f1.mostrar(3);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
