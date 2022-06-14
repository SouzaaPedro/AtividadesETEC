using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36985_Lista01_Ex05
{
    class C36985_Lista01_Ex05
    {
        static void Main(string[] args)
        {
            double diametro, raio, volume;
            Console.WriteLine("Informe o diâmetro: ");
            diametro = double.Parse(Console.ReadLine());
            raio = diametro / 2;
            volume = (4 * Math.PI * Math.Pow(raio, 3)) / 3;
            Console.WriteLine("O volume é: "+volume.ToString());
            Console.ReadKey();
        }
    }
}
