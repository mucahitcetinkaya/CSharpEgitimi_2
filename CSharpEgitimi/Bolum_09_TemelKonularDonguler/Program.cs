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

        #region VİDEO 85 While döngüsü - Örnek Uygulama 2 Adet

        //static void Main(string[] args)
        //{

        //    /*

        //    VİDEO 85 While döngüsü - Örnek Uygulama 2 Adet

        //    */

        //    /*

        //    Çalışma 1
        //    Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadar ekrana yazdıralım
        //    mesela ekrana 3 yazdık
        //    3 2 1 0 olacak

        //    notlarda anlatımı var

        //    */


        //    Console.Write("Sayı giriniz : ");
        //    int kullaniciGelen = Convert.ToInt32(Console.ReadLine());

        //    while (kullaniciGelen != -1)
        //    {
        //        Console.WriteLine(kullaniciGelen);
        //        kullaniciGelen--;
        //    }


        //    /*--------------------------------------------------------------------------------------------*/

        //    /*

        //    Çalışma 2
        //    Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım.
        //    0 dan küçük bir değer girişi yapılırsa yani -1 mesela
        //    toplama işlemini bitirelim ve ekrana toplam sonucu yazalım

        //    notlarda anlatımı var            

        //    */

        //    Console.WriteLine(" Lütfen toplamak istediğiniz sayıları giriniz : ");
        //    Console.WriteLine(" Not -1 değeri işlemleri durdurur. ");

        //    int toplamDeger = 0;

        //    while (true)
        //    {
        //        string kullaniciGelenDegerString = Console.ReadLine();
        //        int kullaniciGelenDegerInt = Convert.ToInt32(kullaniciGelenDegerString);
        //        if (kullaniciGelenDegerInt < 0)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            toplamDeger = toplamDeger + kullaniciGelenDegerInt;
        //        }
        //    }

        //    Console.WriteLine("Toplam Değer : {0}", toplamDeger);

        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 86 While Döngüsü - Ödev Uygulaması 1

        //static void Main(string[] args)
        //{

        //    /*

        //    VİDEO 86 While Döngüsü - Ödev Uygulaması 1

        //    */

        //    /*

        //    Ödev 1
        //    Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının
        //    tahmin etmesini isteyecek bir uygulama yazalım
        //    en sonda da bilinirse eger su kadar denemede bildiniz gibi bir yazı yazalım

        //    */

        //    /*

        //    1.çözüm
        //    burda direk kullanıcıdan gelen degeri int e cevirmiş olduk

        //    */

        //    int sistemUretSayi1 = 0;
        //    int tahminAdet1 = 1;
        //    Random rnd1 = new Random();
        //    sistemUretSayi1 = rnd1.Next(1, 3);

        //    while (true)
        //    {
        //        Console.Write(tahminAdet1 + " . denemeniz tahmin giriniz : ");
        //        int rndKullaniciGelenInt1 = Convert.ToInt32(Console.ReadLine());
        //        if (rndKullaniciGelenInt1 == sistemUretSayi1)
        //        {
        //            tahminAdet1++;
        //            Console.WriteLine(tahminAdet1 + " . denemede doğru tahmin ettiniz. Tebrikler...");
        //            break;
        //        }
        //        else
        //        {
        //            Console.Clear();
        //            Console.WriteLine(tahminAdet1 + " . denemeniz yanlış tahmin tekrar deneyiniz. Tahmin Giriniz : ");
        //            tahminAdet1++;
        //        }
        //        Console.ReadLine();
        //    }


        //    /*

        //    2.çözüm
        //    readline ile string üzerine alıp sonradan int e ceviriyoruz
        //    ek bir satır daha giriyor araya

        //    */

        //    int sistemUretSayi2 = 0;
        //    int tahminAdet2 = 1;
        //    Random rnd2 = new Random();
        //    sistemUretSayi2 = rnd2.Next(1, 3);

        //    while (true)
        //    {
        //        Console.Write(tahminAdet2 + " . denemeniz tahmin giriniz : ");
        //        string rndKullaniciGelen2 = Console.ReadLine();
        //        int rndKullaniciGelenInt2 = int.Parse(rndKullaniciGelen2);
        //        if (rndKullaniciGelenInt2 == sistemUretSayi2)
        //        {
        //            tahminAdet2++;
        //            Console.WriteLine(tahminAdet2 + " . denemede doğru tahmin ettiniz. Tebrikler...");
        //            break;
        //        }
        //        else
        //        {
        //            Console.Clear();
        //            Console.WriteLine(tahminAdet2 + " . denemeniz yanlış tahmin tekrar deneyiniz. Tahmin Giriniz : ");
        //            tahminAdet2++;
        //        }
        //        Console.ReadLine();
        //    }

        //    /*

        //    3.çözüm
        //    if parantez içi değişik sadece notlarda anlatımı var
        //    int cevirme olayını satırda değil de if içinde yapıyoruz

        //    */

        //    int sistemUretSayi3 = 0;
        //    int tahminAdet3 = 1;
        //    Random rnd3 = new Random();
        //    sistemUretSayi3 = rnd3.Next(1, 3);

        //    while (true)
        //    {
        //        Console.WriteLine(tahminAdet3 + " . denemeniz tahmin giriniz : ");
        //        string rndKullaniciGelen3 = Console.ReadLine();
        //        if (int.Parse(rndKullaniciGelen3) == sistemUretSayi3)
        //        {
        //            tahminAdet3++;
        //            Console.WriteLine(tahminAdet3 + " . denemede doğru tahmin ettiniz. Tebrikler...");
        //            break;
        //        }
        //        else
        //        {
        //            Console.Clear();
        //            Console.WriteLine(tahminAdet3 + " . denemeniz yanlış tahmin tekrar deneyiniz. Tahmin Giriniz : ");
        //            tahminAdet3++;
        //        }
        //        Console.ReadLine();
        //    }
        //}

        #endregion

        #region VİDEO 87 do While Döngüsü Genel Kullanım

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 9 VİDEO 86 DO WHILE Döngüsü Genel Kullanımı
        //    anlatımı notlar da var

        //    */

        //    do
        //    {
        //      Console.WriteLine("MERHABA DO WHİLE");
        //    } while (1 == 2);
        //    Console.ReadLine();
        //}

        #endregion

        #region VİDEO 88 89 90 do While Döngüsü Ödev 1 2

        //static void Main(string[] args)

        //{

        //    /*

        //    VİDEO 88 do While Döngüsü Ödev 1

        //    */

        //    /*

        //    Ödev 1 :

        //    kullanıcıyı do while içerisine alın ve kullanıcı adı ve password sorun.
        //    kullanıcı adı : Demo
        //    Şifre: Demo
        //    olacak eğer kullanıcı bu değerleri bilirse donguden cıkın ve tebrikler başarılı yazın.
        //    eğer bilemezse tekrar sormaya devam edin.

        //    */

        //    string kullaniciAdi = "a";
        //    string sifre = "a";
        //    string girilenKullaniciAdi;
        //    string girilenSifre;

        //    do
        //    {
        //        Console.WriteLine(" Kullanıcı adınızı giriniz : ");
        //        girilenKullaniciAdi = Console.ReadLine();
        //        girilenKullaniciAdi = girilenKullaniciAdi.ToLower();
        //        Console.WriteLine(" Şifrenizi giriniz : ");
        //        girilenSifre = Console.ReadLine();
        //        girilenSifre = girilenSifre.ToLower();

        //        if (kullaniciAdi != girilenKullaniciAdi || sifre != girilenSifre)
        //        {
        //            Console.WriteLine("Tekrar deneyiniz.");
        //        }
        //    } while (kullaniciAdi != girilenKullaniciAdi || sifre != girilenSifre);
        //    Console.WriteLine("Tebrikler başarılı.");
        //    Console.ReadLine();

        //    /*

        //    Hocanın yaptıgı

        //    sayac degiskenıne neden ihtiyacımız var onu anlatacagım

        //    do while döngusu ne olursa olsun 1 kere her zaman calısıyor
        //    giriyor yanlıs girerse eger tekrar basa dönuyor ama hatalı demıyor
        //    bunun için bir if sart blogu koyalım
        //    hatalı diyebilmek için do içine koymamız lazım ama onu da sarta baglamamız gerekiyor ki
        //    her zaman calısmasın sayac bundan dolayı lazım bize

        //    not

        //    sayac ile kontrol etmemız onemlı bunun nedeni do while içerisinde herhangi bir if kosulu ile şartlarımızı kontrol etmedik
        //    while ( şart ) blogu içerisinde kontrollerimizi yaptıgımız için değerin hatalı veya dogru oldugunu sayac adındaki
        //    bu degisken üzerinden kontrol ettik.

        //    */

        //    string kullaniciAdi1 = string.Empty;
        //    string sifre1 = string.Empty;
        //    int sayac1 = 0;

        //    do
        //    {
        //        if (sayac1 > 0)
        //        {
        //            Console.WriteLine("Kullanıcı veya şifre değerlerinizden birisi hatalı tekrar deneyiniz.");
        //        }
        //        Console.WriteLine(" Kullanıcı adınızı giriniz : ");
        //        kullaniciAdi1 = Console.ReadLine();
        //        Console.WriteLine(" Şifrenizi giriniz : ");
        //        sifre1 = Console.ReadLine();

        //        sayac1++;

        //    } while (kullaniciAdi.ToLower() != "demo" || sifre.ToLower() != "demo");
        //    Console.WriteLine("Tebrikler başarılı.");
        //    Console.ReadLine();

        //    /*

        //    Ödev 2 :

        //    kullanıcıdan 1 ile x arasında bir sayı girmesini isteyin
        //    daha sonra sistem kullanıcının girmiş oldugu 1 ile x değerleri arasında bir sayı tahmini yapsın
        //    daha sonra kullanıcı sistemin tahmin etmiş oldugu sayıyı bulmaya calıssın.
        //    bulamazsa yeniden sorsun
        //    ne zaman kullanıcı ilgili değeri bulursa y kadar denediniz ve sonuca ulastınız desin.

        //    */

        //    int odev2Tahmin = 0;
        //    int odev2UretilenSayi = 0;
        //    int odev2TahminAdet = 0;

        //    Console.Write("Tahmin oyunu için en yüksek değeri giriniz : ");
        //    int odev2KullaniciMaxValue = Convert.ToInt32(Console.ReadLine());

        //    Random odev2Random = new Random();
        //    odev2UretilenSayi = odev2Random.Next(1, odev2KullaniciMaxValue);

        //    do
        //    {
        //        odev2TahminAdet++;
        //        Console.WriteLine("{0}. hakkınız üretilen sayıyı tahmin ediniz.", odev2TahminAdet);
        //        odev2Tahmin = Convert.ToInt32(Console.ReadLine());

        //    } while (odev2Tahmin != odev2UretilenSayi);

        //    Console.WriteLine("{0}. kere denemenizde sayıyı doğru tahmin ettiniz.", odev2TahminAdet);



        //    /*

        //    Çalışma 3 ben yaptım bunu
        //    kullanıcı rakam giriyor sistem bulmaya calısıyor

        //    */

        //    Console.Write("Tahmin edilmesini istediğiniz rakamı giriniz : ");
        //    int kullaniciGirilenTahminSayi1 = Convert.ToInt32(Console.ReadLine());
        //    int sistemTahminSayi1 = 0;
        //    int sayac4 = 1;

        //    do
        //    {

        //        if (sayac4 > 1)
        //            Console.WriteLine(sayac4 + ". yanlış tahmin.");

        //        Random random = new Random();
        //        sistemTahminSayi1 = random.Next(1, kullaniciGirilenTahminSayi1);

        //        if (kullaniciGirilenTahminSayi1 == sistemTahminSayi1)
        //        {
        //            Console.WriteLine(sayac4 + ". denemede sistem sayınızı dogru tahmin etti.");
        //        }

        //        sayac4++;

        //    } while (kullaniciGirilenTahminSayi1 != sistemTahminSayi1);

        //    Console.ReadLine();

        //}

        #endregion



    }
}