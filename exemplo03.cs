using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeirosPassosPoo
{
    internal class exemplo03
    {
        public static void Main(string[] args)
        {
            Sulamerica("Brasil");
            Sulamerica("Argentina");
            Sulamerica();
            Sulamerica("uruguai");
        }
        static void Sulamerica(string pais = "Equador")
        {
            Console.WriteLine(pais);
        }
    }
}
