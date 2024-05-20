using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_dondurmeyen_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı adını alacağımız bir method yazın.
            KullaniciAdi();

            string kad = Console.ReadLine();

            Console.WriteLine(kad);

            Console.ReadLine();
        }

        static void KullaniciAdi()
        {
            Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
        }
    }
}
