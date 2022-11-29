using System;

namespace Exercicio.Dois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint continuar = 1;
            var planoCartesiano = new PlanoCartesiano();

            do
            {
                try
                {

                    Console.WriteLine("Informe um valor inteiro positivo para a coordenada inicial X:");
                    var coordenadaInicialX = uint.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine("Informe um valor inteiro positivo para a coordenada inicial Y:");
                    var coordenadaInicialY = uint.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine("Informe um valor inteiro positivo para a coordenada final X:");
                    var coordenadaFinalX = uint.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine("Informe um valor inteiro positivo para a coordenada final Y:");
                    var coordenadaFinalY = uint.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine($"Dada as informações iniciais o resultado do deslocamento será: " +
                        $"{planoCartesiano.IsValidoDeslocarBot(coordenadaInicialX, coordenadaInicialY, coordenadaFinalX, coordenadaFinalY)}");
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