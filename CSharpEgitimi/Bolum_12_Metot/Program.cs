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



















    }
}
