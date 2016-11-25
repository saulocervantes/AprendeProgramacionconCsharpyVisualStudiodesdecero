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
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            CalcularValoraciones resultado = libro.PublicarValoraciones();

            Assert.AreEqual(5,resultado.ValoracionMax);
        }

        [TestMethod]
        public void CalcularValoracionMin()
        {
            LibroValoraciones libro = new LibroValoraciones();

            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            CalcularValoraciones resultado = libro.PublicarValoraciones();

            Assert.AreEqual(0.5,resultado.ValoracionMin);
        }

        [TestMethod]
        public void CalcularValoracionPromedio()
        {
            LibroValoraciones libro = new LibroValoraciones();

            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            CalcularValoraciones resultado = libro.PublicarValoraciones();

            Assert.AreEqual(2.83333,resultado.PromedioValoraciones, 0.01);
        }
        
    }
}
