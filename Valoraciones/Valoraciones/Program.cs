using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el objeto libro
            LibroValoraciones libro = new LibroValoraciones();
            SpeechSynthesizer hablar = new SpeechSynthesizer();

            // Asignar valoraciones
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            hablar.Speak("Este es el promedio de las valoraciones");
            CalcularValoraciones publicar = libro.PublicarValoraciones();
            Console.WriteLine("El promedio de las valoraciones es: {0:F2}", publicar.promedioValoraciones);
            Console.WriteLine("La valoración máxima es: {0}", publicar.valoracionMax);
            Console.WriteLine("La valoración mínima es: {0}", publicar.valoracionMin);
            Console.Beep();
            Console.ReadLine();
            // valoracionMinima
            // valoracionMaxima
            // promedioValoraciones

        }
    }
}
