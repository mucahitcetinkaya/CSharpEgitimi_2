using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace D_12_Metot
{
    internal class Program
    {


        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 105

        //static void Main(string[] args)
        //{
        //    /*

        //    Bölüm 12 Metot VİDEO 105 Main Metotu İnceleme 

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

        #region VİDEO 106 

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 106 C# Nesne yönelimli programlama ( Kısa Giriş )

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


        //                Ogrenci106 O1 = new Ogrenci106();

        //    şimdi O1. dedigimizde içindeki metoda ulasmıs olduk

        //    O1.OgrenciSelamla();

        //    metotu yazarken parantezlere geldiğinde tooltype cıkıyor 
        //    void Ogrenci.OgrenciSelamla() yazıyor
        //    yani parametre almamıs geriye bişey döndürmüyor bilgisini veriyor

        //                Ogrenci106 O1 = new Ogrenci106();

        //    e gelip breakpoint koyup debug edelim

        //    f11 ile devam ediyoruz
        //    nesneyi olusturdu o1. kısmında metotun oldugu yere gitti Ogrenci class ına 
        //    OgrenciSelamla metodunun scoplarına düştü
        //    calıstırdı bitirdi geriye buraya döndü 

        //    */

        //    Ogrenci106 O1 = new Ogrenci106();
        //    O1.OgrenciSelamla();


        //}

        #endregion

        #region VİDEO 107

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 107 Yeni Bir Metot Tanımlamak

        //    */

        //    /*

        //    106. video da sadece Ogrenci class ını olusturup bir tane metot olusturduk
        //    107. video da bunu geliştirelim
        //    detaylarına inelim
        //    nerele ihtiyacımız var 
        //    hangi ihtiyacımızı karsılamak için nasıl bir tanım yapmamız lazım

        //     Ogrenci Class ından devam edelim

        //    Ogrenci class ından geldik
        //    newleme yapmamız lazım

        //    Ogrenci107 O2 = new Ogrenci107();
        //    02.OgrenciMetot( yazınca tooltype ler cıkıyor 
        //    Ogrenci107 clasının içinde bir metot bu
        //    diger tarafta verdiğimiz parametre istemesi void geriye dönüş olmasın vs hepsi orda ornek olarak yazıyor

        //    O2.OgrenciMetot("Mücahit", "Çetinkaya");

        //    sırayla parametreleri verince verilen parametre daha kalın yazıyor

        //    Ogrenci107 e breakpoint bırakalım f11 ile debug yapalım

        //    Ogrenci107 nesnesini new ledi bunun acıklaması class işlerken detaylı yapılacak
        //    O2. uzerınden OgrenciMetot metoduna gidecek giderken parametre götürüyor
        //    f11 ile devam edince Ogrenci107 e geçiyor scoplara düşüyor
        //    oradaki parametrelere bakınca bilgileri tasıdıgını görürürüz
        //    kodu okuyup buraya geri dönüyor

        //    Ogrenci107 deki metotun erişim belirleyicisini private yapalım ne olacak bakalım

        //    OgrenciMetot kısmında hata yazdı 
        //    tekrar O2. yazıp ulasmaya calısalım 
        //    OgrenciMetot gözükmüyor private oldugu için sadece olustugu kısımda kullanılmaya izni var 

        //    private bir metot hazırlayıp aynı class içinde kontrol edelim

        //    Ogrenci107 classına gidelim

        //    Ogrenci107den geldik

        //    OgrenciMetot3 public 
        //    OgrenciMetot2 private
        //    public içinde private metot cagırdık burda da onu tetiklemiş olduk

        //    debug
        //    nesne olustu nesne uzerınden metota gitti metot içindeki kodu calıstırdı
        //    ordada baska nesne var private ama aynı yerdeler onu da ordan calıstırdı
        //    tekrar metot3 e geldi kodu bitirdi buraya geldi tamamen bitirmiş oldu

        //    */

        //    Ogrenci107 O2 = new Ogrenci107();
        //    O2.OgrenciMetot1("Mücahit", "Çetinkaya");


        //    O2.OgrenciMetot3();

        //}

        #endregion

        #region VİDEO 108

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 108 Metot Uygulama - 1 : Matematiksel İşlemler

        //    */

        //    /*

        //    Daha önceden yaptıgımız toplama cıkartma işlemlerini 
        //    class acıp metotlastırarak yapmak istiyorum

        //    bir class acalım Matematik108
        //    gerekli eklemeleri yaptık 

        //    Matematik108 den geldik

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

        //    Matematik108 e dönelim

        //    debug ta yaptık gerekli işleme gidiyor kullanıcıdan deger istiyor işlemi yapıp return ediyor ekrana basıyor vs
        //    */


        //    Matematik108 M1 = new Matematik108();

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

        #region VİDEO 109

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 109 Metot Ödev - 1

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

        //    Ogrenci109 O1 = new Ogrenci109();

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

        #region VİDEO 110

        //static void Main(string[] args)
        //{
        //    /*

        //        Bölüm 12 Metot VİDEO 110 Public ve Private erişim belirleyicileri.

        //    */

        //    /*

        //    Ogrenci110 class ını actık public ve private farklarına bakıyoruz su anda
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

        //    Ogrenci110 O = new Ogrenci110();

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

        #region VİDEO 111

        //static void Main(string[] args)
        //{

        //    /*

        //        Bölüm 12 Metot VİDEO 111 return anahtar kelimesi

        //    */

        //    /*

        //    Metotlarımız bir değer olusturduktan sonra bu değeri onu cagıran noktaya geri gönderebilir
        //    geri gönderme işlemin de return anahtar kelimesini kullanırız
        //    bu return anahtar kelimesi mevcut olan degeri alıyor 
        //    ve metodun dısarısına gönderiyor

        //    Ogrenci11 class ında notlar yazıyor burda herhangi bir işlem yapmaya gerek olmadı
        //    Ogrencı110 dan aldık kodları

        //    */

        //}

        #endregion

        #region VİDEO 112

        //static void Main(string[] args)
        //{

        //    /*

        //        Bölüm 12 Metot VİDEO 112 Parametre alan ve parametre gönderen metotlar

        //    */

        //}

        #endregion

        #region VİDEO 113

        //static void Main(string[] args)
        //{

        //    /*

        //        Bölüm 12 Metot VİDEO 113 Metot parametrelerinde varsayılan değer atama işlemi

        //    */

        //    /*

        //    Ogrenci113 den geldik

        //    not3 ü silince hata veriyor
        //    parametre olarak istiyor ama deger yok içinde ondan dolayı
        //    default olarak deger atamamız gerekiyor
        //    O.OgrenciPuanHesaplama(ad, soyAd, not1, not2);
        //    bu zorunlulugu kaldırmak için Ogrenci113 class ına gidelim 
        //    OgrenciPuanHesaplama da ki zorunlulugu kaldıralım

        //    Ogrenci113 den geldik

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

        //    Ogrenci113 O = new Ogrenci113();

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

        #region VİDEO 114

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 12 Metot VİDEO 114 Parametrelerde ref ve out anahtar sözcüklerinin kullanımı

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

        #region VİDEO 115

        //static void Main(string[] args)
        //{
        //    /*
             
        //    Bölüm 12 Metot VİDEO 115 Değişken sayıda parametre almak ( params kullanımı )
             
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






    }
}
