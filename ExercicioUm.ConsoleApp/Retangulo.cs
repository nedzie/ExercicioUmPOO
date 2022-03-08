using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUm.ConsoleApp
{
    internal class Retangulo
    {
        public decimal comprimento;
        public decimal largura;
        public decimal altura;
        public decimal volume;

        public decimal CalcularVolume(decimal comprimento, decimal largura, decimal altura)
        {
            volume = altura * comprimento * largura;
            return volume;
        }
    }
}