﻿//using Bolum_12_Metot;

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
        //    Bolum_12_Metot sag tık Add e tıklayıp Class kısmını secelim
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

        #region VİDEO 114 Metot parametrelerinde varsayılan değer atama işlemi

        //static void Main(string[] args)
        //{

        //    /*

        //        Bölüm 12 Metot VİDEO 114 Metot parametrelerinde varsayılan değer atama işlemi

        //    */

        //    /*

        //    Ogrenci114 den geldik

        //    not3 ü silince hata veriyor
        //    parametre olarak istiyor ama deger yok içinde ondan dolayı
        //    default olarak deger atamamız gerekiyor
        //    O.OgrenciPuanHesaplama(ad, soyAd, not1, not2);
        //    bu zorunlulugu kaldırmak için Ogrenci114 class ına gidelim 
        //    OgrenciPuanHesaplama da ki zorunlulugu kaldıralım

        //    Ogrenci114 den geldik

        //        decimal not3 = 45

        //    yazdık metoda zorunlulugu kalduırmıs olduk

        //    O.OgrenciPuanHesaplama(ad, soyAd, not1, not2);

        //    bunda olan hata da kalktı boylece
        //    parametre girmeye calısırsak eger not de yazım sekli değişti
        //    [decimal not3 = 45]
        //    olarak yazmaya basladı tooltype de 

        //    direk not3 olarak yazıp debug yapalım noluyor
        //    not3 e 30 yazdık default olarak 45 atasan da 
        //    üzerinde deger gelince mevcut degeri eziyor
        //    30 olarak alıyor

        //    not3 ü istemeden debug yapınca 45 olarak alıyor

        //    peki not3 = 45 den sonra , ile
        //    decimal not4 yazarsak ne oluyor hata alıyoruz
        //    sebebi default olarak degeri olan parametre hep sonra olmalı veya 
        //    default degeri varsa sonra gelende default deger sahibi olmalı

        //    */

        //    Ogrenci114 O = new Ogrenci114();

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

        //    O.OgrenciPuanHesaplama(ad, soyAd, not1, not2);
        //    //O.OgrenciPuanHesaplama(ad, soyAd, not1, not2, not3);

        //}

        #endregion

        #region VİDEO 115 Parametrelerde ref ve out anahtar sözcüklerinin kullanımı

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 115 Parametrelerde ref ve out anahtar sözcüklerinin kullanımı

        //    */

        //    /*

        //    Ref ve Out anahtar sözcüklerinde eski .net framework versiyonlarında 1 fark vardı
        //    mevcut framework sürümü 7.0 olanlar bu farktan etkilenmeyecektir.

        //    bir metot yazarak işlemlerimize baslayalım

        //    hoca bir videodan bahsediyor ama öyle bir video yoktu netten arastırdım bende ne nedir diye

        //    notlarda yazıyor

        //    stack ve heap yapılarından bahsetmıs ama videosu yok
        //    stack bolumunde bir int degisken olusturup içerisine bir deger atayıp bunun bir deger tipli bir davranıs oldugunu
        //    heap bolumunde ise referans durdugunu ortak yerlere bakan yerler olarak söz etmiş

        //    kodun anlatımı

        //    stack de sayi1 degiskenı olustu içinde 0 var 
        //    sonra bir metot olusturduk parametre verdik 

        //    DegerAtaRef metoduna ref ile degerini aktarırken
        //    gelenDeger adında bir degisken daha olustu
        //    degeri 0 olarak
        //    buda normal sartlarda stack bolgede olusması gerekiyordu fakat
        //    biz orda ref kullandıgımız için heap bolgede olustu

        //    standart davranıslarında ikiside degisken oldugu için
        //    stack bölgede olusmaları ve üzerlerindeki degerleri 0 olması gerekiyordu
        //    biz ref ile parametreye değeri aktardıgımız için
        //    bizim ref anahtar sozcugumuz bunları deger tipi davranıstan cıkarttılar
        //    ikisinin de ortak olarak heap bolgede degeri görmesini sagladı

        //    ref ve out anahtar sozcukleri aslında deger tipli davranısa sahip olan
        //    değişkenlerin referans tipli degisken olmasına olanak saglıyor

        //    sayi1 0 ken gelenDeger 10 
        //    bunları ref ile birbirine atadıgımız da 
        //    aynı yere bakacakları için
        //    sayi1 de 10 oluyor


        //    aralarındaki fark eger ben degiskenın içerisinde ref ile işaretlenmiş bir degisken ataması yapacaksam
        //    metodu cağırıp degisken atamasını yapacagım noktada 
        //    int sayi1 = 0; yani burda 
        //    atamak istediğim degiskenın refte bir deger alması gerekiyordu
        //    out kullanımında ise deger almazsa hata veriyordu

        //    yani 7 den oncesınde
        //    int sayi1;
        //    DegerAtaOut(out sayi1);

        //    static void DegerAtaOut(out int gelenDeger)
        //    {
        //        gelenDeger = 10;
        //    }
        //    boyle bir tanım yapsaydık
        //    hata veriyordu artık bu hata ortadan kalktı

        //    framework 7.0 dan sonra ref veya out degiskenler deger alıp almasa da bişey farketmiyor

        //    bu anahtar kelimeler onemlı 
        //    uygulamarın içerisinde cok sık kullanmasakta bazı noktalarda degiskenın butunlugunu bozmamak için
        //    ilgili degiskenın bir kopyasını olusturmak yerine degiskenı takip etmek için
        //    ref ve out anahtar sozcuklerınden faydanalıyoruz


        //    */

        //    int sayi1 = 0;

        //    DegerAtaRef(ref sayi1);




        //}

        //static void DegerAtaRef(ref int gelenDeger)
        //{
        //    gelenDeger = 10;
        //}

        //static void DegerAtaOut(out int gelenDeger)
        //{
        //    gelenDeger = 10;
        //}

        #endregion

        #region VİDEO 116 Değişken sayıda parametre almak ( params kullanımı )

        //static void Main(string[] args)
        //{
        //    /*

        //    Bölüm 12 Metot VİDEO 116 Değişken sayıda parametre almak ( params kullanımı )

        //    */

        //    /*

        //    degisken sayıda degısken alma işlemini params anahtar kelimesi ile yapıyoruz
        //    metot üzerinden anlatalım

        //    bir metot olusturduk main metodunun dısında yeni bir sınıf acmak yerine
        //    Topla metodu 
        //    static void Topla(params int[] sayilar)
        //    {
        //        int toplam = 0;

        //        for (int i = 0; i < sayilar.Length; i++)
        //        {
        //            toplam += sayilar[i];
        //        }
        //        Console.WriteLine("Toplam : {0}", toplam);
        //    }

        //    (params int[] sayilar) parametre istiyor şimdi bunu cagıralım

        //    Topla( yazdıgımızda tooltype cıkıyor ne istedigini bize gösteriyor

        //     (params int[] sayilar) params olarak bir dizi istiyor

        //    Topla(5, 9, 20, 45, 22, 12, 11, 56);

        //    dizi tanımı yapmadık normal parametre olarak yazıyoruz direk
        //    istediğimiz kadar degeri yazabiliyoruz params sayesinde

        //    params ifadesi girilen degerleri belirtmiş oldugumuz veri tipinden diziye cevirir
        //    ama bunu parametre olarak isterken bizden dizi istemez
        //    belirtmiş oldugumuz veri tipinden sıralı data ister
        //    sıralı datayı da iceride bir dizinin içerisine otomatik olarak aktarır

        //    params ifadesinden sonra string bir ifade alamazsınız
        //    params ifadeleri son ifade olmalıdır

        //    */

        //    Topla(5, 9, 20, 45, 22, 12, 11, 56);



        //}

        //static void Topla(params int[] sayilar)
        //{
        //    int toplam = 0;

        //    for (int i = 0; i < sayilar.Length; i++)
        //    {
        //        Console.WriteLine(sayilar[i]);
        //        toplam += sayilar[i];
        //    }
        //    Console.WriteLine("Toplam : {0}", toplam);
        //}

        #endregion

        #region VİDEO 117 Metotlara aşırı yüklenme işlemi nedir ?

        //static void Main(string[] args)
        //{
        //    /*

        //     Bölüm 12 Metot VİDEO 117 Metotlara aşırı yüklenme işlemi nedir ?

        //    */

        //    /*

        //    Metotlara asırı yuklenme nedir 

        //    ilk egıtıme baslarken 
        //    Console.WriteLine ile baslamıstık
        //    bunun tooltype ıne baktıgımızda 

        //    void Console.WriteLine yazıyor
        //    geriye bişey döndürmüyor Console sınıfına ait WriteLine metotuyum parametre almam diyor

        //    yanında da 1 of 19 yazıyor

        //    bu Console.WriteLine metotunun 19 farklı kullanımı mevcut anlamına geliyor

        //    bunlardan bir tanesi hiç parametre almayan versiyonu

        //    oklar ile degistirince baska kullanımları geliyor

        //    bool value parametre alan versiyonu

        //    char veri tipi alan versiyon char dizi alan versiyon vs 

        //    farklı farklı kullanım sekılleri var

        //    biz normal sartlarda string value versiyonunu kullanıyoruz

        //    yani

        //    Console.WriteLine("Merhaba Dünya");

        //    yazdıgımızda "" içinde oldugu için string versiyonunu kullanmıs oluyoruz

        //    veya

        //    Console.WriteLine(true);

        //    yazarsak bu seferde boolean versiyonunu cagırmıs oluruz

        //    biz bunun gibi metotlar tasarlayabiliriz

        //    aynı isimde ama farklı veri turlerinde 

        //    yeni bir class acmak yerine burda main metotunun dısında bir metot yazalım

        //    Topla metotunu burda cagıralım

        //    bu metotu cagırdıgımız da 

        //    Program class ının içinde olan void int sayi1 int sayi2 parametre isteyen bir metot cıkıyor tooltype da 

        //    yanında farklı kullanımlarını görmüyoruz cunku yok bunu görmek için ne yapmamız gerekiyor

        //    aynı metot imzasına ait ismine farklı bir metot olusturalım 

        //    aynı isme sahip ama istenilen veri tiplerinde farklı olarak metot olusturunca ve 

        //    Topla metodunu yenıden cagırınca 

        //    Tooltype da overloads cıktı farklı kullanımları da yazmaya basladı

        //    debug olarak baktımızda int deger verdik oda int deger olan metoda girdi islemi yaptı

        //    aşırı yukleme de bu oluyor

        //    */


        //    Topla(10,20);

        //}


        //static void Topla(int sayi1, int sayi2)
        //{
        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine(toplam);
        //}

        //static void Topla(double sayi1, double sayi2)
        //{
        //    double toplam = sayi1 + sayi2;
        //    Console.WriteLine(toplam);
        //}

        //static void Topla(float sayi1, float sayi2)
        //{
        //    float toplam = sayi1 + sayi2;
        //    Console.WriteLine(toplam);
        //}

        #endregion

        #region VİDEO 118 Metot parametrelerinde metot kullanımı

        //static void Main(string[] args)
        //{

        //    /*

        //     Bölüm 12 Metot VİDEO 118 Metot parametrelerinde metot kullanımı

        //    */

        //    /*

        //    bu dersimiz de metot içinde metot kullanımını inceleyeceğiz
        //    bunu daha onceden de gormustuk ama daha detaylı işlemek istiyoruz

        //    Topla adında metot yazdık ve asırı yukleme yaptık 
        //    aynı adı tasıyan metot 3 farklı parametre 

        //    Topla olarak cagırdıgımızda tooltype da gösteriyor bunu

        //    void olarak degil de geriye dönüş tipi olan metot yazdık 

        //    Program class ın da olan metot
        //    Topla metot ismi
        //    geriye int decimal string dönüş tipinde olabilir

        //    verilen veriyi toplayıp geri gönderecek 

        //    baska bir metot tanımı daha yapacagım 
        //    bu metot da kendıne gelen degeri ekranda gösterecek

        //    bunu da object tipinde yazalım degisiklik olsun 
        //    object bütün tipleri alan kabul eden bir veri tipiydi 

        //    normal sartlarda toplama yapıp bunu da ekranda gostermek istersek eger

        //    12M M yazınca decimal olarak anlıyor

        //    debug olarak anlatmak 

        //    Topla metoduyla verileri alıyor gerekli metoda gidiyor işlemleri yapıyor 
        //    12+45=57 i aldı toplam a getirdi 
        //    EkrandaGoster metotunda yazdı oraya gitti ekrana yazdı 
        //    bu uzun olarak yapmak

        //    metot içinde metot kullanınca nasıl kısalıyor işlemler ona bakalım 

        //    decimal toplam = Topla(12M,45M);
        //    EkrandaGoster(toplam);

        //    biz burda ne yaptık topla adında metotda parametre gonderip degiskene atadık basla bir işlem de kullanmadık

        //    decimal toplam degiskenı bellekte bosuna yer kaplıyor

        //    biz ne istiyoruz ekranda gostermek metodu cagıralım 

        //    EkrandaGoster();

        //    metot bizden ne istiyor parametre olarak degerler

        //    EkrandaGoster();

        //    istedigimiz degerleri bu metota parametre olarak yazabiliriz o zaman

        //    EkrandaGoster(Topla(12M,57M));

        //    Topla metotu bir deger gönderdiğinde normalde bir degiskenın uzerıne alıyordu 

        //    artık onun uzerıne almıyor direk diger parametre de işleme giriyor

        //    iç içe metot kullanımı boyle oluyor 

        //    kod okunaklıgını etkiliyorsa iç içe metotları kullanmak iyi bişey degildir

        //    bellekte degisken kalmasın istiyosan en sonunda bellek yonetımı yaparsın 

        //    */

        //    //decimal toplam = Topla(12M,45M);
        //    //EkrandaGoster(toplam);

        //    EkrandaGoster(Topla(12M, 45M));


        //}

        //static void EkrandaGoster(object o)
        //{
        //    Console.WriteLine(o.ToString());
        //}


        //static int Topla(int sayi1, int sayi2)
        //{
        //    int toplam = sayi1 + sayi2;
        //    return toplam;
        //}

        //static decimal Topla(decimal sayi1, decimal sayi2)
        //{
        //    decimal toplam = sayi1 + sayi2;
        //    return toplam;
        //}

        //static string Topla(string metin1, string metin2)
        //{
        //    return metin1 + "" + metin2;
        //}

        #endregion

        #region VİDEO 119 Metot içinde metot tanımlama ( Local function )

        //static void Main(string[] args)
        //{

        //    /*

        //     Bölüm 12 Metot VİDEO 119 Metot içinde metot tanımlama ( Local function )

        //    */

        //    /*

        //    bu özellik .net framework 4.7 ile geldi daha oncesinde bulamazsınız
        //    standart kullanımda bizim metotlarımız vardı
        //    bu metotlarımız bir class ın içerisinde barınıyordu
        //    erişim belirleyicilerimiz vardı public private
        //    biz metotlarımı hep ayrı ayrı tasarlayıp daha sonra metotları birbiri cagırarak kullanmıstık


        //    bu yapıda biz metotların içinde metotlar tanımlayabiliyoruz aslında local function ın görevi bu 
        //    ve o metodun özel metotlar oldugu sadece o metotun ulasabildiği metotlar tanımlayabiliyoruz
        //    main dısında bir metot olusturalım

        //    static kavramını görmek için yeni bir class olusturdum
        //    Deneme119 orda notlar aldım 

        //    normalde class ı cagırıp new yapman lazımdı static olunca gerek kalmadı
        //    direk class ismi üzerinden metota ulasabildik

        //    main dısında bir metot olusturalım


        //    */

        //    Deneme119.Selam();

        //    LocalFunctionKullanimi(12, 22);


        //}

        ///*

        //burda yaptıgımız bir metot hazırlamak statik
        //metot içinde baska bir metot hazırladık 
        //LocalFuntionKullanimi metodunu direk main içinde cagırabiliyoruz ve deger de atayabiliyoruz
        //ama LocalFuntionKullanimi içindeki topla metotuna erişemiyoruz
        //çünkü metotun yasam süresi ilgili scop kadardır
        //LocalFuntionKullanimi içinde istediğimiz kadar bunu cagırabiliriz ama dısında cagıramıyoruz
        //işte buna LocalFuntionKullanimi diyoruz

        //metot içinde bir metot yazınca sadece o metot içinde cagırabiliyoruz kompleksliği azaltıyor

        //mesela bir metot yazılır ama bu metot sadece o metot içinde kullanılıyordur baska bir yerde kullanılmıyordur
        //her yerde gözükse hata alırsın 
        //bunu engellemek için metot içinde metot kullanımı sadece scop içindekini ilgilendirir şeklinde yapmıslar

        //*/

        //static void LocalFunctionKullanimi(int sayi1, int sayi2)
        //{ 
        //    int toplamDeger = topla(sayi1, sayi2);

        //    int topla(int gelenSayi1, int gelenSayi2)
        //    {
        //        return gelenSayi1 + gelenSayi2;
        //    }


        //    Console.WriteLine(toplamDeger);

        //}

        #endregion

    }
}