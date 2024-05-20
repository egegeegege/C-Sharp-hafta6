using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erisim_belirleyiciler
{
    public class ErisimBelirleyici
    {
        public string Ozellik;
        public void HalkaAcik()
        {
            Console.WriteLine("Hello Public");
        }

        private void Ozel()
        {
            Console.WriteLine("Hello Private");
        }

        protected void Korumali()
        {
            Console.WriteLine("Hello Protected");
        }

        public void OzeleEris()
        {
            Ozel(); // Private ı sadece tanımlandığı yerde çağırabiliriz.
        }
    }
}
