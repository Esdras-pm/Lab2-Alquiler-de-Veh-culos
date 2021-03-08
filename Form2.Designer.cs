
namespace Lab2_Alquiler_de_Vehículos
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarAInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.placa2_cbx = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fdevolucion_txt = new System.Windows.Forms.DateTimePicker();
            this.falquiler_txt = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nit_cbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarAInicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regresarAInicioToolStripMenuItem
            // 
            this.regresarAInicioToolStripMenuItem.Name = "regresarAInicioToolStripMenuItem";
            this.regresarAInicioToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.regresarAInicioToolStripMenuItem.Text = "Regresar a Inicio";
            this.regresarAInicioToolStripMenuItem.Click += new System.EventHandler(this.regresarAInicioToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 17);
            this.label15.TabIndex = 51;
            this.label15.Text = "Kilómetros recorridos";
            // 
            // placa2_cbx
            // 
            this.placa2_cbx.FormattingEnabled = true;
            this.placa2_cbx.Location = new System.Drawing.Point(197, 109);
            this.placa2_cbx.Name = "placa2_cbx";
            this.placa2_cbx.Size = new System.Drawing.Size(126, 24);
            this.placa2_cbx.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(148, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 49;
            this.label14.Text = "Placa";
            // 
            // fdevolucion_txt
            // 
            this.fdevolucion_txt.Location = new System.Drawing.Point(197, 169);
            this.fdevolucion_txt.Name = "fdevolucion_txt";
            this.fdevolucion_txt.Size = new System.Drawing.Size(251, 22);
            this.fdevolucion_txt.TabIndex = 48;
            // 
            // falquiler_txt
            // 
            this.falquiler_txt.Location = new System.Drawing.Point(197, 141);
            this.falquiler_txt.Name = "falquiler_txt";
            this.falquiler_txt.Size = new System.Drawing.Size(251, 22);
            this.falquiler_txt.TabIndex = 47;
            this.falquiler_txt.ValueChanged += new System.EventHandler(this.falquiler_txt_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Fecha de devolución";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Fecha de alquiler ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ingresar Datos de Factura";
            // 
            // nit_cbx
            // 
            this.nit_cbx.FormattingEnabled = true;
            this.nit_cbx.Location = new System.Drawing.Point(197, 226);
            this.nit_cbx.Name = "nit_cbx";
            this.nit_cbx.Size = new System.Drawing.Size(126, 24);
            this.nit_cbx.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "NIT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 56;
            this.button1.Text = "Agregar Factura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 233);
            this.dataGridView1.TabIndex = 57;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nit_cbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.placa2_cbx);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fdevolucion_txt);
            this.Controls.Add(this.falquiler_txt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarAInicioToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox placa2_cbx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker fdevolucion_txt;
        private System.Windows.Forms.DateTimePicker falquiler_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nit_cbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}