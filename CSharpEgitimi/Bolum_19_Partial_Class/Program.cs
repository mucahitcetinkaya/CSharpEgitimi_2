
using System;

namespace Bolum_19_Partial_Class
{
    internal class Program
    {
        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion

        #region VİDEO 163 Bilgilendirme

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 19 Partial Class V163 Bilgilendirme


        //    */

        //    /*

        //    1. not baslangıc

        //    bu bölümde bilmemizin iyi olacagı bilmesekte calısmamıza engel olmayacagı bir kavram olan partial class ları görecegız 

        //    class ları biz class musteri vs gibi yazıyorduk bu class ın içinde de problar fiel lar metotlar vs oluyordu 

        //    bunu uzun süreçte düşündüğünüz de bir uygulama yazarken birden fazla baglantı kuracagımız için bir sürü kod blogumuz olur 

        //    be ilgili metotu aratmak zorunda kalırız ctrl + f yani bu kodda bir duzensizliğe de yol acmakta 

        //    şöyle bir şey istersek ne olur

        //    benım öyle bir mantıgım olsun ki 
        //    ben musteri class ımın field larını bir yerde toplayayım 
        //    ben musteri class ımın metot larını bir yerde toplayayım 

        //    eger field larına bakmak istersem ilgili bölümdeki alana bakıp field larını arayabileyim yada ekleyebileyim 
        //    metotlarına bakmak istersem de farklı bir alandan gideyim metotlarını göreyim 
        //    fakat uygulama calıstıgı zaman 2 farklı parcayı tek bir parca olarak elde edebileyim 

        //    n katmanli mimari repostory disagne pattern vb database ilişkilerin de kullandıgımız business servisler de partial class ların onemini daha net anlayacagız 

        //    diger derse gecelim.


        //    */


        //}

        #endregion

        #region VİDEO 164 Partial class nedir - 1

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 19 Partial Class V164 Partial class nedir - 1


        //    */

        //    /*

        //    1. not baslangıc

        //    once bir class olusturalım ve bu class ın içinde field prob metot larımızı yazalım inceleyelim sonrada bunu partial olarak guncelleyelim

        //    Musteri class ını olusturalım

        //    1. not bitiş

        //    2. not bitiş musteriden geldik

        //    3. not baslangıc

        //    musteri nesnesini new leyelim

        //    new ledık ve m1. dedigimiz de butun prob ve metotlarını görebiliyoruz son durum

        //    V164Musteri M1 = new V164Musteri();
        //    M1.id = 1;
        //    M1.isim = "mücahit";
        //    M1.soyisim = "çetinkaya";
        //    M1.email = "abc@hotmail.com";

        //    int sonuc = M1.yeniKayit(M1);

        //    if (sonuc > 0) 
        //    {
        //        Console.WriteLine("database e yeni kayıt eklendi.");
        //    }


        //    musteriye gecelim

        //    3. not bitiş

        //    4. not bitiş musteriden geldik

        //    5. not baslangıc

        //    yeni class olusturalım V164OgrenciField

        //    V164OgrenciField e gidelim

        //    5. not bitiş

        //    6. not bitiş ogrencifield dan geldik

        //    7. not baslangıc

        //    ogrenciMetot.cs adında bir class olusturalım oraya gidelim

        //    7. not bitis

        //    8. not bitis V164OgrenciMetot

        //    9. not baslangıc

        //    V164OgrenciMetot içindeki ders bitti diger derse geç

        //    9. not bitiş



        //    */

        //    // 3. not baslangıc

        //    V164Musteri M1 = new V164Musteri();
        //    M1.id = 1;
        //    M1.isim = "mücahit";
        //    M1.soyisim = "çetinkaya";
        //    M1.email = "abc@hotmail.com";

        //    int sonuc = M1.yeniKayit(M1);

        //    if (sonuc > 0)
        //    {
        //        Console.WriteLine("database e yeni kayıt eklendi.");
        //    }


        //}

        #endregion

        #region VİDEO 165 Partial class nedir - 2

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 19 Partial Class V165 Partial class nedir - 2


        //    */

        //    /*

        //    9. not bitiş V164

        //    1. not baslangıc V165

        //    V164 den aldık kodları V165 olusturduk
        //    V165Musteri.cs
        //    V165OgrenciField.cs
        //    V165OgrenciMetot.cs

        //    V165OgrenciField.cs ve V165OgrenciMetot.cs class içinde isimleri aynı V165Ogrenci

        //    1. not bitiş V165OgrenciMetot.cs e gidelim

        //    3. not bitiş V165OgrenciField den geldik

        //    4. not baslangıc

        //    metotları ve field ları ayırdık bakalım tek bir yerden kullanabilecek miyiz

        //    ogrenci nesnesini new leyelim

        //    V165Ogrenci O1 = new V165Ogrenci();
        //    V165Ogrenci yazınca tek bir tane geldi

        //    O1. yazınca da field ve metotlarımı da görebiliyorum

        //    V165Ogrenci O1 = new V165Ogrenci();

        //    O1.id = 1;
        //    O1.yeniKayit(O1);

        //    id veya yeniKayit üstünde
        //    ctrl ve mouse ile sol yapınca

        //    id e yapınca Field a yeniKayit a yapınca Metot a gönderiyor beni

        //    2 veya daha fazla sekılde partial class kullanılabilir 

        //    ders bitti diger konuya gecelim

        //    */

        //    V165Musteri M1 = new V165Musteri();
        //    M1.id = 1;
        //    M1.isim = "mücahit";
        //    M1.soyisim = "çetinkaya";
        //    M1.email = "abc@hotmail.com";

        //    int sonuc = M1.yeniKayit(M1);

        //    if (sonuc > 0)
        //    {
        //        Console.WriteLine("database e yeni kayıt eklendi.");
        //    }

        //    V165Ogrenci O1 = new V165Ogrenci();

        //    O1.id = 1;
        //    O1.yeniKayit(O1);


        //}

        #endregion

    }
}
