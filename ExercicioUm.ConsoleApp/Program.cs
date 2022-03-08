using System;

namespace ExercicioUm.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new();
            Console.WriteLine("Informe o comprimento do retângulo: \n> ");
            retangulo.comprimento = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a largua do retângulo: \n> ");
            retangulo.largura = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do retângulo: \n> ");
            retangulo.altura = decimal.Parse(Console.ReadLine());
            retangulo.volume = retangulo.CalcularVolume(retangulo.comprimento, retangulo.largura, retangulo.altura);

            Console.WriteLine("Volume do retangulo: " + retangulo.volume.ToString("#.##") + ".");
            Console.ReadKey();
        }
    }
}