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
















    }
}
