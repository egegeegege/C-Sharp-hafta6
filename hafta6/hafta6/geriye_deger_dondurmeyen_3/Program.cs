using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_dondurmeyen_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sayının tek mi çift mi olduğunu hesaplayan methodu yazın.
            // Parametre (Argüman) => methodun aldığı değer yada değerler.
            Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            TekmiCiftmi(sayi);

            Console.ReadLine();
        }

        static void TekmiCiftmi(int number) // bu method 1 adet int parametre alacak.
        {
            if(number % 2 == 0)
            {
                Console.WriteLine("Çifttir");
            }
            else
            {
                Console.WriteLine("Tektir");
            }
        }
    }
}
