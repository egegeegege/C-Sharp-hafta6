using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erisim_belirleyiciler
{
    public class Insan : Canli
    {
        public void BoyGoster()
        {
            Console.WriteLine(Boy); // Sadece miras alınan sınıftan protected bir özelliğe erişebildim.
        }
    }
}
