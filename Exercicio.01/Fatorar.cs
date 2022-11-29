namespace Exercicio.Um
{
    public static class Fatorar
    {

        public static string VerificarNumeroPrimo(uint valor)
        {
            var contador = 0;
            var isPrimo = true;
            var mensagem = string.Empty;

            if (valor <= 1)
                return $"O número {valor} não é primo." +
                    $" Número de iterações necessárias: {0}";

            for (var i = 1; i <= valor; i++)
            {
                if (valor % i == 0)
                    contador++;

                if (contador >= 3)
                {
                   mensagem = $"O número {valor} não é primo." +
                        $" Número de iterações necessárias: {i}";
                    isPrimo = false;
                    break;
                }
            }

            if (isPrimo)
                mensagem = $"O número {valor} é primo." +
                    $" Número de iterações necessárias: {valor}";

            return mensagem;
        }
    }
}