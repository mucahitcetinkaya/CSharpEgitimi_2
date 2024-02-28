﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_09_TemelKonularDonguler
{
    internal class Program
    {


        //#region VİDEO 
        //static void Main(string[] args)
        //{

        //}
        //#endregion

        #region VİDEO 76

        //static void Main(string[] args)
        //{

        //    /*
        //    for döngüsü oluşturalım
        //    for yazıp tab tab yapınca otomatik olusturdu
        //    int değişken tipinde i adında içerisinde 0 değeri olan sayaç kısmı
        //    0 default değeri saymaya 0 dan başla demiş oluyoruz.
        //    i değişkeni 10 dan kucuk yada eşitse bu işlemi yap diyoruz şart kısmı
        //    program buraya kadar geliyor kucuk yada eşit mi diye bakar true ise içindeki işlemi yapar
        //    işlemi yaptıktan sonra i++ kısmı sayaç artış kısmı oluyor biz burda++ ile 1 arttır demişiz
        //    illa++ veya 1 arttır dememiz gerekmiyor istediğimizi yazabiliriz.
        //    sayaç artış kısmını okur tekrar eder şart sağlana kadar
        //    şartımız 10 dan kucuk yada eşit 10 a eşit olunca yine yazdırır
        //    11 olunca false verir yazdırmaz programı durdurur.
        //    */

        //    for (int i = 0; i <= 10; i++)
        //    {
        //        Console.WriteLine("Ben bir for döngüsüyüm.");
        //    }

        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 77

        //static void Main(string[] args)
        //{

        //    /*
        //      VİDEO 77 For döngüsü - Örnek uygulama serisi - ( 2 farklı örnek uygulama içerir )
        //    */

        //    #region 1 - 10 arasındaki değerleri ekran üzerinde yazdıralım.


        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(i + " . tekrar !");
        //    }


        //    #endregion



        //    #region 1 - 100 arasındaki çift sayıları ekran üzerinde yazdıralım.


        //    for (int i = 1; i <= 100; i++)

        //    /*

        //      +2 yazdıgımda aldıgım hata
        //      only assignment call increment decrement await and new object expressions can be used as a statement
        //      çevirisi
        //      sadece atama çağrısı artış azaltma bekliyor ve yeni nesne ifadeleri bir ifade olarak kullanılabilir
        //      ++++yazdıgımda aldıgım hata
        //      the operand of an increment or decrement operator must be a variable, property or indexer
        //      çevirisi
        //      bir artırma veya azaltma operatörünün işleneni bir değişken, özellik veya indeksleyici olmalıdır
        //      içerisindeki sayaç artışı kısmında değilde işlemi içeride yaptırmak gerekiyormuş

        //      burda for içine if açtık
        //      yukarıda sayacak 1 den baslayıp 1 in 2 e bölümünden kalan 1
        //      if şartını sağlamaz geçer
        //      i++ ile 1 arttırıp tekrar işleme sokacak 2 oldu
        //      2 nin 2 e bölümünden kalan 0 true verdi konsola yazdırdı
        //      tekrar i++ ile arttıracak vs 100 e eşit olana kadar
        //      101 okudugunda tekrar dönmez

        //    */

        //    {

        //        if (i % 2 == 0) /* i nin 2 e bölümünden kalan 0 a eşitse */
        //        {

        //            /*
        //              konsola bunu yazdır
        //            */
        //            Console.WriteLine(i + " - çift sayıdır.");
        //            /*
        //            değilse devam et
        //            */

        //        }

        //    }


        //    #endregion



        //    #region 1 - 100 arasındaki çift sayıların toplamı nedir ? (Ödev)


        //    int toplam = 0;

        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            /*
        //             bu uzun yolu altta ki kısa yolu
        //             toplam = toplam + i;
        //            */
        //            toplam += i;
        //        }

        //    }

        //    /*
        //      for un dısına cıktık
        //    */

        //    Console.WriteLine("1 ile 100 arasındaki çift sayıların toplamı : " + toplam);
        //    Console.WriteLine("1 ile 100 arasındaki çift sayıların toplamı : {0}", toplam);

        //    /*
        //      ister + ile birleştir istersen süslü parantezden sonra vürgül ile birleştir
        //    */


        //    #endregion

        //    Console.ReadLine();

        //}

        #endregion



    }
}