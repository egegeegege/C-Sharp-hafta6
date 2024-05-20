using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erisim_belirleyiciler
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Erişim Belirleyiciler
            // Methodun, Classın yada property nin nereden erişilip erişilmeyeceğini belirttiğimiz anahtar kelimelerdir
            // Public => Her yerden erişilebilir.
            // Internal => Sadece o proje içinde heryerden erişilebilir.
            // Private => Sadece tanımlandığı sınıftan erişilebilir.
            // Protected => Korumalı erişim sadece miras alınan sınıftan erişilebilir.

            ErisimBelirleyici erisimBelirleyici = new ErisimBelirleyici();
            string oz = erisimBelirleyici.Ozellik;
            erisimBelirleyici.HalkaAcik();
            erisimBelirleyici.OzeleEris(); // Private direkt olarak çağırlamaz

            Canli canli = new Canli();
            Insan insan = new Insan();
                       
            Console.ReadLine();
        }
    }
}
