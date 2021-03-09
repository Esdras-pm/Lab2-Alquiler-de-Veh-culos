using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public static Form2 f2 = new Form2();
        public static Form1 f1 = new Form1();

        internal List<Vehiculos> Carros { get => carros; set => carros = value; }
        internal List<Clientes> Personas { get => personas; set => personas = value; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Leer(int c)
        {
            if (c == 1)
            {
                FileStream stream = new FileStream("Vehículos.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Vehiculos datos = new Vehiculos();
                    datos.Placa = reader.ReadLine();
                    datos.Marca = reader.ReadLine();
                    datos.Modelo = reader.ReadLine();
                    datos.Color = reader.ReadLine();
                    datos.Preciopk = float.Parse(reader.ReadLine());
                    Carros.Add(datos);
                }
                //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
                reader.Close();
            }
            else if (c == 2)
            {
                FileStream stream = new FileStream("Clientes.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Clientes datos = new Clientes();
                    datos.Nit = reader.ReadLine();
                    datos.Nombre = reader.ReadLine();
                    datos.Direccion = reader.ReadLine();
                    Personas.Add(datos);
                }
                //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
                reader.Close();
            }
            else
            {
                FileStream stream = new FileStream("Factura.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Facturas datos = new Facturas();
                    /*writer.WriteLine(p.Placa);
                    writer.WriteLine(p.Marca);
                    writer.WriteLine(p.Modelo);
                    writer.WriteLine(p.Color);
                    writer.WriteLine(p.Preciopk);
                    writer.WriteLine(p.Nombrec);
                    writer.WriteLine(p.Falquiler);
                    writer.WriteLine(p.Fdevolucion);
                    writer.WriteLine(p.Pagar);*/
                    datos.Placa = reader.ReadLine();
                    datos.Marca = reader.ReadLine();
                    datos.Modelo = reader.ReadLine();
                    datos.Color = reader.ReadLine();
                    datos.Preciopk = float.Parse(reader.ReadLine());
                    datos.Nombrec = reader.ReadLine();
                    datos.Falquiler = reader.ReadLine();
                    datos.Fdevolucion = reader.ReadLine();
                    datos.Pagar = float.Parse(reader.ReadLine());
                    f2.Pago.Add(datos);
                }
                //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
                reader.Close();
            }
        }
        private void guardar(int c)
        {
            if (c == 1)
            {
                FileStream stream = new FileStream("Vehículos.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);


                foreach (var p in Carros)
                {
                    writer.WriteLine(p.Placa);
                    writer.WriteLine(p.Marca);
                    writer.WriteLine(p.Modelo);
                    writer.WriteLine(p.Color);
                    writer.WriteLine(p.Preciopk);
                }
                writer.Close();
            }
            else if (c == 2)
            {
                FileStream stream = new FileStream("Clientes.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);


                foreach (var p in Personas)
                {
                    writer.WriteLine(p.Nit);
                    writer.WriteLine(p.Nombre);
                    writer.WriteLine(p.Direccion);
                }
                writer.Close();
            }
            else
            {
                FileStream stream = new FileStream("Factura.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);


                foreach (var p in f2.Pago)
                {
                    writer.WriteLine(p.Placa);
                    writer.WriteLine(p.Marca);
                    writer.WriteLine(p.Modelo);
                    writer.WriteLine(p.Color);
                    writer.WriteLine(p.Preciopk);
                    writer.WriteLine(p.Nombrec);
                    writer.WriteLine(p.Falquiler);
                    writer.WriteLine(p.Fdevolucion);
                    writer.WriteLine(p.Pagar);
                }
                writer.Close();
            }
        }
        public void mostrar(int c)
        {
            string[] placas = new string[carros.Count];
            string[] nits = new string[personas.Count];
            if (c==1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Carros;
                dataGridView1.Refresh();
                guardar(1);
            }
            else if(c==2)
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Personas;
                dataGridView2.Refresh();
                guardar(2);
            }
            else
            {
                f2.dataGridView1.DataSource = null;
                f2.dataGridView1.DataSource = f2.Pago;
                f2.dataGridView1.Refresh();
                guardar(3);
            }
            for (int i = 0; i < carros.Count; i++) placas[i] = carros[i].Placa;
            f2.placa2_cbx.Items.Clear();
            f2.placa2_cbx.Items.AddRange(placas);
            for (int i = 0; i < personas.Count; i++) nits[i] = personas[i].Nit;
            f2.nit_cbx.Items.Clear();
            f2.nit_cbx.Items.AddRange(nits);
        }
        private void verVehículosAlquiladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehiculos agregarc = new Vehiculos();
            int c = 0;
            for(int i=0;i<Carros.Count;i++)
                if (Carros[i].Placa == placa_txt.Text) c++;
            if (c == 0)
            {
                agregarc.Placa = placa_txt.Text;
                agregarc.Marca = marca_txt.Text;
                agregarc.Modelo = modelo_txt.Text;
                agregarc.Color = color_txt.Text;
                agregarc.Preciopk = float.Parse(precio1_txt.Text);
                Carros.Add(agregarc);
                mostrar(1);
            }
            else
            {
                Vehiculos rep = Carros.Find(p => p.Placa == placa_txt.Text);
                MessageBox.Show("Este vehículo con placa "+rep.Placa+ " está ingresado al inventario");
            }
            placa_txt.Text = "";
            marca_txt.Text = "";
            modelo_txt.Text = "";
            color_txt.Text = "";
            precio1_txt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes agregarc = new Clientes();
            int c = 0;
            for (int i = 0; i < Personas.Count; i++)
                if (Personas[i].Nit== nit_txt.Text) c++;
            if (c == 0)
            {
                agregarc.Nit = nit_txt.Text;
                agregarc.Nombre = nombre_txt.Text;
                agregarc.Direccion = direccion_txt.Text;
                Personas.Add(agregarc);
                mostrar(2);
            }
            else
            {
                Clientes rep = Personas.Find(p => p.Nit == nit_txt.Text);
                MessageBox.Show(rep.Nombre+" ya tiene este mismo NIT: "+rep.Nit);
            }
            nit_txt.Text = "";
            nombre_txt.Text = "";
            direccion_txt.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Vehículos.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            FileStream stream2 = new FileStream("Clientes.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);
            FileStream stream3 = new FileStream("Factura.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader3 = new StreamReader(stream3);
            string leer = reader.ReadToEnd();
            string leer2 = reader2.ReadToEnd();
            string leer3 = reader3.ReadToEnd();
            reader.Close();
            reader2.Close();
            reader3.Close();
            if (!leer.Equals(""))
            {
                Leer(1);
                mostrar(1);
            }
            if (!leer2.Equals(""))
            {
                Leer(2);
                mostrar(2);
            }
            if (!leer3.Equals(""))
            {
                Leer(3);
                mostrar(3);
            }
        }
    }
}
