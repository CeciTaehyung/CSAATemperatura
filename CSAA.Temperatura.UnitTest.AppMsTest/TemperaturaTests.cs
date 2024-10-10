using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSAA.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CSAA.Temperatura.Tests
{
   
    [TestClass]
    public class ConvertidorTemperaturaTests
    {
        private Temperatura _convertidor;

        [TestInitialize]
        public void Setup()
        {
            _convertidor = new Temperatura();
        }

        [TestMethod]
        public void CelsiusAFahrenheit_Zero_ReturnsThirtyTwo()
        {
            double resultado = _convertidor.CelsiusAFahrenheit(0);
            Assert.AreEqual(32, resultado);
        }

        [TestMethod]
        public void CelsiusAFahrenheit_100_Returns212()
        {
            double resultado = _convertidor.CelsiusAFahrenheit(100);
            Assert.AreEqual(212, resultado);
        }

        [TestMethod]
        public void FahrenheitACelsius_32_ReturnsZero()
        {
            double resultado = _convertidor.FahrenheitACelsius(32);
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void FahrenheitACelsius_212_Returns100()
        {
            double resultado = _convertidor.FahrenheitACelsius(212);
            Assert.AreEqual(100, resultado);
        }
    }

}