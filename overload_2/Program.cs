using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toplam(10);
            Toplam(3.2);
            Toplam();

            Console.ReadLine();
        }

        static void Toplam(int parametre1)
        {
            Console.WriteLine("1. parametreli toplam: {0}",parametre1+10);
        }

        static void Toplam(double p)
        {
            Console.WriteLine("1. parametreli double toplam: {0}", p + 100);
        }
        static void Toplam()
        {
            Console.WriteLine("parametresiz toplam");
        }
    }
}
