using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeirosPassosPoo
{
    internal class Media
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("digite a quantidade de avaliações feitas para compor a nota:");
            int avaliacoes = Convert.ToInt32(Console.ReadLine());
            MediaFuncition(avaliacoes);
        }
        static void MediaFuncition(int n)
        {
            double[] notas = new double[n];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"digite a {i + 1}° nota:");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"a média é {notas.Average()}");
        }
    }
}
