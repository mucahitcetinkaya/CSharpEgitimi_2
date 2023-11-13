using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_06_TemelKonularDegiskenlerTurDonusumleri
{
    internal class Program
    {
        #region VİDEO 25
        //static void Main(string[] args)
        //{
        //    /* degiskenTipi degiskenAdi = değer; */
        //    string isimSoyisim = "Mücahit Çetinkaya";
        //    Console.WriteLine(isimSoyisim);
        //    Console.ReadLine();
        //}
        #endregion

        #region VİDEO 26
        static void Main(string[] args)
        {
            string isimSoyisim1 = "Mücahit Çetinkaya1";
            Console.WriteLine(isimSoyisim1);


            isimSoyisim1 = "Muhammet Çetinkaya2";
            Console.WriteLine(isimSoyisim1);

            /* büyük karakter küçük karakter */

            string isimSoyisim2 = "Mücahit Çetinkaya3";
            string buyukKarakter1 = isimSoyisim2.ToUpper();
            string kucukkKarakter1 = isimSoyisim2.ToLower();
            Console.WriteLine(buyukKarakter1);
            Console.WriteLine(kucukkKarakter1);

            /* belirli bir bölümü vermiş oldugum kısımı console a yazdırır */

            /* Substring */

            string isimSoyisim3 = "Mü4444t Çetinkaya4";
            string belirliBirBolum1 = isimSoyisim3.Substring(2, 4);
            Console.WriteLine(belirliBirBolum1);


            string isimSoyisim4 = "Mü5555t Çetinkaya5";
            string buyukKarakter2 = isimSoyisim4.ToUpper();
            Console.WriteLine(buyukKarakter2);
            string kucukkKarakter2 = isimSoyisim4.ToLower();
            Console.WriteLine(kucukkKarakter2);
            string belirliBirBolum2 = isimSoyisim4.Substring(2, 4);
            Console.WriteLine(belirliBirBolum2);
            Console.ReadLine();
        }
        #endregion

    }
}
