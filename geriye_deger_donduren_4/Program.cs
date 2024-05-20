using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_donduren_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan fiyat bilgisine göre devamlı olarak fiyatlara %18 kdv uygulayan yapıyı oluşturun.

            while (true)
            {
                try
                {
                    Console.WriteLine("Ürün fiyatını giriniz");
                    double fiyat = double.Parse(Console.ReadLine());
                    double sonFiyat = KdvHesapla(fiyat);

                    Console.WriteLine(sonFiyat);
                    Ayirac();
                }
                catch (Exception)
                {
                    Console.WriteLine("Hata oluştu");
                }
            }
            Console.ReadLine();

        }

        static double KdvHesapla(double f)
        {
            return f * 1.18;
        }

        static void Ayirac()
        {
            Console.WriteLine("*************************");
        }
    }
}
