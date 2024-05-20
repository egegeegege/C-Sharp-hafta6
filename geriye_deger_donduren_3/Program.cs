using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_donduren_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yaz("Adınızı yazınız");
            string ad = Oku();

            Yaz(ad);

            Oku();
        }


        static string Oku()
        {   
            return Console.ReadLine();
        }

        static void Yaz(string deger)
        {
           Console.WriteLine(deger);
        }
    }
}
