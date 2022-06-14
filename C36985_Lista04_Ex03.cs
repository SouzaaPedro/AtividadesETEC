using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista04_Ex03
{
    internal class C36985_Lista04_Ex03
    {
        static void Main(string[] args)
        {
            int valor = 0, soma = 0;
            do
            {
                Console.Write("Digite número de 1 a 100: ");
                valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            } while (soma > 0 && soma < 100);
            Console.WriteLine("A soma é: " + soma);
            Console.ReadKey();
        }
    }
}
