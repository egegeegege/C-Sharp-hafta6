using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_dondurmeyen_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = new string[] { "Ayşe", "Fatma", "Sevgi" };
            DiziGoster(dizi,false);

            Console.ReadLine();
        }

        static void DiziGoster(Array a, bool b)
        {
            if(b == true)
            {
                foreach (var item in a)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Yetkiniz Yok!!");
            }
        }
    }
}
