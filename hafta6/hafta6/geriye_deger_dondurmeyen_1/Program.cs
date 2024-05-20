using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_dondurmeyen_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Geriye Değer Döndürmeyen Methodlar
            // kullandığımız keyword => void
            // void methodun geriye bir değer döndürmediğini sadece içinde bir işlem yapıldığını belirtir.

           Method();  // Çağırma işlemi

        }

        static void Method() // method isimlerini PascalCase olarak yapıyoruz.
        {
            Console.WriteLine("Hello Method!");
            Console.ReadLine();

        }

       
    }
}
