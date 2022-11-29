using System;

namespace Exercicio.Tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var gps = new GPS();

                foreach (var tempo in gps.GpsFitSolution(@"..\net5.0\Resources\EntradaGPS.txt"))
                    Console.WriteLine(tempo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}