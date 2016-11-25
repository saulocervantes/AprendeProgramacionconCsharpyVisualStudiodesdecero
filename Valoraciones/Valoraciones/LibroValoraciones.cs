using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public enum IdiomaLibro
    {
        none, EN, ES, GE, IT
    }

    public class LibroValoraciones
    {
        
        public string Nombre;
        public IdiomaLibro Idioma;
        List<float> valoraciones;

        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }

        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }

        public CalcularValoraciones PublicarValoraciones()
        {
            float sumaValoraciones = 0;
            CalcularValoraciones calculo = new CalcularValoraciones();

            foreach (var valoracion in valoraciones)
            {
                calculo.ValoracionMin = Math.Min(valoracion, calculo.ValoracionMin);
                calculo.ValoracionMax = Math.Max(valoracion, calculo.ValoracionMax);
                sumaValoraciones += valoracion;
            }

            calculo.PromedioValoraciones = sumaValoraciones / valoraciones.Count;

            return calculo;
        }

    }
}