using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulafdor_de_Memoria_RAM
{
    internal class GeneradorProcesos
    {
        // Crear una instancia de la clase Random
        Random aleatorio;

        // Generar un número aleatorio
        int numeroAleatorio;

        // Constructor de la clase
        public string ProcesoCrea()
        {
            Random aleatorio = new Random();
            int name = aleatorio.Next(1, 99), weight = aleatorio.Next(5, 10), time = aleatorio.Next(5, 50);
            string x = name.ToString(), y = weight.ToString(), z = time.ToString();
            string p = "p", kb = "kb", secs = "secs";
            string proceso = "       " + p + x + "                  " + y + kb + "          " + z + secs;
            return proceso;
        }
    }
}
