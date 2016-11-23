using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class LibroValoraciones
    {

        public List<float> valoraciones;

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
                calculo.valoracionMin = Math.Min(valoracion, calculo.valoracionMin);
                calculo.valoracionMax = Math.Max(valoracion, calculo.valoracionMax);
                sumaValoraciones += valoracion;
            }

            calculo.promedioValoraciones = sumaValoraciones / valoraciones.Count;

            return calculo;
        }

    }
}