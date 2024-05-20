using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_dondurmeyen_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schools = new List<string>();
            schools.Add("ODTÜ");
            schools.Add("İTÜ");
            schools.Add("BAU");

            OkulGoster(schools);

            Console.ReadLine();
        }

        static void OkulGoster(List<string> okullar)
        {
            foreach (var okul in okullar)
            {
                Console.WriteLine(okul);
            }
        }
    }
}
