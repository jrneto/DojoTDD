using NumerosRomanos.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.Test
{
    [TestFixture]
    public class ConversorDeNumeroRomanoTest
    {
        [Test]
        public void DeveEntenderOSimboloI()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderOSimboloV()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }

        [Test]
        public void DeveEntenderDoisSimbolosComoII()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("II");
            Assert.AreEqual(2, numero);
        }

        [Test]
        public void DeveEntenderQuatroSimbolosComoXXII()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXII");
            Assert.AreEqual(22, numero);
        }

        [Test]
        public void DeveEntenderQuatroSimbolosComoIX()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("IX");
            Assert.AreEqual(9, numero);
        }

        [Test]
        public void DeveEntenderNumerosComplexosComoXXIV()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXIV");
            Assert.AreEqual(24, numero);
        }
    }


}
