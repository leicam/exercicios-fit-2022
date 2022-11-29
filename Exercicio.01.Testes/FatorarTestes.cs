using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicio.Um
{
    [TestClass]
    public class FatorarTestes
    {
        private const string _criador = "Juliano Maciel";
        private const string _categoria = "Fatoração";

        [DataRow(2)]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(7)]
        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]        
        public void VerificarNumeroPrimo_EsperadoNumeroPrimoVerdadeiro(int valor)
        {
            var resultado = Fatorar.VerificarNumeroPrimo(uint.Parse(valor.ToString()));

            Assert.IsTrue(resultado.Contains($"O número {valor} é primo."));
        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(8)]
        [DataRow(9)]
        [DataRow(10)]
        [TestMethod]
        [Owner(_criador)]
        [TestCategory(_categoria)]
        public void VerificarNumeroPrimo_EsperadoNumeroPrimoFalso(int valor)
        {
            var resultado = Fatorar.VerificarNumeroPrimo(uint.Parse(valor.ToString()));

            Assert.IsTrue(resultado.Contains($"O número {valor} não é primo."));
        }
    }
}