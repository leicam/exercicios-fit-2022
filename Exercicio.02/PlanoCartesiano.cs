namespace Exercicio.Dois
{
    /// <summary>
    /// Aplicado conceito do Algoritmo de Euclides
    /// </summary>
    public class PlanoCartesiano
    {
        public bool IsValidoDeslocarBot(uint inicialX, uint inicialY, uint finalX, uint finalY)
            => ObterMaximoDivisorComum(inicialX, inicialY) == ObterMaximoDivisorComum(finalX, finalY);

        private uint ObterMaximoDivisorComum(uint i, uint j)
        {
            if (i == j)
                return i;

            return i > j ? ObterMaximoDivisorComum(i - j, j) : ObterMaximoDivisorComum(i, j - i);
        }
    }
}