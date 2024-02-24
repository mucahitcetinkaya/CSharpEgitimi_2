using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace D_08_TemelKonularKosulIfadeleri
{
    internal class Program
    {
        //#region VİDEO 
        //static void Main(string[] args)
        //{

        //}
        //#endregion

        #region VİDEO 66

        //static void Main(string[] args)
        //{
        /* 66 Karar yapıları - IF kullanımı */


        //Console.WriteLine("Sayı 1 değerinizi giriniz : ");
        //string sStr1 = Console.ReadLine();

        //Console.WriteLine("Sayı 2 değerini giriniz : ");
        //string sStr2 = Console.ReadLine();

        //decimal sayi1 = Convert.ToDecimal(sStr1);
        //decimal sayi2 = Convert.ToDecimal(sStr2);
        //decimal toplam = sayi1 + sayi2;


        //bool toplamKontrol = toplam > 50; /* geçen bölüm if lere gelmeden buraya kadar yapabiliyorduk */

        //if (toplamKontrol) /* burası uzun kullanım gerek yok */
        //{
        //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyüktür.");
        //}

        /*
        toplamKontrol kısmını bool üzerine alıp öyle yazdık üst kısımda böyle yapmamıza gerek yok
        bool olarak bir degisken tanımlamak zorunda degılız
        */

        //if (toplam > 50) /* bool a gerek yok parantez içinde oldugundan if true yada false veriyor zaten */
        //{
        //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyüktür.");
        //    /*
        //    konsoldan girilen değer 50 den büyükse süslü parantez işlemine geçiyor
        //    konsoldan girilen değer 50 den küçükse if içindeki süslü parantez işlemlerini çalıştırmaz atlar
        //    altında bişey yoksa programı bitirir
        //    */
        //}

        //Console.ReadLine();

        //}

        #endregion

        #region VİDEO 67

        //static void Main(string[] args)
        //{

        //    /* 67 Karar yapıları - IF ve ELSE kullanımı */

        //    Console.WriteLine("Sayı 1 değerinizi giriniz : ");
        //    string sStr1 = Console.ReadLine();

        //    Console.WriteLine("Sayı 2 değerini giriniz : ");
        //    string sStr2 = Console.ReadLine();

        //    decimal sayi1 = Convert.ToDecimal(sStr1);
        //    decimal sayi2 = Convert.ToDecimal(sStr2);
        //    decimal toplam = sayi1 + sayi2;


        //    /*
        //    IF KISMINI İNCELEDİK
        //    IF ŞARTININ OLUMSUZ OLMASI DURUMUNDA ÇALIŞMASINI İSTEDİĞİMİZ EK İŞLEMLER VARSA
        //    BUNLARI NASIL BELİRLEYEBİLİRİZ BİRLİKTE BUNLARI İNCELEYELİM
        //    */

        //        /* IF TEN SONRA GELİYOR IF TE YAZILANLAR EGER DOGRU DEĞİLSE ELSE KULLANILIYOR */
        //    /*
        //    else
        //    {
        //         şart veya şartlar dogru değilse o zaman calısacak kodlar 
        //    }
        //    */

        //    if (toplam > 50)
        //    {
        //        /*
        //        mesela burada konsoldan girilen değer toplamı 100 se yani şart dogru ise
        //        true gelir toplamın sonucu breakpoint koyarak kontrol edebilirsin
        //        if gelir toplama bakar büyüktür yazdırır cıkar
        //        else hiç bakmaz
        //        altındaki kodları calısmaya geçer
        //        */
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyüktür.");

        //    }
        //    else
        //    {

        //        /*
        //        toplam 50 den büyük değilse o zaman else bakar
        //        kucuktür yazdırır
        //        altında herhangi bir kod varsa onları calıstırmaya geçer
        //        */
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den küçüktür.");

        //    }

        //    Console.ReadLine();
        //}

        #endregion

        #region VİDEO 68

        //static void Main(string[] args)
        //{

        //    /* 68 Karar yapıları - IF ve ELSE IF kullanımı */


        //    Console.WriteLine("Sayı 1 değerinizi giriniz : ");
        //    string sStr1 = Console.ReadLine();

        //    Console.WriteLine("Sayı 2 değerini giriniz : ");
        //    string sStr2 = Console.ReadLine();

        //    decimal sayi1 = Convert.ToDecimal(sStr1);
        //    decimal sayi2 = Convert.ToDecimal(sStr2);
        //    decimal toplam = sayi1 + sayi2;


        //    /*
        //     ONCEKİLERDE
        //     GİRİLEN DEĞERLERİN TOPLAMI 50 DEN BÜYÜKSE
        //     EKRANA BUYUK YAZ
        //     BUYUK DEĞİLSE KUCUK YAZ DEMİŞTİK

        //     PEKİ BİZİM İSTEĞİMİZ ŞÖYLE OLSA
        //     GİRİLEN DEĞERLERİN TOPLAMI
        //     100 DEN BUYUKSE 100 DEN BUYUK YAZALIM
        //     50 DEN BUYUKSE 50 DEN BUYUK YAZALIM
        //     50 DEN KUCUKSE 50 DEN KUCUK YAZALIM
        //     BURADA 3 ŞART VAR
        //     100 DEN BUYUKSE İF
        //     50 DEN BUYUKSE ELSE İF
        //     50 DEN KUCUKSE ELSE
        //     IF EGER BU DOGRUYSA DEĞİL Mİ ELSE IF YA BU DEMEMİZİ SAĞLIYOR
        //     IF ILE ELSE ARASINA ISTEDIGIMIZ KADAR ELSE IF İLE ARA KOD YAZABİLİRİZ
        //     EL SON ELSE İLE KODU BİTİRİRİZ
        //     ALTINA YAZILACAK BASKA KODLAR VARSA DEVAM EDEBİLİR
        //    */

        //    if (toplam >= 100)
        //    {
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 100'den büyük veya eşittir.");
        //        /*
        //        1.girilen değerler 50 den küçük olsun
        //        burada değer false gelirse
        //        bir altına iner 2.şartı test eder
        //        2.girilen değerler 100 den küçük 50 den büyük olsun
        //        burayı false okur bir aşağıya iner
        //        3.değer 100 den büyük olsun
        //        burası true gelir konsola yazdırır
        //        else if veya else ugramaz
        //        if blogunun dısından devam eder
        //        */
        //    }

        //    else if (toplam >= 50)
        //    {
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyük veya eşittir.");
        //        /*
        //        1.girilen değer 50 den küçük
        //        if false verdi buraya geldi burasıda false verdi
        //        başka else if varsa ona bakar yoksa uygulama else bakar
        //        2.girilen değerler 100 den küçük 50 den büyük olsun
        //        50 den büyük konsola yazdırır else gitmez
        //        if blogunun dısından devam eder
        //        */
        //    }

        //    else
        //    {
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den küçüktür.");
        //        /*
        //        1.girilen değer 50 den küçük
        //        buraya gelir konsola yazdırır
        //        if blogunun dısından devam eder
        //        */

        //    }

        //    /*
        //    NOT: if te 1.sayı 50 2.sayı 100 olsa algoritma yanlıs olur 50 den büyükse zaten 100 den büyük olur
        //    hiç diğer kısımlara bakmaz
        //    1.kodda dogru olanı aldım bitti gibi bakıyor
        //    if blogunun dısından devam eder
        //    uygulamayı yazarken kodsal hata aldıgımızda bir şekilde çözülür
        //    stackoverflow da yardım bulabiliriz.
        //    mantıksal hata yaparsak eğer o zaman mecbur kodu okuyup çözmen gerekiyor
        //    */

        //    Console.ReadLine();
        //}

        #endregion

        #region VİDEO 69

        //static void Main(string[] args)
        //{
        //    /* 69 Karar yapıları -Switch kullanımı */

        //    /* 

        //     YAZIMI 

        //    switch ( ifade )
        //    {
        //        case kontrol1;  buradaki case leri if else gibi düşünebilirsin 
        //            çalışacak olan işlemler 
        //            break; ;  ile cıkış yapılır 

        //             altına baska case lerde koyabilirsin 

        //        case kontrol2;  buradaki case leri if else gibi düşünebilirsin 
        //             çalışacak olan işlemler 
        //            break; ;  ile cıkış yapılır 

        //            bütün kontrollerden geçtik ama herhangi birine takılmadık
        //         else kısmı burada

        //        default:
        //             calısacak olan işlemler 
        //            break;  ile cıkıs yapılır 
        //    }
        //    */

        //    /*
        //    kullanıcı ne girebilir ocak subat mart vs veya bunların dısında yanlıs bir cevap
        //    bunları switchcase ile kontrol edelim
        //    */
        //    Console.WriteLine("Hangi Ay : ");
        //    string kullanicidanGelen = Console.ReadLine();

        //    switch (kullanicidanGelen)
        //    {
        //        case "Ocak": /* alttaki notu oku */
        //        case "Nisan":
        //            Console.WriteLine("01");
        //            break; /* ile kodu kapattık */
        //        case "Şubat":
        //            Console.WriteLine("02");
        //            break;
        //        case "Mart":
        //            Console.WriteLine("03");
        //            break;
        //        /* bunlardan hiç biri değilse default kısmı else kısmı oluyor bunu yaz dedik */
        //        default:
        //            Console.WriteLine("Belirtirilen değerlerin dışında bir değer girişi yaptınız.");
        //            break; /* ile yine kodu kapattık */

        //    }

        //    /*
        //     switchcase de girilen bütün değerleri kayıt ediyor tek tek bakmıyor
        //     mesela if te böyle birşey yaparsak
        //     if ocak mı şubat mı mart mı diye tek tek hepsini okur
        //     switchcase de ocak şubat mart vs hepsini kayıt ediyor
        //     kullanıcı ocak yazdı diyelim
        //     diğerlerine bakmaz switch blogunun dısından devam eder
        //     kullanıcı subat yazdı diyelim ocaga bakmaz şubatta bakar blogun dısından devam eder
        //     yani kodu arama yapıyor varsa eğer ordan devam ediyor
        //     yoksa eğer default a gidiyor istenilen şeyi yapıyor
        //     blogun dısına cıkıyor

        //     peki ocak veya subatsa mart veya nisansa bu calıssın nasıl denir
        //     yani case imiz birden fazla olabilir mi aynı işlemi calıstırabilir mi evet yapabilir

        //     case in altına baska bir case yazabiliriz
        //     burada ocak veya nisan mi diyor veya var
        //    */

        //}
        #endregion

        #region VİDEO 70

        //static void Main(string[] args)
        //{

        //    /*
        //    kullanıcı adını ve şifreyi degiskene atayıp if içinde degisken adı ile işlem yapabilirsin
        //    veya
        //    degisken yerine direk orda da yazabilirsin ama degiskene ataman degistirmen için kolaylık saglar
        //    */

        //    string ka = "admin";
        //    string sifre = "123";

        //    Console.WriteLine("Kullanıcı adınızı giriniz : ");
        //    string girilenKullaniciAdi = Console.ReadLine();

        //    Console.WriteLine("Kullanıcı adınızı giriniz : ");
        //    string girilenSifre = Console.ReadLine();

        //    if (girilenKullaniciAdi == ka && girilenSifre == sifre)
        //    {
        //        Console.WriteLine("Hoşgeldiniz");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı giriş!!");
        //    }

        //    /*
        //     * 2 side calısır sadece degisken var veya yok farkları bu 
        //    if (girilenKullaniciAdi == "admin" && girilenSifre == "123")
        //    {
        //        Console.WriteLine("Hoşgeldiniz");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı giriş!!");
        //    }
        //    */

        //    Console.ReadLine();
        //}

        #endregion



    }
}