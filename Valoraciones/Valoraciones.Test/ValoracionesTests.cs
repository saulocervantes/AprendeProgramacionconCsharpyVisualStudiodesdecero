using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test
{
    [TestClass]
    public class ValoracionesTests
    {
        [TestMethod]
        public void CalcularValoracionMax()
        {
            LibroValoraciones libro = new LibroValoraciones();

            libro.AgregarValoracion(5);
            CalcularValoraciones resultado = libro.PublicarValoraciones();

            Assert.AreEqual(5,resultado.valoracionMax);
        }
        
    }
}
