using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroProjeto
{
    public class Calculadora
    {
        public decimal CalcularDesconto(decimal preco)
        {
            decimal desconto = preco * 0.10m;
            return preco - desconto;
        }
    }
}
