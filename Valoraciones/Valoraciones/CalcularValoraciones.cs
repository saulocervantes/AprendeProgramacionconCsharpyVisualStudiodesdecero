using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public class CalcularValoraciones
    {
        public float ValoracionMax;
        public float ValoracionMin;
        public float PromedioValoraciones;

        public CalcularValoraciones()
        {
            ValoracionMin = float.MaxValue;
        }
    }
}
