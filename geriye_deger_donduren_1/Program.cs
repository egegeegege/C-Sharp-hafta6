using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_donduren_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Geriye değer döndüren methodlar
            // Geriye değer döndüren methodlarda void yerine mutlaka geri dönüş için bir veri tipi gereklidir.
            // Mutlaka geriye değer döndüren methodlarda return anahtar kelimesini kullanmalıyız.
            int sayi = Hesapla1();

            Console.WriteLine(sayi);
            Console.WriteLine(Hesapla1());

            Console.WriteLine("1.sayıyı giriniz");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz");
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3.sayıyı giriniz");
            int s3 = int.Parse(Console.ReadLine());

            int sonuc = Hesapla2(s1, s2);

            Console.WriteLine(sonuc);

            Console.ReadLine();
        }

        static int Hesapla1() // geri dönüş tipi
        {
            return 15;  // return ilede geriye döndüreceğimiz değeri belirtiriz.
        }

        static int Hesapla2(int sayi1, int sayi2, int sayi3=0)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
    }
}
