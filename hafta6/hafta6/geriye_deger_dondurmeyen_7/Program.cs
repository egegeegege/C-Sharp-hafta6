using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_dondurmeyen_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Default parametre (Varsayılan argüman)

            DefaultParam();

            Console.ReadLine();
        }

        static void DefaultParam(int s = 0)  // s eğer parametre gelmiyorsa 0 geliyorsa gelen parametre değerini alacak
        {
            Console.WriteLine(s);
        }
    }
}
