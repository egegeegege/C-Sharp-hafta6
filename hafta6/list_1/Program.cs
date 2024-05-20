using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace list_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            kisi.Ad = "Ahmet";

            Kisi kisi2 = new Kisi();
            kisi2.Ad = "Ali";

            List<string> kisiIsımleri = new List<string>();
            kisiIsımleri.Add(kisi.Ad);
            kisiIsımleri.Add(kisi2.Ad);


            //foreach (var isim in kisiIsımleri)
            //{
            //    Console.WriteLine(isim);
            //}

            kisiIsımleri.ForEach(isim => Console.WriteLine(isim));


            List<Kisi> users = new List<Kisi>();

            users.Add(
                new Kisi()
                {
                    Ad = "Ayşe",
                    Soyad = "Demir"
                }    
            );
            users.Add(
               new Kisi()
               {
                   Ad = "Işık",
                   Soyad = "Çelik"
               }
           );

            foreach (var u in users)
            {
                Console.WriteLine(u.Ad + " " + u.Soyad);
            }

            Console.ReadLine();
        }
    }
}
