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
    public partial class Form1 : Form
    {
        List<Vehiculos> carros = new List<Vehiculos>();
        List<Clientes> personas = new List<Clientes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void verVehículosAlquiladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehiculos agregarc = new Vehiculos();
            int c = 0;
            for(int i=0;i<carros.Count;i++)
            {
                if (carros[i].Placa == placa_txt.Text) c++;
            }
            if (c == 0)
            {
                agregarc.Placa = placa_txt.Text;
                agregarc.Marca = marca_txt.Text;
                agregarc.Modelo = modelo_txt.Text;
                agregarc.Color = color_txt.Text;
                agregarc.Preciopk = float.Parse(precio1_txt.Text);
            }
            
        }
    }
}
