using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_dondurmeyen_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // istediğimiz oranda fiyata kdv uygulayan methodu yazın.
            Console.WriteLine("Fiyat giriniz");
            int fiyat = int.Parse(Console.ReadLine());
            Console.WriteLine("KDV oranı giriniz");
            double kdvOrani = double.Parse(Console.ReadLine());

            KdvUygula(kdvOrani,fiyat);

            Console.ReadLine();

        }

        static void KdvUygula(double kdvOrani,int fiyat)
        {
            double sonFiyat = fiyat + (fiyat * (kdvOrani / 100));

            Console.WriteLine(sonFiyat);
        }
    }
}
