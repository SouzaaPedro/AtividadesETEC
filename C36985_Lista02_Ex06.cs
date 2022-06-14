using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista02_Ex06
{
    class C36985_Lista02_Ex06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do primeiro produto: R$");
            double produto1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo produto: R$");
            double produto2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro produto: R$");
            double produto3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do quarto produto: R$");
            double produto4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do quinto produto: R$");
            double produto5 = double.Parse(Console.ReadLine());

            double TotalProdutos = produto1 + produto2 + produto3 + produto4 + produto5;
            Console.WriteLine($"O valor total dos produtos foi R${TotalProdutos}");

            Console.WriteLine("Digite o valor pago pelos produtos: R$");
            double ValorPagamento = double.Parse(Console.ReadLine());

            double troco = ValorPagamento - TotalProdutos;

            Console.WriteLine("O troco é de R$" + troco.ToString("0.00"));
            Console.ReadKey();

    }
}
