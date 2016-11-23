using System;

namespace EdadLegal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre y pulse Enter");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escriba su edad y pulse Enter");
            int edad = Convert.ToInt32( Console.ReadLine() );

            if ( edad >= 18 )
            {
                Console.WriteLine("Tu nombre es {0} y legalmente eres mayor de edad.", nombre);
            }
            else
            {
                Console.WriteLine("Tu nombre es {0} y legalmente no eres mayor de edad.", nombre);
            }

        }
    }
}
