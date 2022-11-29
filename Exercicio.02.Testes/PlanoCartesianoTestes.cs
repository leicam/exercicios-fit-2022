using Exercicio.Dois;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicio._02.Testes
{
    [TestClass]
    public class PlanoCartesianoTestes
    {
        private const string _criador = "Juliano Maciel";
        private const string _categoria = "Plano Carteziano";

        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void IsValidoDeslocarBot_EsperadoVerdadeiro()
        {
            var resultado = new PlanoCartesiano().IsValidoDeslocarBot(1, 1, 5, 2);
            Assert.IsTrue(resultado);
        }
    }
}