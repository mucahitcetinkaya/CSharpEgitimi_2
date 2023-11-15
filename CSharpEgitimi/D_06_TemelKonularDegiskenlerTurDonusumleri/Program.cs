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
        //static void Main(string[] args)
        //{
        //    string isimSoyisim1 = "Mücahit Çetinkaya1";
        //    Console.WriteLine(isimSoyisim1);


        //    isimSoyisim1 = "Muhammet Çetinkaya2";
        //    Console.WriteLine(isimSoyisim1);

        //    /* büyük karakter küçük karakter */

        //    string isimSoyisim2 = "Mücahit Çetinkaya3";
        //    string buyukKarakter1 = isimSoyisim2.ToUpper();
        //    string kucukkKarakter1 = isimSoyisim2.ToLower();
        //    Console.WriteLine(buyukKarakter1);
        //    Console.WriteLine(kucukkKarakter1);

        //    /* belirli bir bölümü vermiş oldugum kısımı console a yazdırır */

        //    /* Substring */

        //    string isimSoyisim3 = "Mü4444t Çetinkaya4";
        //    string belirliBirBolum1 = isimSoyisim3.Substring(2, 4);
        //    Console.WriteLine(belirliBirBolum1);


        //    string isimSoyisim4 = "Mü5555t Çetinkaya5";
        //    string buyukKarakter2 = isimSoyisim4.ToUpper();
        //    Console.WriteLine(buyukKarakter2);
        //    string kucukkKarakter2 = isimSoyisim4.ToLower();
        //    Console.WriteLine(kucukkKarakter2);
        //    string belirliBirBolum2 = isimSoyisim4.Substring(2, 4);
        //    Console.WriteLine(belirliBirBolum2);
        //    Console.ReadLine();
        //}
        #endregion

        #region VİDEO 27
        //static void Main(string[] args)
        //{
        //    string kullaniciSecimString = "A";
        //    Console.WriteLine(kullaniciSecimString);
        //    char kullaniciSecimChar = 'A';
        //    Console.WriteLine(kullaniciSecimChar);
        //    Console.ReadLine();
        //}
        #endregion

        #region VİDEO 28
        //static void Main(string[] args)
        //{
        //    byte deger1 = 10;
        //    int deger2 = 100;


        //    byte byteMinVal = byte.MinValue;
        //    byte byteMaxVal = byte.MaxValue;

        //    int intMinVal = int.MinValue;
        //    int intMaxVal = int.MaxValue;

        //    Console.WriteLine(byteMinVal);
        //    Console.WriteLine(byteMaxVal);
        //    Console.WriteLine(intMinVal);
        //    Console.WriteLine(intMaxVal);

        //    Console.ReadLine();
        //}
        #endregion

        #region VİDEO 29
        //static void Main(string[] args)
        //{

        //    double doubleVal1 = 10.2;
        //    double doubleVal2 = 10;
        //    double doubleVal3 = 10.9d;

        //    double doubleMinVal = double.MinValue;
        //    double doubleMaxVal = double.MaxValue;

        //    decimal decimalVal1 = 10.2M;

        //    decimal decimalMinVal = decimal.MinValue;
        //    decimal decimalMaxVal = decimal.MaxValue;

        //    float floatVal1 = 10.2F;

        //    float floatMinVal = float.MinValue;
        //    float floatMaxVal = float.MaxValue;

        //    Console.WriteLine(doubleVal1);
        //    Console.WriteLine(doubleVal2);
        //    Console.WriteLine(doubleVal3);
        //    Console.WriteLine(doubleMinVal);
        //    Console.WriteLine(doubleMaxVal);
        //    Console.WriteLine(decimalVal1);
        //    Console.WriteLine(decimalMinVal);
        //    Console.WriteLine(decimalMaxVal);
        //    Console.WriteLine(floatVal1);
        //    Console.WriteLine(floatMinVal);
        //    Console.WriteLine(floatMaxVal);
        //    Console.ReadLine();
        //}
        #endregion

        #region VİDEO 30
        //static void Main(string[] args)
        //{

        //    /* bool */

        //    bool kullaniciSonuc = false; /* false okudu false yazdı */
        //    kullaniciSonuc = true; /* true okudu true yazdı */

        //    Console.WriteLine(kullaniciSonuc);

        //    /* bool */

        //    bool kullaniciDeger; /* bos deger default olarak false okur yazar */
        //    kullaniciDeger = true;  /* true okudu true yazar */

        //    Console.WriteLine(kullaniciDeger);
        //    Console.ReadLine();

        //}
        #endregion

        #region VİDEO 31
        //static void Main(string[] args)
        //{
        //    DateTime tarihSaat = DateTime.Now;
        //    Console.WriteLine(tarihSaat);
        //    Console.ReadLine();
        //}
        #endregion

        #region VİDEO 32
        //static void Main(string[] args)
        //{

        //    string degiskenVal1 = "Mücahit Çetinkaya";
        //    string degiskenVal2 = "Muhammet Mücahit Çetinkaya";

        //    degiskenVal1 = degiskenVal2;
        //    degiskenVal2 = "Muhammet Çetinkaya";
        //}
        #endregion

        #region VİDEO 33
        //static void Main(string[] args)
        //{
        //    /* alıstırması yok konu özeti notlarda yazıyor ileri konu ön bilgi verildi */
        //}
        #endregion

        #region VİDEO 34
        //static void Main(string[] args)
        //{
        //    /*
        //     kullanıcıdan ad soyad şehir isteyen uygulama yapalım
        //     buradaki olay WriteLine ile konsola yazdırıyoruz
        //     ReadLine ile imleci bekletip yanıt bekliyoruz

        //     benim yaptıgım
        //    */

        //    Console.WriteLine("Adınızı Giriniz: ");
        //    Console.ReadLine();
        //    Console.WriteLine("Soyadınızı Giriniz: ");
        //    Console.ReadLine();
        //    Console.WriteLine("Şehir Giriniz: ");
        //    Console.ReadLine();

        //    /*
        //     hocanın yaptıgı
        //     ad soy şehir sorsun cevapları yazdıgımızda ekranı silip
        //     kullanıcının girdiği bilgileri gösterelim
        //    */

        //    Console.WriteLine(" Merhaba ");

        //    Console.WriteLine(" Adınız nedir ? : ");
        //    /*
        //     bunun cevabını almak için konsolu bekletmem gerek kullanıcı bir değer girişi yapacak
        //     girilen değeri bir string değişken üzerinde saklayacağım
        //     benim ihtiyacım olan string değişken
        //     olusturalım değişkeni değişken adı verelim
        //     değerini nerden alacak değerini kullanıcı girecek
        //     burada işleme Console.ReadLine komutu giriyor
        //    */
        //    string ad = Console.ReadLine();
        //    /* 
        //     string vererek metinsel atamayı kayıt etmesini sağladık

        //     burada ReadLine kısmına gelirsek diyorki
        //     Console.ReadLine komutunu calıstırıyorsun bu komut
        //     kullanıcıdan değer okuyor kullanıcının girmiş olduğu değerleri bize getirmeye calısıyor
        //     hem imleci bekletiyor hemde kullanıdan bir dönüş bekliyor
        //     kullanıcı entere bastıgı zaman
        //     ben sana değeri string tipinde dönerim diyor.
        //     sen bunu istersen bir string in üzerine alabilirsin diyor
        //    */

        //    Console.WriteLine(" Soyadınız nedir ? : ");
        //    string soyAd = Console.ReadLine();

        //    Console.WriteLine(" Yaşadığınız şehri giriniz : ");
        //    string sehir = Console.ReadLine();

        //    /*
        //     buraya kadar istediğim bilgileri aldık
        //     bundan sonra 
        //     ekranı temizlemem lazım 
        //     kullanıcının girmiş oldugu değerler kaybolsun
        //     benim girmiş oldugum değerler ekrana yazsın
        //     ekranı temizlemek için Console.Clear kullanılır
        //    */

        //    Console.Clear();

        //    /*
        //     bundan sonra yapmamız gereken değişkenin içindeki değerleri ekrana yazdırmamız lazım
        //     artı operatörünü görmedik ama örnek olarak yapalım
        //     amacımız su isim yazdıktan sonra değişkenin değerini eklemek istiyorum
        //     yani iki metni birleştirmek istiyorum
        //     çift tırnak içinde isim yazıp + ile devam ederek değişken adını yazıyoruz             
        //    */

        //    Console.WriteLine("Ad : " + ad);

        //    /*
        //     böylece iki metni birleştirecek
        //     ad kısmına ne yazarsanız mesela Mücahit bosluklarda cıktıda gözükür.
        //     bu kodun cıktısı şöyle olacak Ad : Mücahit
        //    */

        //    Console.WriteLine("Soyad : " + soyAd);
        //    Console.WriteLine("Yaşadığı Şehir : " + sehir);

        //    Console.ReadLine(); /*  bu komut ile konsol kapanmıyor */
        //    /*
        //     uygulama sırayla
        //     ad soracak girilecek
        //     soyad soracak girilecek
        //     şehir soracak girilecek
        //     en son hepsini temizleyip
        //     Ad : girilen
        //     Soyad : girilen
        //     Şehir : girilen
        //     olarak gösterecek

        //     debug motta kontrol ederken

        //     calıstır uygulamayı merhaba dunya yazdı enter
        //     isminiz nedir diye sordu isim girdim enter
        //     entere basınca string kısma geldi
        //     string in içine yazdıgım metinsel değeri kayıt etti enter
        //     soyad sordu soyad girdim enter
        //     string kısmına geldi
        //     string in içine soyadına yazıdıgım metinsel değeri kayıt etti
        //     bu içine dediğim kısım debug modunda bakarken
        //     değişken adının üstüne mause ile gelirseniz orada yazar
        //     soyadı da kayıt etti enter
        //     entere basınca
        //     sehir sordu sehir girip enter
        //     enter a basınca kayıt etti yine tekrar enter
        //     entere basınca boslukta bekliyor
        //     tekrar entere basınca
        //     clear komutunu calıstırıp konsolda yazan herşeyi silecek
        //     tekrar enter
        //     ekran temizlendi imlec yanıp sönüyor tekrar enter
        //     Console.WriteLine("isim : " + ad); kısmına geldik
        //     entere basıp bu kısmı okutunca
        //     uygulamada
        //     çift tırnak içinde yazdıgımız İsim : ile ad değişkenine verdiğimiz değer
        //     yanyana yazılmıs şekilde cıkar
        //     artı + operatörü string tipte bu işe yarıyor yanına yazıyor birleştirme yapıyor
        //     diğerleri de böyle gider.
        //    */
        //}
        #endregion

        #region VİDEO 35
        //static void Main(string[] args)
        //{
        //    /* VİDEO 35 Tür Dönüşümü nedir ? */
        //}
        #endregion

        #region VİDEO 36
        //static void Main(string[] args)
        //{
        //    byte sayi1 = 0;
        //    byte sayi2 = 100;
        //    byte sayi3 = 255;

        //    int intMinVal = int.MinValue;
        //    int intMaxVal = int.MaxValue;

        //    byte sayi4 = 256;  /*hata veriyor */

        //    int sayi5 = 256;

        //    int sayi7 = sayi2;
        //    /*
        //     bilinçi tür dönüşümü küçük olan sayıyı büyük olan sayıya atıyorsun
        //     notlarda acıklaması var
        //    */
        //}
        #endregion

        #region VİDEO 37
        //static void Main(string[] args)
        //{
        //    /*
        //     bilinçsiz tür dönüşümleri
        //     buyuk aralıgı olan değişken tipini
        //     kucuk aralıgı olan değişken tipine atama
        //    */

        //    int sayi1 = 30;
        //    byte sayi2 = sayi1; /* hata verdi byte benim aralık az int e göre ben bunu alamam diyor aralıga bakıyor */

        //    int sayi3 = 30;
        //    byte sayi4 = (byte)sayi1;
        //    /* hata vermedi bilinçsiz tür dönüşümü ben içindekini biliyorun senin aralık dogru sen yinede byte a döndür demiş olduk */

        //    /* int aralıgı içinde ama byte aralıgı dısında bir değer verirsek */
        //    int sayi5 = 256; /* int 256 aralık içinde */
        //    byte sayi6 = (byte)sayi5; /* burada hata vermez ama değeri 0 olarak okur sözü bizden alıyor aralıkta yok diye sıfır verir */
        //}
        #endregion

        #region VİDEO 38
        static void Main(string[] args)
        {
            object o1 = 100;
            object o2 = 10.90;

            /* hata vermiyor ikisini de alabiliyor */
        }
        #endregion
    }
}
