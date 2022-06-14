using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista03_Ex06
{
    class C36985_Lista03_Ex06
    {
        static void Main(string[] args)
        {
            double peso = 0, altura = 0, RelacaoPesoAltura = 0;
            try
            {
                Console.Write("Digite o peso da pessoa(Kg): ");
                peso = double.Parse(Console.ReadLine());
                Console.Write("Digite a altura da pessoa (metros): ");
                altura = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite apenas números inteiros e/ou decimais.");
                Console.ReadKey();
                return;
            }
            RelacaoPesoAltura = peso / Math.Pow(altura, 2);
            if (RelacaoPesoAltura < 20)
            {
                Console.WriteLine("A pessoa está abaixo do peso.");
            }
            else if (RelacaoPesoAltura >= 20 && RelacaoPesoAltura < 25)
            {
                Console.WriteLine("A pessoa está no peso ideal.");
            }
            else
            {
                Console.WriteLine("A pessoa está acima do peso.");
            }
            Console.ReadKey();
        }
    }
}
