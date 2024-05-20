using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             Ödev: Kişi sayısının 4 olduğu bir kuyruk.
             Döngü her döndüğünde bana sıra gelmesi için önümde kaç eleman olduğunu söyleyecek. (Önünüzde 3 kişi vardır. Lütfen bekleyiniz.)
            // Sıra size geldiğinde sıra sizdedir diyecek. 
             */

            Queue kuyruk = new Queue();
            kuyruk.Enqueue("Ali");
            kuyruk.Enqueue("Elif");
            kuyruk.Enqueue("Kader");
            kuyruk.Enqueue("Tahsin");

            Random random = new Random();

            for (int i = kuyruk.Count; i >= kuyruk.Count; i--)
            {
                int beklemeSuresi = random.Next(1000,3000);
                Thread.Sleep(beklemeSuresi);
                if(i > 1)
                {
                    Console.WriteLine("Önünüzde {0} kişi vardır. Lütfen bekleyiniz", i - 1);
                }
                else
                {
                    Console.WriteLine("Sıra sizdedir bağlanabilirsiniz...");
                    break;
                }
                kuyruk.Dequeue();
            }

            Console.ReadLine();
        }
    }
}
