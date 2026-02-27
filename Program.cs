using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal precoProduto = 500.00m;

            Console.WriteLine("Preço original do produto: R$ " + precoProduto);

            Calculadora calc = new Calculadora();

            precoProduto = calc.CalcularDesconto(precoProduto);

            Console.WriteLine("Valor com 10% de desconto: R$ " + precoProduto);

            Console.ReadKey();
        }
    }
}
