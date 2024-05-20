using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ödev
             * Üç elemanlı bir arrayList oluşturun ve yeni bir arrayListe yapıştırın.
             * Yeni oluşan arrayList i gösterin.
             * Yeni oluşan arrayList 3 eleman daha ekleyerek yeni arrayListin eleman sayısını gösterin.
             * Yeni arrayListi index numarasına göre terse çevirerek gösterin.
             */

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            ArrayList copyList = new ArrayList();

            foreach (var item in list)
            {
                copyList.Add(item);
            }

            foreach (var item in copyList)
            {
                Console.WriteLine(item);
            }

            copyList.Add(4);
            copyList.Add(5);
            copyList.Add(6);

            Console.WriteLine("Yeni arrayList eleman sayısı: {0}",copyList.Count);

            copyList.Reverse();

            foreach (var item in copyList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
