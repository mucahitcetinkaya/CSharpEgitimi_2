namespace Bolum_07_TemelKonularOperatorKullanimi
{
    internal class Program
    {
        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 45 Bilgilendirme

        //static void Main(string[] args)
        //{

        //}

        #endregion

        #region VİDEO 46 Aritmetiksel Operatörler Toplama

        //static void Main(string[] args)
        //{

        //    /* int +int(int verir) */

        //    int s1 = 10;
        //    int s2 = 15;
        //    int toplamInt = s1 + s2;

        //    /*
        //     burada s1 s2 değişken tipine bakıyor int görüyor
        //     ikiside int oldugundan + operatörü toplama işlemi yapıp
        //     toplamInt üzerine alır

        //    */

        //    /* byte +byte(int verir) */
        //    byte s3 = 10;
        //    byte s4 = 10;
        //    byte toplamByte1 = s3 + s4;

        //    /*
        //     burada en sonda byte verirsek hata veriyor program
        //     sebebi byte aralıgı düşük byte ı geçme ihtimali var
        //     1 ile 10 da olabilir 255 ile 1 de olabilir 255 i geçme ihtimali var
        //     sen oraya int ver diyor
        //     aynısını int e cevirirsek hata vermiyor
        //    */

        //    byte s5 = 10;
        //    byte s6 = 10;
        //    int toplamByte2 = s5 + s6;
        //    /* int yapınca hata vermiyor var da yazabiliriz int oldugunu anlar */

        //    /* string +int(string verir) */

        //    string metin1 = "Merhaba";
        //    int s7 = 10;
        //    string toplamString1 = metin1 + s5; /* değişken adı direk yazılır */

        //    /*
        //     bunun cıktısı Merhaba 10 olarak olur yanına birleştirme yapar
        //     ben merhaba ile 10 u toplayamam birleştirme yapayım diyor
        //     int +string(string verir)
        //    */

        //    string toplamString2 = s5 + metin1;

        //    /* 
        //     bunun cıktısı 10Merhaba olarak olur yanına birleştirme yapar
        //     string +string(string verir)
        //    */

        //    string metin2 = "Dünya";
        //    string toplamString3 = metin1 + metin2;

        //    /* bunun cıktısı MMerhabaDünya olarak olur yanına birleştirme yapar */

        //}

        #endregion

        #region VİDEO 47 Aritmetiksel Operatörler Çıkartma

        //static void Main(string[] args)
        //{
        //    /* int - int(int verir) */

        //    int s1 = 100;
        //    int s2 = 50;
        //    int cıkarmaInt1 = s1 - s2;

        //    /* byte - byte(int verir) */

        //    byte b1 = 100;
        //    byte b2 = 50;
        //    byte cıkartmaByte1 = b1 - b2;

        //    /*
        //     yazamayız burada b1 büyük ama b2 kucuk sayı yani
        //     sonuc negatifte olabilir ondan dolayı
        //    */

        //    /* byte - byte için sonucunda int veya var dememiz lazım */
        //    int cıkarmaInt2 = b1 - b2;
        //    var cıkarmaInt3 = b1 - b2;
        //}

        #endregion

        #region  VİDEO 48 Aritmetiksel Operatörler Çarpma

        //static void Main(string[] args)
        //{
        //    /* double * double(double verir) */

        //    double d1 = 10.4;
        //    double d2 = 10.6;
        //    double dCarpma1 = d1 * d2;



        //    /* double * double sonucunu int e alsak ne olurdu ? */

        //    int intCarpma1 = d1 * d1; /* hata veriyor */

        //    /*
        //     hata vermesinin sebebi
        //     double aralıgı int aralıgından büyük oldugu için
        //     double değeride büyük veya kucuk olabilir
        //     double değerini int a alamam diyor
        //     peki
        //     burada bilinçsiz tür dönüşümü aklımıza gelse
        //     verilen değerleri ben biliyorum sen cevir demek için
        //    */



        //    /* basına(int) yazsak o zaman ne olur ? */

        //    int intCarpma2 = (int)d1 * d1; /* yine hata veriyor */

        //    /*
        //     peki biz bunu nasıl yapacağız neden hata veriyor
        //     büyük tip küçük tipe dönüşebilir
        //     d1* d2 i parantez içine alırsak izin verecek
        //    */


        //    int intCarpma3 = (int)(d1 * d1);

        //    /*
        //     hata vermiyor
        //     neden hata vermedi? sebebi
        //     biz d1 ile d2 i carptıgımızda bize double verecek
        //     bunu hepimiz biliyoruz
        //     bizde paranteze alırken parantez içindeki değere bakıyor
        //     cıkan sonucun ben int oldugunu kabul ediyoruz demiş oluyoruz
        //     int a cevir demiş oluyoruz
        //     yani carpmamın sonucunu int e cevir diyoruz
        //     işlem önceliği gibi carptıktan sonra cevir diyoruz
        //    */

        //    /* bu işlemin kısa hali sadece kod tarafı */

        //    double d3 = 10.4;
        //    double d4 = 10.6;
        //    double dCarpma4 = d3 * d4;
        //    int intCarpma5 = d3 * d4; /* hata veriyor */
        //    int intCarpma6 = (int)d3 * d4; /* yine hata veriyor */
        //    int intCarpma7 = (int)(d3 * d4);

        //    /* bu işlemin uzun hali */

        //    /*
        //     once işlemi yap double üstüne al sonra
        //     cıkan sonucu bilinçsiz dönüşüm ile int e cevir
        //    */
        //    double d5 = 10.4;
        //    double d6 = 10.6;
        //    double sonucDouble = d5 * d6; /* burada sonuc 110.24 olur */
        //    int sonucInt11 = (int)sonucDouble; /* 110.24 ü int e attıgında sonuc 110 olur */

        //    /* int tam sayıları tutar yuvarlama yapıyor */
        //}

        #endregion

        #region VİDEO 49 Aritmetiksel Operatörler Bölme

        //static void Main(string[] args)
        //{

        //    /* / simgesi kullanılır */

        //    int s1 = 10;
        //    int s2 = 2;
        //    int sonuc = s1 / s2;

        //    /* peki ben s1 deki 10 değerini 0 a bölmek istesem sonuc ne olur */

        //    int s3 = 0;
        //    int sonuc1 = s1 / s3;

        //    /*
        //     burada System.DivideByZeroException hatası veriyor
        //     bölen 0 olamaz diyor
        //    */
        //}

        #endregion

        #region VİDEO 50 Özel Operatörler

        //static void Main(string[] args)
        //{
        //    /* MOD ALMA YÜZDE İŞARETİ % */

        //    int s1 = 10;
        //    int s2 = 2;
        //    int sonucMod = s1 % s2;

        //    /*
        //     s1 in modu s2 ye göre nedir
        //     10 değerini ben 2 ye bölünmeyene kadar yani kalan değerin 2 den küçük olana kadar
        //     böldüğünde kalan nedir 
        //     10 un 2 e bölümünden kalan 0 dır
        //     sonuc sıfır cıkar tam bölünür
        //     9 un 2 e modu 1 dir mesela kalan 1 yani
        //    */

        //    /* ++ OPERATÖRÜ 1 ARTTIRMAK İÇİN KULLANILIR */

        //    /* + nın yerine göre davranısı değişiyor SAGDA MI SOLDA MI */

        //    int s3 = 10;
        //    /* BURADA s3 DEĞER 10 OKUYOR */
        //    int operatorSonuc1; s3++;

        //    /*
        //     s3 ü 10 okudugunda
        //     S3 Ü OKURKEN operatorSonuc1 DEĞERİ 0 OKUYOR
        //     S3 Ü OKURKEN s3++ DA 10 OKUYOR
        //     s3++ yı OKUDUDUNDA
        //     s3 VE s3++ 11 oldu 1 arttırdı
        //     operatorSonuc1 10 olarak kaldı
        //     EĞER ++ SAĞ TARAFTAYSA
        //     ONCE DEĞERİ OKUYOR operatorSonuc1 üzerine ATAMASINI YAPIYOR
        //     SONRA 1 ARTTIRIYOR
        //     operatorSonuc1 in 10 kalma sebebi bu
        //    */

        //    int operatorSonuc2; ++s3;

        //    /*
        //     s3 ü 10 okudugunda
        //     S3 Ü OKURKEN operatorSonuc1 DEĞERİ 0 OKUYOR
        //     ++s3 10 değeri okuyor
        //     ++s3 okudugu zaman
        //     s3 s3++ operatorSonuc2 hepsi 11 oluyor
        //     EĞER ++ SOL TARAFTAYSA
        //     ONCE DEĞERİ 1 ARTTIYOR SONRA ARTTILAN DEĞERİ
        //     operatorSonuc2 üstüne ATAMA YAPIYOR
        //     operatorSonuc2 nin de 11 olma sebebi bu

        //     NOT : bizim burda yapmak istediğimiz olay nedir
        //     int tipinde s3 değişken adına 10 değerini atamak
        //     s3 değerini alıp 
        //     int tipinde s3++ ile bir arttırıp
        //     int tipindeki operatorSonuc1 e atamak
        //     işte burda ++ nın önce sonra olması
        //     operatorSonuc1 ve 2 nin değerinin değişip değişmemesini sağlıyor
        //    */

        //    /* peki böyle bir durum da ne olurdu ? */
        //    int operatorSonuc3 = (s3++);

        //    /*
        //     operatorSonuc3 10 olur
        //     s3 ve s3++ 11 olur
        //     parantezli ve parantezsiz aynı davranış

        //     ++ operatörü özel bir operatör olarak geçer
        //     mesela ++ yerine +2 yazsak int int oldugu için toplama yapacak
        //     ++ operatörünün uzun hali nedir
        //     int operatorSonuc4 = s3 + 1; dir
        //     kısa hali ++ dır
        //    */


        //    /* -- OPERATÖRÜ 1 EKSİLTMEK İÇİN KULLANILIR */

        //    /* + nın yerine göre davranısı değişiyor SAGDA MI SOLDA MI */

        //    /* -- operatörüde ++ operatörü gibi kurallı aynı */

        //    int s4 = 10;
        //    int operatorSonuc5 = (s4--);
        //    int operatorSonuc6 = (--s4);

        //}

        #endregion

        #region VİDEO 51 Aritmatiksel Operatörler Alıştırma 1

        //static void Main(string[] args)
        //{
        //    /*


        //     VIDEO 50 Aritmatiksel Operatörler - Alıştırma 

        //     İSTENİLEN

        //     Merhaba 

        //     Adınız : 
        //     Soyadınız : 
        //     Doğum yılınız : 

        //     Ekranı Temizle

        //     Ekranda

        //     Merhaba Mücahit Çetinkaya ... yaşındasınız.

        //     yazacak

        //    */

        //    /* BENİM YAPTIĞIM */

        //    Console.WriteLine("Merhaba");
        //    Console.Write("Adınız : ");
        //    string ad1 = Console.ReadLine();
        //    Console.Write("Soyadınız : ");
        //    string soyAd1 = Console.ReadLine();
        //    Console.Write("Doğum Yılınız : ");
        //    int dogumTarihi1 = Convert.ToInt32(Console.ReadLine());

        //    int yas1 = DateTime.Now.Year - dogumTarihi1;

        //    Console.Clear();

        //    Console.WriteLine("Merhaba" + " " + ad1 + " " + soyAd1 + " " + yas1 + " " + "yaşındasınız.");




        //    /* HOCANIN YAPTIĞI */

        //    Console.WriteLine("Merhaba ,");

        //    Console.Write("Adınız : ");
        //    string ad = Console.ReadLine();

        //    Console.Write("Soyadınız : ");
        //    string soyAd = Console.ReadLine();

        //    Console.Write("Doğum Yılınız : ");
        //    string dogumYili = Console.ReadLine();

        //    Console.Clear();

        //    int yil = Convert.ToInt32(dogumYili);

        //    /*
        //     karar yapılarına geldiğimizde girilen değerin 0 veya x bir değer
        //     olup olmadıgını kontrol edeceğiz
        //     daha oraya gelmedik ekleme yapmıyorum
        //    */

        //     int mevcutYil2 = 2023; /* burada yıla göre hesaplama yaptık */
        //     int yas2 = mevcutYil2 - yil;

        //    /*
        //     2023 yılında calısır ama zaman geçiyor
        //     DateTime.Now.Year; ile yapmamız lazım
        //    */

        //    int mevcutYil3 = DateTime.Now.Year; /* YAPAMADIGIM KISIM BURASI .YEAR YAZMAYI UNUTMUSUM */
        //    int yas3 = mevcutYil3 - yil;

        //    /* BURADA DEDİĞİMİZ OLAY BUGUNUN ZAMANINI VE YILINI GETİR mevcutYil a ata */


        //    string mesaj = "Merhaba " + ad + " " + soyAd + " " + yas3 + " yaşındasınız... ";
        //    Console.WriteLine(mesaj);
        //    Console.ReadLine();

        //    /*
        //     string mesajda parantezlere gerek yok 
        //     çift tırnak arası ifade direk yazılır oldugu gibi
        //     metinsel de yazsan rakamsalda yazsan
        //     simge işaret boslukta koysan çift tırnak içinde oldugu gibi yazar
        //     çift tırnak içindeki bir ifade metinsel oldugu için 
        //     aritmetik işlem yapılmaz.
        //     komut oldugunu belirtmek için ters slash kullanılır \ ALT GR + SİMGE TUŞU
        //     alt satıra geçmek için \n kullanılır
        //    */

        //}

        #endregion

        #region VİDEO 52 Aritmatiksel Operatörler Alıştırma 2

        //static void Main(string[] args)
        //{
        //    /*

        //     VİDEO 51 Aritmatiksel Operatörler - Alıştırma


        //     EKRANA 2 ADET SAYI GİRİLECEK

        //     SAYI DOUBLE VEYA DECİMAL A CEVİRİLECEK

        //     SONRA SAYI 1 İLE SAYI 2 Yİ

        //     TOPLA CIKAR BÖL CARP MODUNU AL 

        //    */

        //    /* BENİM YAPTIĞIM */


        //    Console.Write("1. Sayıyı giriniz : ");
        //    double sayiDouble = Convert.ToDouble(Console.ReadLine());


        //    Console.Write("2. Sayıyı giriniz : ");
        //    decimal sayiDecimal = Convert.ToDecimal(Console.ReadLine());

        //    int topla = (int)sayiDouble + (int)sayiDecimal;
        //    int cikart = (int)sayiDouble - (int)sayiDecimal;
        //    int carp = (int)sayiDouble * (int)sayiDecimal;
        //    int bol = (int)sayiDouble / (int)sayiDecimal;
        //    int mod = (int)sayiDouble % (int)sayiDecimal;

        //    Console.WriteLine("+ : " + topla);
        //    Console.WriteLine("- : " + cikart);
        //    Console.WriteLine("* : " + carp);
        //    Console.WriteLine("/ : " + bol);
        //    Console.WriteLine("% : " + mod);



        //    /* HOCANIN YAPTIGI */


        //    Console.Write("Sayı 1 Değerini Giriniz : ");
        //    string sayi5 = Console.ReadLine();

        //    Console.Write("Sayı 2 Değerini Giriniz : ");
        //    string sayi6 = Console.ReadLine();

        //    decimal d1 = Convert.ToDecimal(sayi5);
        //    decimal d2 = Convert.ToDecimal(sayi6);

        //    decimal sonucTopla = d1 + d2;
        //    decimal sonucCikart = d1 - d2;
        //    decimal sonucCarp = d1 * d2;
        //    decimal sonucBol = d1 / d2;
        //    decimal sonucMod = d1 % d2;

        //    Console.WriteLine("+ : " + sonucTopla);
        //    Console.WriteLine("- : " + sonucCikart);
        //    Console.WriteLine("* : " + sonucCarp);
        //    Console.WriteLine("/ : " + sonucBol);
        //    Console.WriteLine("% : " + sonucMod);

        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 53 54 55 56 57 Aritmatiksel Operatörler Büyüktür Küçüktür Eşittir Eşit Değildir Büyük Eşit Küçük Eşit

        //static void Main(string[] args)
        //{
        //    /* VİDEO 53 Karşılaştırma Operatörleri - Büyüktür */


        //    /* BÜYÜK MÜ KARSILAŞTIRMASI > İŞARETİ KULLANILIR */

        //    /*
        //     KARSILAŞTIRMANIN GENEL YAZIMINA BAKARSAK
        //     bool tipinden değer döner KARSILASTIRMA OPERATÖRÜ
        //     bool tip değişken 2 deger alır true ve false değeri yoksa false döner

        //     bool donusDeger = degisken1 > degisken 2;
        //     degisken1 ve 2 nin içindeki değere bakıyor
        //     mesela degisken1 degisken2 den kucuk olsun
        //     bool bize false döner buyukse eger true donuyor
        //    */

        //    int s1 = 100;
        //    int s2 = 150;

        //    bool sonucBuyuk = s1 > s2;
        //    Console.WriteLine(sonucBuyuk);

        //    /*
        //     burada bool s1 ve s2 nin içindeki değere bakıyor
        //     bu durumda false veriyor
        //     eğer tam tersi s2>s1 olsa true verirdi
        //     eşit olsa yine false verir
        //    */



        //    /* VİDEO 54 Karşılaştırma Operatörleri - Küçüktür */

        //    /* KÜÇÜKTÜR KARŞILAŞTIRMASI < İŞARETİ İLE KULLANILIR */

        //    int s3 = 150;
        //    int s4 = 100;
        //    bool sonucKucuk = s3 < s4;

        //    /*
        //     s3 kucuk s4 den diyor
        //     bu durumda s3 buyuk s4 oldugundan sonuc false verir
        //     eşit olursa eğer yine false verir
        //    */

        //    /*
        //     EŞİTTİR TEK BASINA KULLANILDIGINDA ATAMA OPERATÖRÜ OLARAK KULLANILIR 
        //     ATAMA OPERATÖRÜ = İLE KULLANILIR
        //     degisken = atanacakDeger şeklinde olur
        //     örnek decimal d1 = 10.90M; gibi
        //    */



        //    /* VİDEO 55 Karşılaştırma Operatörleri - Eşit ve Eşit Değildir */

        //    /*
        //     EŞİT VEYA EŞİT DEĞİLDİR KARŞILAŞTIRMASI 
        //     EŞİT Mİ            ==     İLE GÖSTERİLİR
        //     EŞİT DEĞİL Mİ      !=     İLE GÖSTERİLİR
        //     bool tipinden değer döner KARSILASTIRMA OPERATÖRÜ
        //    */

        //    int s5 = 100;
        //    int s6 = 100;
        //    bool esitKontrol1 = s5 == s6; /* eşitse eğer true alıyoruz */
        //    bool esitKontrol2 = s5 != s6; /* eşitse eğer false alır */



        //    /* VİDEO 56 Karşılaştırma Operatörleri - Büyük Eşittir */

        //    /* BÜYÜK EŞİT Mİ KARŞILAŞTIRMASI >= İŞARETİ İLE KULLANILIR */

        //    /*
        //     bool tipinden değer döner KARSILASTIRMA OPERATÖRÜ
        //     UYGULAMA BURADA İKİ ADET DEĞERE BAKIYOR
        //     EŞİT VEYA BUYUK MU
        //     DEĞİŞKEN İÇERİSİNDEKİ DEĞERLERE
        //     ONCE BUYUK MU DİYE BAKIYOR BUYUKSE TRUE DİYOR
        //     SONRA EŞİT Mİ DİYE BAKIYOR EŞİTSE TRUE DİYOR
        //     BAKTIGINDA BUYUK AMA EŞİTSE DEĞİLSE TRUE DER
        //     BAKTIGINDA BUYUK DEĞİL AMA EŞİTSE TRUE DER 
        //     BAKTIGINDA BUYUK VEYA EŞİT DEĞİLSE FALSE DER
        //    */

        //    int s7 = 100;
        //    int s8 = 100;
        //    bool buyukEsitSonuc = s7 >= s8;



        //    /* VİDEO 57 Karşılaştırma Operatörleri - Küçük Eşittir */

        //    /* KUCUK EŞİT Mİ KARŞILAŞTIRMASI <= İŞARETİ İLE KULLANILIR */

        //    /*
        //     bool tipinden değer döner KARSILASTIRMA OPERATÖRÜ
        //     ONCE KUCUK MU DİYE BAKAR KUCUKSE TRUE
        //     KUCUK DEĞİLSE EŞİT Mİ EŞİTSE TRUE
        //     KUCUK DEĞİL AMA EŞİTSE TRUE
        //     KUCUK AMA EŞİT DEĞİLSE TRUE
        //     KUCUK VEYA EŞİT DEĞİLSE FALSE
        //    */

        //    int s9 = 100;
        //    int s10 = 100;
        //    bool kucukEsitSonuc = s9 <= s10;
        //}

        #endregion

        #region VİDEO 58 59 Is As Operatörü Kullanımı

        //static void Main(string[] args)
        //{

        //    /* 57 Is operatörü kullanımı */

        //    int s1 = 50;
        //    int s2 = 100;

        //    /* object o1 = ..... buraya ne atasam object bunu kabul edecek s1 de bool değişken adını da atasam object kabul edecek */

        //    object o1 = s1;
        //    /*
        //     object içindeki değeri ben ekrana yazdırırsam içindeki değeri
        //     string olarak görürüm bunun nedeni object içindeki komuttan dolayı oluyor
        //     bunu class lar dersinde göreceğiz
        //    */

        //    Console.WriteLine(o1); /* dediğimde ekranda görürüz */

        //    /*
        //     peki ben o1 in içindeki değeri tekrardan nasıl int e dönüştürürüm
        //     buyuk tip kucuk tipe dönüşecek
        //     bilinçsiz dönüşüm yapılır
        //     (int).o1;
        //    */

        //    s1 = (int)o1; /* konsola yazdı int e dönüştürdü */


        //    /* peki burası int değil de byte a cevirseydik nolurdu */

        //    /*
        //     s1 = (byte)o1;

        //     object değeri 50 normalde byte olabilir ama burda hata veriyor
        //     sebebi object değerin yanında değerin tipinide kendi içinde barındırıyor
        //     object te kutulama demiştik kutudan cıkartırken kutuladıgımız tip olarak cıkar
        //     en basta object int olarak işleme aldık değer o1 de int oldu ondan dolayı
        //     peki ben uygulamada değerin kutulanırken bunun int mi byte mı
        //     hangi tipte kutulandıgını nerden öğreneceğim
        //    */

        //    /* burada is operatörü bize yardımcı olacak */



        //    /*
        //     IS OPERATÖRÜ 
        //     bool tipinde değer döner
        //     bool donenDeger = degisken is degiskenTipi
        //    */

        //    bool isKontrol1 = o1 is int;

        //    /*
        //     yani burada bir soru soruyoruz bunun tipi bumu dur
        //     uygulama burada değişken değerine bakmaz değişken tipine bakar
        //     o1 in değeri nerden geldi s1 den s1 nedir int o zaman o1 de int dir.
        //     o1 int a cevrilebilir mi
        //     o1 bir onceki gelişinde bize int mi geldi
        //     burada is bize true veriyor
        //    */

        //    bool isKontrol2 = o1 is byte;

        //    /*
        //     o1 bir onceki gelişinde bize byte mi geldi
        //     burada is bize false veriyor yani byte dan gelmedi diyor
        //    */




        //    /* 58 As operatörü kullanımı */

        //    /* !!!!!!!!!!!!!!!!!!!!!! string olarak gönderir !!!!!!!!!!!!!!!!!!!!!!!!!!! */


        //    string isimSoyisim = "Mücahit Çetinkaya";
        //    object objString = isimSoyisim;
        //    string sonucStr = objString as string;

        //    /*
        //     burada uygulama davranısı
        //     once string tipinde isimSoyisim adında bir değişken oluşturur
        //     ve içerisine Mücahit Çetinkaya değerini atayacak
        //     atadıktan sonra
        //     object tipinde objString adında bir değişken oluşturacak
        //     içerisine de isimSoyisim değişkenini tipiyle birlikte aktaracak
        //     yani bir kutulama yapıyor
        //     daha sonra objString değeri eğer string ise
        //     olusturdugumuz farklı bir string tipinde sonucStr adına string olarak atayacak
        //    */
        //}

        #endregion

        #region VİDEO 60 Alıştırma 1

        //static void Main(string[] args)
        //{

        //    /*

        //     KULLANICI 3 NOT GİRECEK
        //     3 NOTUN ORTALAMASI
        //     45 DEN BÜYÜK MÜ KÜÇÜK MÜ

        //    */

        //    /* BENİM YAPTIGIM */

        //    /*
        //     Console.WriteLine("Hoşgeldiniz");

        //     Console.Write("1. notu giriniz : ");
        //     int not1 = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("2. notu giriniz : ");
        //     int not2 = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("3. notu giriniz : ");
        //     int not3 = Convert.ToInt32(Console.ReadLine());

        //     int toplam = not1 + not2 + not3;
        //     int ortalama = toplam / 3;
        //     bool result = ortalama > 45;

        //     Console.Clear();

        //     Console.WriteLine($"1. not {not1} 2. not {not2} 3. not {not3} toplamı {toplam} ortalaması {ortalama} 45 den büyük mü {result}");

        //     Console.ReadLine();
        //    */



        //    /* BENİM YAPTIGIM */

        //    /*
        //     Console.WriteLine("HOŞ GELDİNİZ");

        //     Console.Write("1. NOTU GİRİNİZ : ");
        //     string sayi1 = Console.ReadLine();

        //     Console.Write("2. NOTU GİRİNİZ : ");
        //     string sayi2 = Console.ReadLine();

        //     Console.Write("3. NOTU GİRİNİZ : ");
        //     string sayi3 = Console.ReadLine();

        //     int int1 = Convert.ToInt32(sayi1);
        //     int int2 = Convert.ToInt32(sayi2);
        //     int int3 = Convert.ToInt32(sayi3);

        //     int toplam = int1 + int2 + int3;
        //     Console.WriteLine("Toplam          : " + toplam);
        //     int ortalama = toplam / 3;
        //     Console.WriteLine("Ortalama        : " + ortalama);

        //     int endusuknot = 45;
        //     bool sonuc = ortalama >= endusuknot ;
        //     Console.WriteLine("Sınav Sonucu    : " + sonuc);
        //     Console.ReadLine();
        //    */




        //    /*  HOCANIN YAPTIGI */

        //    /*
        //     BENİM HATAM İNT GİRMEK VİRGÜLLÜ SAYI OLABİLİR DECİMAL VEYA DOUBLE GİRMEM LAZIMDI
        //     BEN UZUN YOLU SEÇMİŞİM
        //    */

        //    Console.WriteLine("HOŞ GELDİNİZ");

        //    Console.Write("NOT 1 DEĞERİNİ GİRİNİZ : ");
        //    string not1 = Console.ReadLine();

        //    Console.Write("NOT 2 DEĞERİNİ GİRİNİZ : ");
        //    string not2 = Console.ReadLine();

        //    Console.Write("NOT 3 DEĞERİNİ GİRİNİZ : ");
        //    string not3 = Console.ReadLine();

        //    Console.WriteLine("Değerleriniz alındı hesaplama işlemi yapılıyor... ");

        //    decimal dnot1 = Convert.ToDecimal(not1);
        //    decimal dnot2 = Convert.ToDecimal(not2);
        //    decimal dnot3 = Convert.ToDecimal(not3);

        //    /*
        //     ORTALAMA ALMA UZUN YOL
        //     TOPLAYIP AYRI ORTALAMA ALIYOR
        //     decimal toplam = dnot1 + dnot2 + dnot3 ;
        //     decimal ortalama = toplam / 3;

        //     ORTALAMA ALMA KISA YOL
        //     ONCE PARANTEZ İÇİ YAPIP SONRA ORTALAMA ALIYOR
        //    */
        //    decimal ortalama = (dnot1 + dnot2 + dnot3) / 3;

        //    bool kontrolSonuc = ortalama >= 45;
        //    Console.WriteLine("Ortalama değeriniz 45 değerinden büyük veya eşit mi ?" + kontrolSonuc);

        //    /*
        //     NOT SONUCTA SADECE 45 DEN BUYUK VEYA ESİTSE TRUE DEĞİLSE FALSE YAZIYOR SU ANLIK
        //     İLERİDE FARKLI MESAJLAR YAZMASINI GÖSTERECEĞİZ
        //    */

        //}

        #endregion

        #region VİDEO 61 Alıştırma 2

        //static void Main(string[] args)
        //{

        //    /*

        //     KULLANICI ADI : admin
        //     şifre : 123

        //     KULLANICIDAN 
        //     kullanıcı adı şifre isteyecek
        //     kullanıcı admin mi 
        //     şifre 123 mü diye bakacak

        //    */

        //    /* BENİM YAPTIGIM */

        //    /*
        //     Console.Write("Kullanıcı adınızı giriniz : ");
        //     string kulAdi = Console.ReadLine();
        //     Console.Write("Şifrenizi giriniz : ");
        //     int sifre = Convert.ToInt32(Console.ReadLine());
        //     bool sifreKont = sifre == 123;

        //     Console.Write($"Şifreniz {sifreKont} ");

        //     Console.ReadLine();
        //    */

        //    /* BENİM YAPTIGIM */

        //    /*
        //     string admin = "admin";
        //     string password1 = "123";

        //     Console.WriteLine("Hoş geldiniz...");

        //     Console.Write("Kullanıcı adınızı giriniz : ");
        //     string a1 = Console.ReadLine();

        //     Console.Write("Şifrenizi giriniz: ");
        //     string s1 = Console.ReadLine();

        //     int password2 = Convert.ToInt32(password1);
        //     int password3 = Convert.ToInt32(s1);

        //     bool kaa = admin == a1;
        //     bool kas = password2 == password3;

        //     Console.WriteLine("Kullanıcı adınız : " + kaa + "dur." + "\n" + "Şifreniz : " + kas + "dur.");

        //     bool kaa1 = admin != a1;
        //     bool kas1 = password2 != password3;

        //     Console.WriteLine("Kullanıcı adınız : " + kaa1 + "dur." + "\n" + "Şifreniz : " + kas1 + "dur.");
        //    */



        //    /* HOCANIN YAPTIĞI */


        //     Console.Write("Kullanıcı adınızı giriniz : ");
        //     string kullaniciAdi = Console.ReadLine();

        //     Console.Write("Şifrenizi giriniz : ");
        //     string sifre = Console.ReadLine();

        //     bool kullaniciAdiKontrol1 = kullaniciAdi == "admin";
        //     bool kullaniciAdiKontrol2 = kullaniciAdi != "admin";

        //     bool sifreKontrol1 = sifre == "123";
        //     bool sifreKontrol2 = sifre != "123";

        //     Console.ReadLine();

        //}

        #endregion

        #region VİDEO 62 63 Mantıksal Operatörler Ve Veya Operatörü

        //static void Main(string[] args)
        //{


        //    /* MANTIKSAL VE OPERATÖRÜ && SİMGESİ İLE KULLANILIR */
        //    /* MANTIKSAL VEYA OPERATÖRÜ || SİMGESİ İLE KULLANILIR */


        //    /* VİDEO 62 Mantıksal Operatörler - Ve operatörü && SİMGESİ İLE KULLANILIR */


        //    /*
        //     istediğiniz kadar and operatörü eklenebilir
        //     geriye bool döner
        //     bool donenDeger = degisken1 == "admin" && degisken2 == "123" TRUE
        //     acıklaması
        //     degisken1 && (ve) degisken2
        //     degisken1 admin e eşit mi evet
        //     degisken2 123 e eşit mi evet
        //     o zaman sonuc TRUE dur 
        //    */

        //    /*
        //     * degisken1        degisken2       sonuc
        //     * True             True            True
        //     * False            True            False
        //     * True             False           False
        //     * False            False           False
        //     * 
        //    */

        //    /*
        //     yukarıdaki tabloda oldugu gibi bütün sartlar true ise bize true alıyoruz
        //     kaç değer olursa hepsinin true olması lazım
        //    */


        //    string kullaniciAdi = "admin";
        //    string sifre = "123";
        //    string anahtar1 = "1";

        //    bool donenDeger = kullaniciAdi == "admin" && sifre == "123" && anahtar1 == "1";





        //    /* VİDEO 63 Mantıksal Operatörler - Veya Operatörü || (altgr+simgesi) SİMGESİ İLE KULLANILIR */
        
        
        
        //    /* 
        //     geriye bool döner            
        //     ve operatöründe n tane sartın varsa true için hepsinin dogru olması lazım
        //     veya operatöründe n tane şarttan 1 tanesi dogru ise true alabilirsin 
        //    */

        //    /*
        //     * şart1     şart2       sonuc
        //     * T         T           T
        //     * T         F           T
        //     * F         T           T
        //     * F         F           F
        //    */

        //    /*
        //     YANİ TEK BİR TANESİ DOGRU OLSA BİLE DOGRUDUR
        //     YANLIS İÇİN HEPSİ YANLIS OLMASI LAZIM
        //     ornek elimizde bir tane anahtar olsun ve bu anahtarı kullanarak sisteme giriş yapmak istiyoruz
        //     sistemde de 4 adet anahtar değeri olsun
        //    */

        //    string anahtar2 = "ASDASJLFGS123123";
        //    bool geriDonus = anahtar2 == "ASDASJLFGS123123" || anahtar2 == "asd23errfr" || anahtar2 == "şflghk45tg" || anahtar2 == "345ry456tg";

        //    /*
        //     burada anahtar ilk değerden bakıyor sırayla 1 tanesi dogru ise diğerlerine bakmıyor
        //     dogruyu bulursa true der
        //     hiç bir anahtar uymuyorsa false verir

        //     biz bunu nerede kullanırız
        //     datebase tarafından veri tabanından veri liste çekilmiştir 
        //     listede bu değer var mı diye bakılmada kullanılabilir

        //     karar yapılarında (if else if) bu operatörler cok kullanılır (ve veya)
        //    */
        //}

        #endregion

    }
}