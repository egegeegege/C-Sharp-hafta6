using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Overload (Aşırı yükleme)
            // Overload => bir methodun birden farklı şekilde çalışma durumudur.
            // aldığı parametre değişikliklerine göre farklılık gösterir. Gönderdiğimiz parametre durumuna göre uygun method çalışır. Overload method olabilmesi için method isminin aynı parametrelerinin farklı olması gerekir. Bu durum bize bir methodun farklı şekillerde işler yapmasını sağlar.
            Console.WriteLine("Tahsin");
            Console.WriteLine(10);
            Console.WriteLine(true);
            Console.WriteLine('A');

            Yaz("Değer");
            Yaz(10);
            Yaz(true);

        }

        static void Yaz(string deger)
        {
            Console.WriteLine(deger);
        }

        static void Yaz(int deger)
        {
            Console.WriteLine(deger);
        }

        static void Yaz(bool deger)
        {
            Console.WriteLine(deger);
        }
    }
}
