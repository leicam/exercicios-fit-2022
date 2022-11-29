using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercicio.Tres.Testes
{
    [TestClass]
    public class GPSTestes
    {
        private const string _criador = "Juliano Maciel";
        private const string _categoria = "GPS";

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void GpsFitSolution_EsperadoSucesso()
        {
            var resultadoEsperado = new List<int>() { 3, 1, 2 };
            var resultadoAtual = new GPS().GpsFitSolution(@"..\net5.0\Resources\EntradaGPS.txt");

            for(var i = 0; i < 3; i++)
                Assert.AreEqual(resultadoEsperado[i], resultadoAtual[i]);
        }
    }
}