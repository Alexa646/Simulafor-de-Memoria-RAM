
namespace Simulafdor_de_Memoria_RAM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBoxDirecInicial = new ListBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            numericUpDownMemoria = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            timer3 = new System.Windows.Forms.Timer(components);
            panelMemSlot1 = new Panel();
            labelProcesNom1 = new Label();
            panelMemSlot2 = new Panel();
            labelProcesNom2 = new Label();
            panelMemSlot3 = new Panel();
            labelProcesNom3 = new Label();
            panelMemSlot4 = new Panel();
            labelProcesNom4 = new Label();
            panelMemSlot5 = new Panel();
            labelProcesNom5 = new Label();
            panelMemSlot6 = new Panel();
            labelProcesNom6 = new Label();
            panel10 = new Panel();
            panelMemSlot7 = new Panel();
            labelProcesNom7 = new Label();
            panel12 = new Panel();
            panelMemSlot8 = new Panel();
            labelProcesNom8 = new Label();
            panel14 = new Panel();
            panelMemSlot9 = new Panel();
            labelProcesNom9 = new Label();
            panel16 = new Panel();
            panelMemSlot10 = new Panel();
            labelProcesNom10 = new Label();
            panel18 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label20 = new Label();
            buttonRenaudarTodo = new Button();
            buttonRenaudarProceso = new Button();
            label19 = new Label();
            panel4 = new Panel();
            label21 = new Label();
            panel5 = new Panel();
            label22 = new Label();
            panel6 = new Panel();
            numericUpDownPausaProceso = new NumericUpDown();
            label23 = new Label();
            label24 = new Label();
            panel7 = new Panel();
            label25 = new Label();
            label26 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMemoria).BeginInit();
            panelMemSlot1.SuspendLayout();
            panelMemSlot2.SuspendLayout();
            panelMemSlot3.SuspendLayout();
            panelMemSlot4.SuspendLayout();
            panelMemSlot5.SuspendLayout();
            panelMemSlot6.SuspendLayout();
            panelMemSlot7.SuspendLayout();
            panelMemSlot8.SuspendLayout();
            panelMemSlot9.SuspendLayout();
            panelMemSlot10.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPausaProceso).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxDirecInicial
            // 
            listBoxDirecInicial.BackColor = Color.FromArgb(255, 192, 255);
            listBoxDirecInicial.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBoxDirecInicial.ForeColor = Color.DimGray;
            listBoxDirecInicial.FormattingEnabled = true;
            listBoxDirecInicial.ItemHeight = 20;
            listBoxDirecInicial.Location = new Point(12, 239);
            listBoxDirecInicial.Name = "listBoxDirecInicial";
            listBoxDirecInicial.Size = new Size(258, 284);
            listBoxDirecInicial.TabIndex = 0;
            listBoxDirecInicial.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 215);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 3;
            label1.Text = "Direccion inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(136, 215);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 5;
            label2.Text = "Longitud";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 136);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 192, 128);
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, -8);
            label4.Name = "label4";
            label4.Size = new Size(250, 46);
            label4.TabIndex = 3;
            label4.Text = "Asignacion de espacio";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(128, 255, 255);
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(294, 47);
            label5.Name = "label5";
            label5.Size = new Size(226, 32);
            label5.TabIndex = 10;
            label5.Text = "Memoria RAM";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // numericUpDownMemoria
            // 
            numericUpDownMemoria.BackColor = Color.FromArgb(192, 255, 255);
            numericUpDownMemoria.Location = new Point(12, 47);
            numericUpDownMemoria.Name = "numericUpDownMemoria";
            numericUpDownMemoria.Size = new Size(199, 23);
            numericUpDownMemoria.TabIndex = 11;
            numericUpDownMemoria.TextAlign = HorizontalAlignment.Right;
            numericUpDownMemoria.ValueChanged += numericUpDownMemoria_ValueChanged;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(128, 255, 255);
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 28);
            label6.Name = "label6";
            label6.Size = new Size(244, 21);
            label6.TabIndex = 12;
            label6.Text = "Tamano de Memoria RAM";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(192, 255, 255);
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(207, 47);
            label7.Name = "label7";
            label7.Size = new Size(49, 21);
            label7.TabIndex = 13;
            label7.Text = "KB";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.GrayText;
            label8.Location = new Point(740, 42);
            label8.Name = "label8";
            label8.Size = new Size(83, 496);
            label8.TabIndex = 14;
            label8.Text = "S\r\ni\r\nm\r\nu\r\nl\r\na\r\nd\r\no\r\nr\r\n\r\nd\r\ne";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 224, 192);
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(206, 215);
            label9.Name = "label9";
            label9.Size = new Size(64, 21);
            label9.TabIndex = 16;
            label9.Text = "Tiempo";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Location = new Point(19, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(25, 29);
            panel2.TabIndex = 21;
            panel2.Paint += panel2_Paint;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Tick += timer3_Tick;
            // 
            // panelMemSlot1
            // 
            panelMemSlot1.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot1.Controls.Add(labelProcesNom1);
            panelMemSlot1.Location = new Point(294, 84);
            panelMemSlot1.Name = "panelMemSlot1";
            panelMemSlot1.Size = new Size(228, 39);
            panelMemSlot1.TabIndex = 25;
            // 
            // labelProcesNom1
            // 
            labelProcesNom1.AutoSize = true;
            labelProcesNom1.Location = new Point(20, 13);
            labelProcesNom1.Name = "labelProcesNom1";
            labelProcesNom1.Size = new Size(104, 15);
            labelProcesNom1.TabIndex = 29;
            labelProcesNom1.Text = "labelProcesNom1";
            // 
            // panelMemSlot2
            // 
            panelMemSlot2.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot2.Controls.Add(labelProcesNom2);
            panelMemSlot2.Location = new Point(294, 129);
            panelMemSlot2.Name = "panelMemSlot2";
            panelMemSlot2.Size = new Size(228, 39);
            panelMemSlot2.TabIndex = 26;
            // 
            // labelProcesNom2
            // 
            labelProcesNom2.AutoSize = true;
            labelProcesNom2.Location = new Point(20, 12);
            labelProcesNom2.Name = "labelProcesNom2";
            labelProcesNom2.Size = new Size(104, 15);
            labelProcesNom2.TabIndex = 30;
            labelProcesNom2.Text = "labelProcesNom2";
            // 
            // panelMemSlot3
            // 
            panelMemSlot3.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot3.Controls.Add(labelProcesNom3);
            panelMemSlot3.Location = new Point(294, 174);
            panelMemSlot3.Name = "panelMemSlot3";
            panelMemSlot3.Size = new Size(228, 39);
            panelMemSlot3.TabIndex = 27;
            // 
            // labelProcesNom3
            // 
            labelProcesNom3.AutoSize = true;
            labelProcesNom3.Location = new Point(20, 15);
            labelProcesNom3.Name = "labelProcesNom3";
            labelProcesNom3.Size = new Size(104, 15);
            labelProcesNom3.TabIndex = 31;
            labelProcesNom3.Text = "labelProcesNom3";
            labelProcesNom3.Click += labelProcesNom3_Click;
            // 
            // panelMemSlot4
            // 
            panelMemSlot4.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot4.Controls.Add(labelProcesNom4);
            panelMemSlot4.Location = new Point(294, 219);
            panelMemSlot4.Name = "panelMemSlot4";
            panelMemSlot4.Size = new Size(228, 39);
            panelMemSlot4.TabIndex = 26;
            // 
            // labelProcesNom4
            // 
            labelProcesNom4.AutoSize = true;
            labelProcesNom4.Location = new Point(20, 12);
            labelProcesNom4.Name = "labelProcesNom4";
            labelProcesNom4.Size = new Size(104, 15);
            labelProcesNom4.TabIndex = 32;
            labelProcesNom4.Text = "labelProcesNom4";
            // 
            // panelMemSlot5
            // 
            panelMemSlot5.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot5.Controls.Add(labelProcesNom5);
            panelMemSlot5.Location = new Point(294, 264);
            panelMemSlot5.Name = "panelMemSlot5";
            panelMemSlot5.Size = new Size(228, 39);
            panelMemSlot5.TabIndex = 26;
            // 
            // labelProcesNom5
            // 
            labelProcesNom5.AutoSize = true;
            labelProcesNom5.Location = new Point(20, 12);
            labelProcesNom5.Name = "labelProcesNom5";
            labelProcesNom5.Size = new Size(104, 15);
            labelProcesNom5.TabIndex = 33;
            labelProcesNom5.Text = "labelProcesNom5";
            // 
            // panelMemSlot6
            // 
            panelMemSlot6.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot6.Controls.Add(labelProcesNom6);
            panelMemSlot6.Controls.Add(panel10);
            panelMemSlot6.Location = new Point(294, 309);
            panelMemSlot6.Name = "panelMemSlot6";
            panelMemSlot6.Size = new Size(228, 39);
            panelMemSlot6.TabIndex = 26;
            // 
            // labelProcesNom6
            // 
            labelProcesNom6.AutoSize = true;
            labelProcesNom6.Location = new Point(20, 12);
            labelProcesNom6.Name = "labelProcesNom6";
            labelProcesNom6.Size = new Size(104, 15);
            labelProcesNom6.TabIndex = 34;
            labelProcesNom6.Text = "labelProcesNom6";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(255, 224, 192);
            panel10.Location = new Point(3, 45);
            panel10.Name = "panel10";
            panel10.Size = new Size(211, 39);
            panel10.TabIndex = 26;
            // 
            // panelMemSlot7
            // 
            panelMemSlot7.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot7.Controls.Add(labelProcesNom7);
            panelMemSlot7.Controls.Add(panel12);
            panelMemSlot7.Location = new Point(294, 354);
            panelMemSlot7.Name = "panelMemSlot7";
            panelMemSlot7.Size = new Size(228, 39);
            panelMemSlot7.TabIndex = 27;
            // 
            // labelProcesNom7
            // 
            labelProcesNom7.AutoSize = true;
            labelProcesNom7.Location = new Point(20, 14);
            labelProcesNom7.Name = "labelProcesNom7";
            labelProcesNom7.Size = new Size(104, 15);
            labelProcesNom7.TabIndex = 35;
            labelProcesNom7.Text = "labelProcesNom7";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(255, 224, 192);
            panel12.Location = new Point(3, 45);
            panel12.Name = "panel12";
            panel12.Size = new Size(211, 39);
            panel12.TabIndex = 26;
            // 
            // panelMemSlot8
            // 
            panelMemSlot8.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot8.Controls.Add(labelProcesNom8);
            panelMemSlot8.Controls.Add(panel14);
            panelMemSlot8.Location = new Point(294, 399);
            panelMemSlot8.Name = "panelMemSlot8";
            panelMemSlot8.Size = new Size(228, 39);
            panelMemSlot8.TabIndex = 27;
            // 
            // labelProcesNom8
            // 
            labelProcesNom8.AutoSize = true;
            labelProcesNom8.Location = new Point(20, 12);
            labelProcesNom8.Name = "labelProcesNom8";
            labelProcesNom8.Size = new Size(104, 15);
            labelProcesNom8.TabIndex = 36;
            labelProcesNom8.Text = "labelProcesNom8";
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(255, 224, 192);
            panel14.Location = new Point(3, 45);
            panel14.Name = "panel14";
            panel14.Size = new Size(211, 39);
            panel14.TabIndex = 26;
            // 
            // panelMemSlot9
            // 
            panelMemSlot9.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot9.Controls.Add(labelProcesNom9);
            panelMemSlot9.Controls.Add(panel16);
            panelMemSlot9.Location = new Point(294, 447);
            panelMemSlot9.Name = "panelMemSlot9";
            panelMemSlot9.Size = new Size(228, 39);
            panelMemSlot9.TabIndex = 28;
            // 
            // labelProcesNom9
            // 
            labelProcesNom9.AutoSize = true;
            labelProcesNom9.Location = new Point(20, 12);
            labelProcesNom9.Name = "labelProcesNom9";
            labelProcesNom9.Size = new Size(104, 15);
            labelProcesNom9.TabIndex = 37;
            labelProcesNom9.Text = "labelProcesNom9";
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(255, 224, 192);
            panel16.Location = new Point(3, 45);
            panel16.Name = "panel16";
            panel16.Size = new Size(211, 39);
            panel16.TabIndex = 26;
            // 
            // panelMemSlot10
            // 
            panelMemSlot10.BackColor = Color.FromArgb(192, 255, 255);
            panelMemSlot10.Controls.Add(labelProcesNom10);
            panelMemSlot10.Controls.Add(panel18);
            panelMemSlot10.Location = new Point(294, 495);
            panelMemSlot10.Name = "panelMemSlot10";
            panelMemSlot10.Size = new Size(228, 39);
            panelMemSlot10.TabIndex = 28;
            // 
            // labelProcesNom10
            // 
            labelProcesNom10.AutoSize = true;
            labelProcesNom10.Location = new Point(20, 12);
            labelProcesNom10.Name = "labelProcesNom10";
            labelProcesNom10.Size = new Size(111, 15);
            labelProcesNom10.TabIndex = 38;
            labelProcesNom10.Text = "labelProcesNom10";
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(255, 224, 192);
            panel18.Location = new Point(3, 45);
            panel18.Name = "panel18";
            panel18.Size = new Size(211, 39);
            panel18.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 255);
            panel3.Location = new Point(19, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(24, 29);
            panel3.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 56);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 30;
            label3.Text = "label3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(128, 255, 255);
            label10.Location = new Point(12, 50);
            label10.Name = "label10";
            label10.Size = new Size(14, 15);
            label10.TabIndex = 31;
            label10.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(128, 255, 255);
            label11.Location = new Point(12, 461);
            label11.Name = "label11";
            label11.Size = new Size(14, 15);
            label11.TabIndex = 32;
            label11.Text = "9";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(128, 255, 255);
            label12.Location = new Point(12, 411);
            label12.Name = "label12";
            label12.Size = new Size(14, 15);
            label12.TabIndex = 33;
            label12.Text = "8";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(128, 255, 255);
            label13.Location = new Point(12, 363);
            label13.Name = "label13";
            label13.Size = new Size(14, 15);
            label13.TabIndex = 34;
            label13.Text = "7";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(128, 255, 255);
            label14.Location = new Point(12, 321);
            label14.Name = "label14";
            label14.Size = new Size(14, 15);
            label14.TabIndex = 35;
            label14.Text = "6";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(128, 255, 255);
            label15.Location = new Point(12, 271);
            label15.Name = "label15";
            label15.Size = new Size(14, 15);
            label15.TabIndex = 36;
            label15.Text = "5";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(128, 255, 255);
            label16.Location = new Point(12, 226);
            label16.Name = "label16";
            label16.Size = new Size(14, 15);
            label16.TabIndex = 37;
            label16.Text = "4";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(128, 255, 255);
            label17.Location = new Point(12, 184);
            label17.Name = "label17";
            label17.Size = new Size(14, 15);
            label17.TabIndex = 38;
            label17.Text = "3";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(128, 255, 255);
            label18.Location = new Point(12, 94);
            label18.Name = "label18";
            label18.Size = new Size(14, 15);
            label18.TabIndex = 39;
            label18.Text = "1";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(128, 255, 255);
            label20.Location = new Point(12, 142);
            label20.Name = "label20";
            label20.Size = new Size(14, 15);
            label20.TabIndex = 41;
            label20.Text = "2";
            // 
            // buttonRenaudarTodo
            // 
            buttonRenaudarTodo.BackColor = Color.FromArgb(128, 255, 128);
            buttonRenaudarTodo.Font = new Font("Wingdings 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buttonRenaudarTodo.Location = new Point(41, 55);
            buttonRenaudarTodo.Name = "buttonRenaudarTodo";
            buttonRenaudarTodo.Size = new Size(75, 30);
            buttonRenaudarTodo.TabIndex = 42;
            buttonRenaudarTodo.Text = "}";
            buttonRenaudarTodo.UseVisualStyleBackColor = false;
            buttonRenaudarTodo.Click += buttonPausar_Click;
            // 
            // buttonRenaudarProceso
            // 
            buttonRenaudarProceso.BackColor = Color.FromArgb(128, 255, 128);
            buttonRenaudarProceso.Font = new Font("Wingdings 3", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buttonRenaudarProceso.Location = new Point(41, 49);
            buttonRenaudarProceso.Name = "buttonRenaudarProceso";
            buttonRenaudarProceso.Size = new Size(75, 30);
            buttonRenaudarProceso.TabIndex = 43;
            buttonRenaudarProceso.Text = "}";
            buttonRenaudarProceso.UseVisualStyleBackColor = false;
            buttonRenaudarProceso.Click += buttonRenaudarProceso_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(76, 81);
            label19.Name = "label19";
            label19.Size = new Size(47, 15);
            label19.TabIndex = 46;
            label19.Text = "label19";
            label19.Click += label19_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 255, 255);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Location = new Point(528, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(37, 487);
            panel4.TabIndex = 47;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(128, 255, 255);
            label21.Location = new Point(12, 11);
            label21.Name = "label21";
            label21.Size = new Size(10, 15);
            label21.TabIndex = 42;
            label21.Text = "i";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 192, 255);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(buttonRenaudarTodo);
            panel5.Location = new Point(584, 58);
            panel5.Name = "panel5";
            panel5.Size = new Size(160, 110);
            panel5.TabIndex = 48;
            // 
            // label22
            // 
            label22.BackColor = Color.FromArgb(128, 128, 255);
            label22.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(159, 38);
            label22.TabIndex = 4;
            label22.Text = "Pausa general";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 192, 255);
            panel6.Controls.Add(numericUpDownPausaProceso);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(buttonRenaudarProceso);
            panel6.Location = new Point(584, 174);
            panel6.Name = "panel6";
            panel6.Size = new Size(160, 129);
            panel6.TabIndex = 49;
            // 
            // numericUpDownPausaProceso
            // 
            numericUpDownPausaProceso.Location = new Point(19, 85);
            numericUpDownPausaProceso.Name = "numericUpDownPausaProceso";
            numericUpDownPausaProceso.Size = new Size(120, 23);
            numericUpDownPausaProceso.TabIndex = 51;
            numericUpDownPausaProceso.ValueChanged += numericUpDownPausaProceso_ValueChanged;
            // 
            // label23
            // 
            label23.BackColor = Color.FromArgb(255, 128, 255);
            label23.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(0, 0);
            label23.Name = "label23";
            label23.Size = new Size(160, 38);
            label23.TabIndex = 4;
            label23.Text = "Pausa Proceso";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.GrayText;
            label24.Location = new Point(806, 52);
            label24.Name = "label24";
            label24.Size = new Size(83, 431);
            label24.TabIndex = 50;
            label24.Text = "m\r\ne\r\nm\r\no\r\nr\r\ni\r\na\r\n\r\nR\r\nA\r\nM";
            label24.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 255, 192);
            panel7.Controls.Add(label26);
            panel7.Controls.Add(label25);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(584, 318);
            panel7.Name = "panel7";
            panel7.Size = new Size(160, 155);
            panel7.TabIndex = 9;
            // 
            // label25
            // 
            label25.BackColor = Color.FromArgb(255, 255, 128);
            label25.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(-3, 0);
            label25.Name = "label25";
            label25.Size = new Size(163, 56);
            label25.TabIndex = 3;
            label25.Text = "Informacion\r\nDebug\r\n";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(83, 110);
            label26.Name = "label26";
            label26.Size = new Size(47, 15);
            label26.TabIndex = 47;
            label26.Text = "label26";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(873, 543);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panelMemSlot10);
            Controls.Add(panelMemSlot9);
            Controls.Add(panelMemSlot8);
            Controls.Add(panelMemSlot7);
            Controls.Add(panelMemSlot6);
            Controls.Add(panelMemSlot5);
            Controls.Add(panelMemSlot4);
            Controls.Add(panelMemSlot3);
            Controls.Add(panelMemSlot2);
            Controls.Add(panelMemSlot1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(numericUpDownMemoria);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(listBoxDirecInicial);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(panel4);
            Controls.Add(label24);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Simulador de RAM";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownMemoria).EndInit();
            panelMemSlot1.ResumeLayout(false);
            panelMemSlot1.PerformLayout();
            panelMemSlot2.ResumeLayout(false);
            panelMemSlot2.PerformLayout();
            panelMemSlot3.ResumeLayout(false);
            panelMemSlot3.PerformLayout();
            panelMemSlot4.ResumeLayout(false);
            panelMemSlot4.PerformLayout();
            panelMemSlot5.ResumeLayout(false);
            panelMemSlot5.PerformLayout();
            panelMemSlot6.ResumeLayout(false);
            panelMemSlot6.PerformLayout();
            panelMemSlot7.ResumeLayout(false);
            panelMemSlot7.PerformLayout();
            panelMemSlot8.ResumeLayout(false);
            panelMemSlot8.PerformLayout();
            panelMemSlot9.ResumeLayout(false);
            panelMemSlot9.PerformLayout();
            panelMemSlot10.ResumeLayout(false);
            panelMemSlot10.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownPausaProceso).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox listBoxDirecInicial;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownMemoria;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Panel panel2;
        private System.Windows.Forms.Timer timer3;
        private Panel panelMemSlot1;
        private Panel panelMemSlot2;
        private Panel panelMemSlot3;
        private Panel panelMemSlot4;
        private Panel panelMemSlot5;
        private Panel panelMemSlot6;
        private Panel panel10;
        private Panel panelMemSlot7;
        private Panel panel12;
        private Panel panelMemSlot8;
        private Panel panel14;
        private Panel panelMemSlot9;
        private Panel panel16;
        private Panel panelMemSlot10;
        private Panel panel18;
        private Label labelProcesNom1;
        private Label labelProcesNom2;
        private Label labelProcesNom3;
        private Label labelProcesNom4;
        private Label labelProcesNom5;
        private Label labelProcesNom6;
        private Label labelProcesNom7;
        private Label labelProcesNom8;
        private Label labelProcesNom9;
        private Label labelProcesNom10;
        private Panel panel3;
        private Label label3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label20;
        private Button buttonRenaudarTodo;
        private Button buttonRenaudarProceso;
        private Label label19;
        private Panel panel4;
        private Label label21;
        private Panel panel5;
        private Label label22;
        private Panel panel6;
        private Label label23;
        private Label label24;
        private NumericUpDown numericUpDownPausaProceso;
        private Panel panel7;
        private Label label25;
        private Label label26;
    }
}
