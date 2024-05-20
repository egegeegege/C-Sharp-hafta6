using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriye_deger_dondurmeyen_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sayının pozitif mi negatif mi olduğunu veren method
            Console.WriteLine("Sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            PozitifMiNegatifMi(sayi);
            Console.ReadLine();
        }

        static void PozitifMiNegatifMi(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else if(number<0)
            {
                Console.WriteLine("Negatif");
            }
            else
            {
                Console.WriteLine("Sıfırdır");
            }
        }
    }
}
