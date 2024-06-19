using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeirosPassosPoo
{
    internal class SistemaNota
    {
        public static void Main(string[] args)
        {
            int escolha, avaliacoes;
            bool proseguir;
            
            do {
                Console.WriteLine("você irá usar 1 - média áritimética ou 2 - Média Ponderada");
                escolha = Convert.ToInt32(Console.ReadLine());
                proseguir = escolha == 1 || escolha == 2 ? true : false;

            } while (!proseguir);
            Console.WriteLine("digite a quantidade de avaliações feitas para compor a nota:");
            avaliacoes = Convert.ToInt32(Console.ReadLine());
            switch (escolha) {
                case 1:
                    MediaAritimetica(avaliacoes);
                    break;
                case 2:
                    MediaPonderada(avaliacoes);
                    break;
                default:
                    Console.WriteLine("ERRO!");
                    break;
            
            }


         
        }
        static void MediaAritimetica(int n)
        {
            double[] notas = new double[n];
            double mediaFinal;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"digite a {i + 1}° nota:");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            mediaFinal = notas.Average();
            Console.WriteLine($"a média é {Math.Round(mediaFinal, 2)}");
        }
        static void MediaPonderada(int n)
        {
            double[] pesos = new double[n];
            double[] notas = new double[n];
            double acumulador = 0;
            double mediaFinal;
            for (int i = 0; i < pesos.Length; i++)
            {
                Console.WriteLine($"digite o peso da {i + 1}° nota:");
                pesos[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < notas.Length; i++)
            {

                Console.WriteLine($"digite a {i + 1}° nota:");
                notas[i] = Convert.ToDouble(Console.ReadLine()) * pesos[i];
                
                 acumulador += notas[i];
            }
            mediaFinal = acumulador / pesos.Sum();
            Console.WriteLine($"a média é {Math.Round(mediaFinal, 2)}");
        }
    }
}
