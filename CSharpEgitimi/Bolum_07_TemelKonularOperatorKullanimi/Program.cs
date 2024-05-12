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












    }
}
