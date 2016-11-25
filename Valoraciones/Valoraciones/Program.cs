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
            MisArrays miArray = new MisArrays();
            libro.Idioma = IdiomaLibro.ES;

            // Métodos
            miArray.ArrayTrabajando();

            //SpeechSynthesizer hablar = new SpeechSynthesizer();
            Vector3D miVector;
            miVector.x = 10;
            miVector.y = 20;
            miVector.z = 30.30f;

            // Asignar valoraciones
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            //hablar.Speak("Este es el promedio de las valoraciones");
            CalcularValoraciones publicar = libro.PublicarValoraciones();
            Console.WriteLine("El promedio de las valoraciones es: {0:F2}", publicar.PromedioValoraciones);
            Console.WriteLine("La valoración máxima es: {0}", publicar.ValoracionMax);
            Console.WriteLine("La valoración mínima es: {0}", publicar.ValoracionMin);
            //Console.Beep();
            Console.ReadLine();
            // valoracionMinima
            // valoracionMaxima
            // promedioValoraciones

        }
    }
}
