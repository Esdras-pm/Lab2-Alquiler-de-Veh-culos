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
        public Form2()
        {
            InitializeComponent();
        }

        private void regresarAInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void falquiler_txt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
