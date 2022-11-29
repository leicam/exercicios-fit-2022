using System;

namespace Exercicio.Um
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint continuar = 1;

            do
            {
                try
                {
                    Console.WriteLine("Informe um valor inteiro positivo para verificação de número primo:");
                    Console.WriteLine(Fatorar.VerificarNumeroPrimo(uint.Parse(Console.ReadLine())));
                    Console.WriteLine("\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\n");
                }
                finally
                {
                    Console.WriteLine("Digite 1 caso deseje continuar: ");
                    uint.TryParse(Console.ReadLine(), out continuar);
                    Console.WriteLine("\n");
                }
            } while (continuar == 1);
        }
    }
}