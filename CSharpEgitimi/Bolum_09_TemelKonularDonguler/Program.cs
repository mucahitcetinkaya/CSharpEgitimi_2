namespace Bolum_09_TemelKonularDonguler
{
    internal class Program
    {

        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 76 Bilgilendirme

        //static void Main(string[] args)
        //{

        //}

        #endregion

        #region VİDEO 77 For Döngüsü - Genel Kullanım

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

        #region VİDEO 78 For Döngüsü Örnek Uygulama 2 Adet

        //static void Main(string[] args)
        //{

        //    /*
        //      VİDEO 78 For Döngüsü Örnek Uygulama 2 Adet
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

        #region VİDEO 79 For Döngüsü - Ödev Uygulaması 1

        //static void Main(string[] args)
        //{

        //    /*

        //    VİDEO 79 For Döngüsü - Ödev Uygulaması 1

        //    Kullanıcı ekran üzerinden bir sayı girişi yapacak. Mesela 5 gibi
        //    Girilen sayının faktöriyel hesabını yapıp ekrana sonucu yazdıracağız.

        //    */

        //    Console.Write("Faktöriyel hesabı yapılmasını istediğiniz sayıyı giriniz : ");
        //    int kullanicidanGelenDeger = Convert.ToInt32(Console.ReadLine());
        //    int faktoriyelHesapla = 1;

        //    for (int i = kullanicidanGelenDeger; i > 1; i--)
        //    {
        //        faktoriyelHesapla *= i;
        //    }

        //    Console.WriteLine("{0} değerinin faktöriyel sonucu : {1}", kullanicidanGelenDeger, faktoriyelHesapla );
        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 80 For Döngüsü Sonsuz Döngü Yapılması - Break - Continue Anahtar Kelimeleri

        //static void Main(string[] args)
        //{

        //    /*

        //        VİDEO 80 For Döngüsü Sonsuz Döngü Yapılması - Break - Continue Anahtar Kelimeleri

        //    */

        //    /*

        //      1 . çalışma kodu anlatımı notlarda var

        //    for (; ; )
        //    {
        //        Console.WriteLine("Ben for sonsuz döngüsüyem!");
        //    }

        //    */


        //    /*

        //      2 . çalışma kodu anlatımı notlarda var

        //    int sayac = 0;
        //    for (; ; )
        //    {
        //        sayac++;
        //        if (sayac == 2)
        //            break;
        //        // continue anahtar kelimesi

        //        Console.WriteLine(sayac);

        //        Console.WriteLine("Ben for sonsuz döngüsüyem!");
        //    }

        //    */



        //    /*

        //      3. çalışma kodu anlatımı notlarda var

        //    int sayac = 0;
        //    for (; ; )
        //    {
        //        sayac++;
        //        if (sayac == 2)
        //            continue;

        //        Console.WriteLine(sayac);

        //        Console.WriteLine("Ben for sonsuz döngüsüyem!");
        //    }

        //    */

        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 81 İç İçe For Döngüsü Kullanımı

        //static void Main(string[] args)
        //{
        //    /*

        //     VİDEO 81 İç İçe For Döngüsü Kullanımı

        //    */

        //    /*

        //      anlatımı notlarda var

        //    */

        //    for (int i = 1; i <= 20; i++)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();

        //    }

        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 82 İç İçe For Döngüsü Kullanımı Ödev 2

        //static void Main(string[] args)
        //{

        //    /*

        //      VİDEO 82 İç İçe For Döngüsü Kullanımı Ödev 2

        //      ödev çarpım tablosu

        //      1 * 1 = 1
        //      1 * 2 = 2
        //      1 * 3 = 3
        //      1 * 4 = 4
        //      1 * 5 = 5
        //      1 * 6 = 6
        //      1 * 7 = 7
        //      1 * 8 = 8
        //      1 * 9 = 9
        //      1 * 10 = 10

        //    */


        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine($"1 * {i} = " + (1 * i));
        //    }


        //    for (int i = 1; i <= 10; i++)
        //    {
        //        for (int j = i; j <= i; j++)
        //        {
        //            Console.WriteLine($"{i} * {j} = " + (i * j));
        //        }
        //    }


        //    for (int i = 1; i <= 10; i++)
        //    {
        //        for (int j = 1; j <= 10; j++)
        //        {
        //            int sonuc = i * j;
        //            Console.Write($"{j}*{i}={sonuc}\t");

        //            /*

        //             2. çözüm alt alta sıralama

        //             Console.WriteLine($"{i} * {j} = " + (i * j));

        //            */

        //        }

        //        Console.WriteLine();
        //    }

        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 83 Foreach Döngüsü

        //static void Main(string[] args)
        //{

        //    /*

        //    VİDEO 83 Foreach Döngüsü

        //    */

        //    /*

        //    notlarda anlatımı var

        //    */

        //    string[] isimler = new[] { "Mücahit", "Muhammet", "Çetinkaya", "Arden", "Arthur", "Zayn" };

        //    foreach (string item in isimler)

        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 84 While Döngüsü Genel Kullanım

        //static void Main(string[] args)
        //{

        //    /*

        //     VİDEO 84 While Döngüsü Genel Kullanım

        //     ANLATIMI NOTLARDA VAR

        //    */


        //    /*

        //    Örnek Kullanım 1 : Ekrana 1 - 10 a kadar sayıların değerlerini yazdıralım 

        //     */

        //    int sayac = 1;
        //    while (sayac <= 10)
        //    {
        //        Console.WriteLine(sayac);
        //        sayac++;

        //    }
        //    Console.ReadLine();

        //}






        #endregion










    }
}