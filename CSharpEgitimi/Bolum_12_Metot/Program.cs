//using D_12_Metot;

namespace Bolum_12_Metot
{
    internal class Program
    {

        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 105 Bilgilendirme

        //static void Main(string[] args)
        //{

        //}

        #endregion

        #region VİDEO 106 Main Metotu İnceleme

        //static void Main(string[] args)
        //{
        //    /*

        //    Bölüm 12 Metot VİDEO 106 Main Metotu İnceleme 

        //    */

        //    /*

        //    notlarda tamamı var

        //    */

        //    Console.WriteLine("Merhaba");

        //    System.Console.WriteLine("Merhaba");

        //    Selamla();

        //    Console.ReadLine();

        //}

        ///*

        //anlatımı notlarda yazıyor

        //*/
        //static void Selamla()
        //{
        //    Console.WriteLine("Merhaba Metot");
        //}

        #endregion

        #region VİDEO 107 C# Nesne Yönelimli Programlama ( Kısa Giriş )

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 107 C# Nesne yönelimli programlama ( Kısa Giriş )

        //    */

        //    /*

        //    Metotlar kısmına calısmak için yeni bir class olusturup
        //    bu class ı ornekleyip metotlarına erişip main metotunda metotların tanımlarını incelememiz lazım

        //    şimdilik class kavramına girmiyorum ihtiyacımız oldugu kadar anlatacagım

        //    yeni bir class eklemek için
        //    Solution Explorer kısmında ki uygulamamızın üstüne gelelim calısıtıgımız projeye
        //    D_12_Metot sag tık Add e tıklayıp Class kısmını secelim
        //    acılan pencerede class secip isim verelim 
        //    Ogrenci adını verdik
        //    uygulamamızın içerisinde bir Ogrenci.cs adında bir dosya olustu 
        //    Ogrenci class ımız olusmus oldu

        //    Ogrenci.cs de devam edelim

        //    Ogrenci.cs den geldik

        //    Ogrenci class ını cagıralım burda

        //    class kullandıgımız için new lemek orneklemek instance olusturmak gerekiyor
        //    burda sadece class a ulasmak için olarak dusunebilirsin 
        //    aslında arka tarafta stack heap yapıları bişeyler degişiyor ama class bölümünde göreceğiz


        //                Ogrenci107 O1 = new Ogrenci107();

        //    şimdi O1. dedigimizde içindeki metoda ulasmıs olduk

        //    O1.OgrenciSelamla();

        //    metotu yazarken parantezlere geldiğinde tooltype cıkıyor 
        //    void Ogrenci.OgrenciSelamla() yazıyor
        //    yani parametre almamıs geriye bişey döndürmüyor bilgisini veriyor

        //                Ogrenci107 O1 = new Ogrenci107();

        //    e gelip breakpoint koyup debug edelim

        //    f11 ile devam ediyoruz
        //    nesneyi olusturdu o1. kısmında metotun oldugu yere gitti Ogrenci class ına 
        //    OgrenciSelamla metodunun scoplarına düştü
        //    calıstırdı bitirdi geriye buraya döndü 

        //    */

        //    Ogrenci107 O1 = new Ogrenci107();
        //    O1.OgrenciSelamla();


        //}

        #endregion

        #region VİDEO 108 Yeni Bir Metot Tanımlamak

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 108 Yeni Bir Metot Tanımlamak

        //    */

        //    /*

        //    107. video da sadece Ogrenci class ını olusturup bir tane metot olusturduk
        //    108. video da bunu geliştirelim
        //    detaylarına inelim
        //    nerele ihtiyacımız var 
        //    hangi ihtiyacımızı karsılamak için nasıl bir tanım yapmamız lazım

        //     Ogrenci Class ından devam edelim

        //    Ogrenci class ından geldik
        //    newleme yapmamız lazım

        //    Ogrenci108 O2 = new Ogrenci108();
        //    02.OgrenciMetot( yazınca tooltype ler cıkıyor 
        //    Ogrenci108 clasının içinde bir metot bu
        //    diger tarafta verdiğimiz parametre istemesi void geriye dönüş olmasın vs hepsi orda ornek olarak yazıyor

        //    O2.OgrenciMetot("Mücahit", "Çetinkaya");

        //    sırayla parametreleri verince verilen parametre daha kalın yazıyor

        //    Ogrenci108 e breakpoint bırakalım f11 ile debug yapalım

        //    Ogrenci108 nesnesini new ledi bunun acıklaması class işlerken detaylı yapılacak
        //    O2. uzerınden OgrenciMetot metoduna gidecek giderken parametre götürüyor
        //    f11 ile devam edince Ogrenci108 e geçiyor scoplara düşüyor
        //    oradaki parametrelere bakınca bilgileri tasıdıgını görürürüz
        //    kodu okuyup buraya geri dönüyor

        //    Ogrenci108 deki metotun erişim belirleyicisini private yapalım ne olacak bakalım

        //    OgrenciMetot kısmında hata yazdı 
        //    tekrar O2. yazıp ulasmaya calısalım 
        //    OgrenciMetot gözükmüyor private oldugu için sadece olustugu kısımda kullanılmaya izni var 

        //    private bir metot hazırlayıp aynı class içinde kontrol edelim

        //    Ogrenci108 classına gidelim

        //    Ogrenci108den geldik

        //    OgrenciMetot3 public 
        //    OgrenciMetot2 private
        //    public içinde private metot cagırdık burda da onu tetiklemiş olduk

        //    debug
        //    nesne olustu nesne uzerınden metota gitti metot içindeki kodu calıstırdı
        //    ordada baska nesne var private ama aynı yerdeler onu da ordan calıstırdı
        //    tekrar metot3 e geldi kodu bitirdi buraya geldi tamamen bitirmiş oldu

        //    */

        //    Ogrenci108 O2 = new Ogrenci108();
        //    O2.OgrenciMetot1("Mücahit", "Çetinkaya");


        //    O2.OgrenciMetot3();

        //}

        #endregion

        #region VİDEO 109 Metot Uygulama - 1 : Matematiksel İşlemler

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 109 Metot Uygulama - 1 : Matematiksel İşlemler

        //    */

        //    /*

        //    Daha önceden yaptıgımız toplama cıkartma işlemlerini 
        //    class acıp metotlastırarak yapmak istiyorum

        //    bir class acalım Matematik109
        //    gerekli eklemeleri yaptık 

        //    Matematik109 den geldik

        //    debug yaparsan eger aynı işlemler gidiyor okuyor geliyor vs

        //    menu de secim yapmamızı istiyor
        //    bunu ReadLine ile üzerine alacagız değiskenin
        //    int kullaniciSecim olarak kullanıdan gelen degeri kayıt edecegım ama
        //    ReadLine ile almam lazım şöyle bir durum var
        //    ReadLine üzerine gelirsen eger tooltype de yazıyor string olarak geriye değer dönüyorum diyor

        //    o zaman once tür dönüşümü yapıp sonra kayıt edecegiz geleni

        //    int kullaniciSecim = Convert.ToInt32(Console.ReadLine());

        //    burda kullanıcı bir secim yaptı o zaman hemen bir
        //    switch case yapısı kuralım kullaniciSecim e bakacak
        //    1 2 3 4 e basınca ne olacak ona göre karar verdirelim

        //    bütün seçimlerde 2 deger isteyecek o zaman bunuda dısarıda isteyelim

        //    kullanıcı rakam sayı yazmazsa abc gibi bir deger yazarsa ne olur
        //    normalde bunları da kontrol etmemız lazım ama su anda biz 
        //    kullanıcıdan gelen degerin dogru oldugunu kabul ediyoruz
        //    yoksa try cash mekanizmalarımız var 
        //    degere göre böyle davran diyebiliriz ileride göreceğiz

        //    1 e basınca toplama işlemi yapacak
        //    class içinden toplama metodunu cagırmak için
        //    M1.ToplamaIslemi() ni cagırmamız lazım ve gerekli parametreleri vermemiz gerekiyor
        //    parametleri de kullanıcıdan alıyoruz onları vereceğiz

        //    ToplamaIslemi decimal deger istiyor 2 tane onları verdik
        //    geriye de decimal dönüyor onuda decimal sonuc degiskenine atadık

        //    bütün metotları hazırladık birde ekrana yazması için sonucları bunun için bir metot hazırlamak istiyorum
        //    3 tane parametre isteyecek kullaniciSayi1 kullaniciSayi2 sonuc 

        //    Matematik109 e dönelim

        //    debug ta yaptık gerekli işleme gidiyor kullanıcıdan deger istiyor işlemi yapıp return ediyor ekrana basıyor vs
        //    */


        //    Matematik109 M1 = new Matematik109();

        //    YenidenIslemYap:

        //    M1.MenuHazirla();

        //    int kullaniciSecim = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Lütfen 1. sayı değerini giriniz : ");
        //    decimal kullaniciSayi1 = Convert.ToDecimal(Console.ReadLine());
        //    Console.Write("Lütfen 2. sayı değerini giriniz : ");
        //    decimal kullaniciSayi2 = Convert.ToDecimal(Console.ReadLine());

        //    decimal sonuc = 0;


        //    switch (kullaniciSecim)
        //    {
        //        case 1: /* Toplama */
        //            sonuc = M1.ToplamaIslemi(kullaniciSayi1, kullaniciSayi2);
        //            M1.SonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
        //            break;
        //        case 2: /* Çıkartma */
        //            sonuc = M1.CikartmaIslemi(kullaniciSayi1, kullaniciSayi2);
        //            M1.SonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
        //            break;
        //        case 3: /* Bölme */
        //            sonuc = M1.BolmeIsleme(kullaniciSayi1, kullaniciSayi2);
        //            M1.SonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
        //            break;
        //        case 4: /* Çarpma */
        //            sonuc = M1.CarpmaIslemi(kullaniciSayi1, kullaniciSayi2);
        //            M1.SonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
        //            break;
        //        default:
        //            Console.WriteLine("Belirtmiş oldugunuz değer liste içerisinde bulunamadı.");
        //            Console.WriteLine("Lütfen yeniden deneyiniz.");
        //            System.Threading.Thread.Sleep(2000);
        //            goto YenidenIslemYap;
        //    }

        //    Console.WriteLine("Yeni işlem yapmak istiyor musunuz ? (E/H)");
        //    string eh = Console.ReadLine();

        //    if (eh.ToUpper() == "E")
        //    {
        //        goto YenidenIslemYap;
        //    }


        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 110 Metot Ödev - 1

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 110 Metot Ödev - 1

        //    */

        //    /*

        //    Main metodunda bir ögrencinin adını soyadını 3 adet ders notunu alacaksınız
        //    Almış oldugunuz bu bilgileri Ogrenci sınıfı içinde 
        //    OgrenciPuanHesapla adında bir metoda parametre olarak verip bilgisini ekrana cıkartacaksınız
        //    3 adet notu toplayıp ortalama alacak ekrana yazacak
        //    ortalama sonuc
        //    45 den büyükse geçti
        //    45 den küçükse kaldı


        //    */

        //    Ogrenci110 O1 = new Ogrenci110();

        //    Console.Write("Ögrencinin Adını giriniz : ");
        //    string ad = Console.ReadLine();
        //    Console.Write("Ögrencinin Soyadını giriniz : ");
        //    string soyAd = Console.ReadLine();
        //    Console.Write("Ögrencinin birinci notunu giriniz : ");
        //    decimal not1 = Convert.ToDecimal(Console.ReadLine());
        //    Console.Write("Ögrencinin ikinci notunu giriniz : ");
        //    decimal not2 = Convert.ToDecimal(Console.ReadLine());
        //    Console.Write("Ögrencinin üçüncü notunu giriniz : ");
        //    decimal not3 = Convert.ToDecimal(Console.ReadLine());

        //    O1.OgrenciPuanHesaplama(ad,soyAd,not1,not2,not3);

        //}

        #endregion

        #region VİDEO 111 Public ve Private Erişim Belirleyicileri

        //static void Main(string[] args)
        //{
        //    /*

        //        Bölüm 12 Metot VİDEO 111 Public ve Private erişim belirleyicileri.

        //    */

        //    /*

        //    Ogrenci111 class ını actık public ve private farklarına bakıyoruz su anda
        //    OgrenciMetotHesapla private olarak olusturduk 
        //    burda Ogrenci classını new ledik ama
        //    o. diyince public olan metot geliyor ama private oldugu için digerine ulaşamıyoruz

        //    bunun yerıne yapacagımız olay 
        //    OgrenciPuanHesaplama metodu içinde degisiklikler oraya gidip not alalım

        //    private metot neden lazım olur
        //    dıs katmanda biz bazı bilgileri alırız
        //    almıs oldugumuz bilgileri ise 
        //    içeride olusturmus oldugumuz public metodun içinde sırasıyla yazmak istemeyiz
        //    onlarda aslında kendi başlarına iş yapan modüller olarak yazılması gerekir
        //    ama dış dunyaya da kapalı olması gerekir
        //    bu durumlarda dıs dunyaya actıgımız metodu puclic
        //    içerideki operasyonlarımızı private olarak belirleriz

        //    veya
        //    tc kimlik tutacak diyelim herkesin görmesini istemeyiz ama bilginin dönmesi gerekiyor
        //    private olarak saklarız döndürürüz puclic metota 
        //    onun üstünden işlem yaparız

        //    kodlama içerisinde 3 satırı geçiyorsanız eger bunu metot yapın diye bir söylem vardır
        //    bu söylem cok tutulmasa da 
        //    yazılan kod bir modulse operasyonsa bir iş yapıyorsa işi ayırmak en dogru secenek

        //    debug anlatımı 
        //    public metota gidiyor sonra onun içine private metotdu verdık aynı yerde oldukları için okuyor
        //    sonra oraya gidip bilgileri alıp geliyor vs 

        //    */

        //    Ogrenci111 O = new Ogrenci111();

        //    Console.Write("Ögrencinin Adını giriniz : ");
        //    string ad = Console.ReadLine();
        //    Console.Write("Ögrencinin Soyadını giriniz : ");
        //    string soyAd = Console.ReadLine();
        //    Console.Write("Ögrencinin birinci notunu giriniz : ");
        //    decimal not1 = Convert.ToDecimal(Console.ReadLine());
        //    Console.Write("Ögrencinin ikinci notunu giriniz : ");
        //    decimal not2 = Convert.ToDecimal(Console.ReadLine());
        //    Console.Write("Ögrencinin üçüncü notunu giriniz : ");
        //    decimal not3 = Convert.ToDecimal(Console.ReadLine());

        //    O.OgrenciPuanHesaplama(ad, soyAd, not1, not2, not3);

        //}

        #endregion

        #region VİDEO 112 Return Anahtar Kelimesi

        //static void Main(string[] args)
        //{

        //    /*

        //        Bölüm 12 Metot VİDEO 112 Return Anahtar Kelimesi

        //    */

        //    /*

        //    Metotlarımız bir değer olusturduktan sonra bu değeri onu cagıran noktaya geri gönderebilir
        //    geri gönderme işlemin de return anahtar kelimesini kullanırız
        //    bu return anahtar kelimesi mevcut olan degeri alıyor 
        //    ve metodun dısarısına gönderiyor

        //    Ogrenci112 class ında notlar yazıyor burda herhangi bir işlem yapmaya gerek olmadı
        //    Ogrencı111 dan aldık kodları

        //    */

        //}

        #endregion

        #region VİDEO 113 Parametre alan ve parametre gönderen metotlar

        //static void Main(string[] args)
        //{

        //    /*

        //        Bölüm 12 Metot VİDEO 113 Parametre alan ve parametre gönderen metotlar

        //    */

        //}

        #endregion














    }
}
