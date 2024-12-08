using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simulafdor_de_Memoria_RAM
{
    public partial class Form1 : Form
    {
        private bool PausaGen = false;
        private bool PausaPros = false;
        // Declaramos la variable que almacenará el valor del updownMemoria
        private decimal valorVariable;
        public Form1()
        {

            InitializeComponent();
            // Inicializamos el valor de la variable
            valorVariable = numericUpDownMemoria.Value;
            // Suscribimos al evento ValueChanged del NumericUpDown
            numericUpDownMemoria.ValueChanged += NumericUpDownMemoria_ValueChanged;
            // Establecer el valor mínimo, máximo e inicial
            numericUpDownMemoria.Minimum = 10;  // Valor mínimo
            numericUpDownMemoria.Maximum = 200; // Valor máximo
            numericUpDownMemoria.Value = 30;   // Valor inicial (dentro del rango)

            // Limitar los valores a incrementos específicos:
            numericUpDownMemoria.Increment = 10;  // Incremento de 5 unidades

            // Configuración del evento de cambio de valor
            numericUpDownMemoria.ValueChanged += NumericUpDownMemoria_ValueChanged;
            valorVariable = numericUpDownMemoria.Value;

            numericUpDownPausaProceso.Minimum = 0;
            numericUpDownPausaProceso.Maximum = 9;

            // Configuración del Timer
            timer1.Interval = 3000; // 1 segundos
            timer1.Enabled = true;
            timer2.Interval = 1000;
            timer2.Enabled = true;
            timer3.Interval = 1000;
            timer3.Enabled = true;

            // Llamar al método lemo() cuando el formulario se haya cargado
            this.Load += (sender, e) =>
            {
                lemo();
            };
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limite de la lista
            int maxlimit = 15;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMemoriaRAM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Método para obtener el valor de numericUpDownMemoria
        public decimal ObtenerValorUpDown()
        {
            return numericUpDownMemoria.Value;
        }

        // Método para establecer el valor de numericUpDownMemoria
        public void EstablecerValorUpDown(decimal valor)
        {
            numericUpDownMemoria.Value = valor;
        }
        private void numericUpDownMemoria_ValueChanged(object sender, EventArgs e)
        {
            // Asegurar que el valor inicial esté dentro del rango permitido
            if (numericUpDownMemoria.Value < numericUpDownMemoria.Minimum)
            {
                numericUpDownMemoria.Value = numericUpDownMemoria.Minimum;
            }
            else if (numericUpDownMemoria.Value > numericUpDownMemoria.Maximum)
            {
                numericUpDownMemoria.Value = numericUpDownMemoria.Maximum;
            }
        }
        // Evento que se dispara cuando el valor cambia
        private void NumericUpDownMemoria_ValueChanged(object sender, EventArgs e)
        {
            // Actualizamos el valor de la variable en tiempo real
            valorVariable = numericUpDownMemoria.Value;
        }

        public async void MoverARAM(string proceso, int indice)
        {

            Color Activo = Color.FromArgb(255, 128, 128);
            switch (indice)
            {
                case 0:
                    panelMemSlot1.BackColor = Activo;
                    labelProcesNom1.Text = proceso;
                    break;
                case 1:
                    panelMemSlot2.BackColor = Activo;
                    labelProcesNom2.Text = proceso;
                    break;
                case 2:
                    panelMemSlot3.BackColor = Activo;
                    labelProcesNom3.Text = proceso;
                    break;
                case 3:
                    panelMemSlot4.BackColor = Activo;
                    labelProcesNom4.Text = proceso;
                    break;
                case 4:
                    panelMemSlot5.BackColor = Activo;
                    labelProcesNom5.Text = proceso;
                    break;
                case 5:
                    panelMemSlot6.BackColor = Activo;
                    labelProcesNom6.Text = proceso;
                    break;
                case 6:
                    panelMemSlot7.BackColor = Activo;
                    labelProcesNom7.Text = proceso;
                    break;
                case 7:
                    panelMemSlot8.BackColor = Activo;
                    labelProcesNom8.Text = proceso;
                    break;
                case 8:
                    panelMemSlot9.BackColor = Activo;
                    labelProcesNom9.Text = proceso;
                    break;
                case 9:
                    panelMemSlot10.BackColor = Activo;
                    labelProcesNom10.Text = proceso;
                    break;
                default:
                    break;
            }
            // Después de mover a RAM, eliminar el primer elemento de listBoxDirecInicial
            if (listBoxDirecInicial.Items.Count > 0)
            {
                listBoxDirecInicial.Items.RemoveAt(0);  // Elimina el primer proceso
            }
        }
        //crear un nuevo processo en direccion inicial
        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (listBoxDirecInicial.Items.Count < 10)
            {
                timer1.Start();
            }

        }
        // Método para obtener un color aleatorio
        private Color GetRandomColor()
        {
            // Genera colores aleatorios usando componentes RGB
            Random rand = new Random();
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        // Definir el evento
        public event Action<ListBox> ListBoxActualizado;

        public void ActualizarListBoxDirecInicial()
        {
            // Llamar al evento
            ListBoxActualizado?.Invoke(listBoxDirecInicial);
        }

        //Agregar elementos a la lista de acuerdo a sus limites
        public int AgregarElementoLista(ListBox listBox, string elemento, int limite)
        {
            int band = 0;
            // Verificar si el número de elementos en el ListBox es menor que el límite
            if (listBox.Items.Count < limite)
            {
                // Agregar el nuevo elemento si no se ha alcanzado el límite
                listBox.Items.Add(elemento);
                return band = 0;
            }
            else
            {
                return band = 1;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private async void timer1_Tick(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            GeneradorProcesos genepros = new GeneradorProcesos();
            // Generar un proceso y agregarlo si no se ha alcanzado el límite
            string Proceso;
            int chk;
            // Crear un nuevo intervalo aleatorio
            int random = aleatorio.Next(5000, 6000);
            await Task.Delay(random); // Establecer el nuevo intervalo aleatorio
            Proceso = genepros.ProcesoCrea();
            chk = AgregarElementoLista(listBoxDirecInicial, Proceso, 15);
            if (chk == 1)
            {
                // Esperar 10 segundos
                await Task.Delay(20000); // 20000 ms = 20 segundos
            }
        }


        public string ObtenerElementoListBoxDirIni(int indice)
        {
            if (indice >= 0 && indice < listBoxDirecInicial.Items.Count)
            {
                return listBoxDirecInicial.Items[indice].ToString();
            }
            return null;
        }

        // Método para cambiar el color del panel
        public void CambiarColorPanelRand()
        {
            // Cambiar el color a un color aleatorio
            Random rand = new Random();
            Color nuevoColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)); // Color aleatorio
            panel2.BackColor = nuevoColor;
        }
        // Método para cambiar el color del panel
        public void CambiarColorPanelRand1()
        {
            // Cambiar el color a un color aleatorio
            Random rand = new Random();
            Color nuevoColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)); // Color aleatorio
            panel3.BackColor = nuevoColor;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            CambiarColorPanelRand();
            ActualizarTiempoProcesos();
            contador();
        }
        public void lemo()
        {
            llenarMatriz();
        }
        public void contador()
        {
            if (ObtenerElementoListBoxDirIni(0) != null)
            {
                TransformarInfo(1);
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // Matriz dinámica de 2 dimensiones
        public List<List<int>> matriz = new List<List<int>>();


        // Método para llenar la matriz (igual que en el código original)
        public void llenarMatriz()
        {
            for (int i = 0; i < 10; i++)
            {
                matriz.Add(new List<int> { 00, 00, 00 });
            }
        }

        // Método público para obtener la matriz
        public List<List<int>> ObtenerMatriz()
        {
            return matriz;
        }

        // Método para modificar la matriz (si es necesario)
        public void ModificarMatriz(int fila, int col, int valor)
        {
            if (fila < matriz.Count && col < matriz[fila].Count)
            {
                matriz[fila][col] = valor;
            }
        }

        public async void EliminarProceso()
        {
            decimal valorMemoria = numericUpDownMemoria.Value;
            int limiteUpDown = (int)Math.Round(valorMemoria) / 10;
            string valorLib = limiteUpDown.ToString();
            Color desactivo = Color.FromArgb(192, 255, 255);
            // Recorrer todas las filas de la matriz
            for (int i = 0; i < matriz.Count; i++)
            {
                // Comprobar si el tiempo (tercer elemento de la lista) es cero
                if (matriz[i][2] == 0)
                {
                    // Si el tiempo es cero, poner la fila a ceros
                    matriz[i] = new List<int> { 0, 0, 0 };
                    switch (i)
                    {
                        case 0:
                            panelMemSlot1.BackColor = desactivo;
                            labelProcesNom1.Text = " " + valorLib + "kb";
                            break;
                        case 1:
                            panelMemSlot2.BackColor = desactivo;
                            labelProcesNom2.Text = " " + valorLib + "kb";
                            break;
                        case 2:
                            panelMemSlot3.BackColor = desactivo;
                            labelProcesNom3.Text = " " + valorLib + "kb";
                            break;
                        case 3:
                            panelMemSlot4.BackColor = desactivo;
                            labelProcesNom4.Text = " " + valorLib + "kb";
                            break;
                        case 4:
                            panelMemSlot5.BackColor = desactivo;
                            labelProcesNom5.Text = " " + valorLib + "kb";
                            break;
                        case 5:
                            panelMemSlot6.BackColor = desactivo;
                            labelProcesNom6.Text = " " + valorLib + "kb";
                            break;
                        case 6:
                            panelMemSlot7.BackColor = desactivo;
                            labelProcesNom7.Text = " " + valorLib + "kb";
                            break;
                        case 7:
                            panelMemSlot8.BackColor = desactivo;
                            labelProcesNom8.Text = " " + valorLib + "kb";
                            break;
                        case 8:
                            panelMemSlot9.BackColor = desactivo;
                            labelProcesNom9.Text = " " + valorLib + "kb";
                            break;
                        case 9:
                            panelMemSlot10.BackColor = desactivo;
                            labelProcesNom10.Text = " " + valorLib + "kb";
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public string RegresarInfo(int nom, int pes, int tiem)
        {
            string x = nom.ToString(), y = pes.ToString(), z = tiem.ToString();
            string p = "p", kb = "kb", secs = "secs";
            string proceso = "       " + p + x + "                  " + y + kb + "          " + z + secs;
            return proceso;
        }

        public async void TransformarInfo(int metodo)
        {

            string procesostr = ObtenerElementoListBoxDirIni(0);
            string[] partes = procesostr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // Extraer y convertir los números
            int nombre = int.Parse(partes[0].Substring(1)); // Suponiendo que partes[0] tiene al menos dos caracteres
            int peso = int.Parse(partes[1].Substring(0, partes[1].Length - 2)); // Asegúrate de que tiene al menos dos caracteres antes de "kb"
            int tiempo = int.Parse(partes[2].Substring(0, partes[2].Length - 4)); // Eliminar 'sec'
            switch (metodo)
            {
                case 1:
                    OrganizarPrimerAjuste(nombre, peso, tiempo);
                    break;
            }
        }
        // Método que obtiene el valor actual de numericUpDownMemoria
        public decimal ObtenerValorNumericUpDown()
        {
            return numericUpDownMemoria.Value;  // Retorna el valor del control NumericUpDown
        }

        // Método que establece un valor en numericUpDownMemoria
        public void EstablecerValorNumericUpDown(decimal nuevoValor)
        {
            numericUpDownMemoria.Value = nuevoValor;  // Establece un nuevo valor al NumericUpDown
        }
        private void ActualizarTiempoProcesos()
        {
            // Acceder a la matriz desde la clase Program
            List<List<int>> matriz = ObtenerMatriz();
            for (int i = 0; i < matriz.Count; i++)
            {
                if (i < procesosCongelados.Count && procesosCongelados[i] < 0)
                {
                    if (matriz[i][0] == procesosCongelados[i])
                    {
                        continue;
                    }
                }
                if (matriz[i][2] > 0)
                {
                    matriz[i][2] -= 1;
                }
                if (matriz[i][2] == 0)
                {
                    EliminarProceso();
                }
            }

        }

        //Primer Ajuste
        //{
        public async void OrganizarPrimerAjuste(int nom, int pes, int tiem)
        {
            decimal valorMemoria = numericUpDownMemoria.Value;
            int limiteUpDown = (int)Math.Round(valorMemoria);
            int valorperpanel = (1 * limiteUpDown) / 10;

            bool poneren = false;
            while (!poneren)
            {
                for (int i = 0; i < matriz.Count; i++)
                {
                    // ver si hay un panel libre
                    if (matriz[i][1] == 0)
                    {
                        // Calcular el espacio disponible en eses panel
                        int espdispo = valorperpanel;

                        // ver si el espacio que queda cabe en el panel
                        if (pes <= espdispo)
                        {
                            // poner espacio en panel
                            CambiarColorPanelRand1();
                            matriz[i] = new List<int> { nom, pes, tiem };
                            MoverARAM(RegresarInfo(nom, pes, tiem), i);
                            poneren = true;
                            break; // Salir del loop si se coloco en panel
                        }
                        else if (pes > espdispo)
                        {
                            // poner espacio parcial en panel
                            CambiarColorPanelRand1();
                            matriz[i] = new List<int> { nom, espdispo, tiem };
                            MoverARAM(RegresarInfo(nom, espdispo, tiem), i);
                            pes -= espdispo;
                        }
                    }
                }
                // If still not allocated, wait for a short time and try again
                if (!poneren)
                {
                    await Task.Delay(1000); // Adjust delay as needed
                }
            }
        }

        private void labelProcesNom3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPausar_Click(object sender, EventArgs e)
        {
            if (PausaGen)
            {
                // Si está pausado, reanudamos el temporizador
                timer1.Start();
                timer2.Start();
                buttonRenaudarTodo.Text = "}";
                buttonRenaudarTodo.BackColor = Color.FromArgb(128, 255, 128);
            }
            else
            {
                // Si no está pausado, lo detenemos
                timer1.Stop();
                timer2.Stop();
                buttonRenaudarTodo.Text = "J";
                buttonRenaudarTodo.BackColor = Color.FromArgb(255, 128, 128);
            }

            // Cambiamos el estado de pausa
            PausaGen = !PausaGen;
        }
        // Esta lista guardará los nombres (nom) de los procesos que están congelados
        List<int> procesosCongelados = new List<int>();
        private void buttonRenaudarProceso_Click(object sender, EventArgs e)
        {
            decimal legume = ObtenerValorUpDownPausPros();
            int bean = (int)legume, idk = matriz[bean][0];
            if (PausaPros)
            {
                // Si está pausado, reanudamos el temporizador
                buttonRenaudarProceso.Text = "}";
                buttonRenaudarProceso.BackColor = Color.FromArgb(128, 255, 128);
                for (int i = 0; i < matriz.Count; i++)
                {
                    if (matriz[i][0] == idk)
                    {
                        procesosCongelados.Remove(idk);
                    }
                }
            }
            else
            {
                // Si no está pausado, lo detenemos
                buttonRenaudarProceso.Text = "J";
                buttonRenaudarProceso.BackColor = Color.FromArgb(255, 128, 128);
                for (int i = 0; i < matriz.Count; i++)
                {
                    if (matriz[i][0] == idk)
                    {
                        procesosCongelados.Add(idk);
                    }
                }
            }

            // Cambiamos el estado de pausa
            PausaPros = !PausaPros;
        }

        private void buttonPausarProceso_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDownPausaProceso_ValueChanged(object sender, EventArgs e)
        {

        }

        // Método para obtener el valor de numericUpDownMemoria
        public decimal ObtenerValorUpDownPausPros()
        {
            return numericUpDownPausaProceso.Value;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        //}
    }
}