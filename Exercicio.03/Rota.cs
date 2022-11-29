namespace Exercicio.Tres
{
    internal class Rota
    {
        public string CidadeOrigem { get; private set; }
        public string CidadeDestino { get; private set; }
        public int Tempo { get; private set; }

        public Rota(string cidadeOrigem, string cidadeDestino, int tempo)
        {
            CidadeOrigem = cidadeOrigem;
            CidadeDestino = cidadeDestino;
            Tempo = tempo;
        }
    }
}