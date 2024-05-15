﻿namespace Bolum_10_Diziler_Arrays
{
    internal class Program
    {

        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 92 Bilgilendirme

        //static void Main(string[] args)
        //{

        //}

        #endregion

        #region VİDEO 93 Dizi Nedir

        //static void Main(string[] args)
        //{

        //    /*

        //    VİDEO 93 Dizi Nedir 

        //    */

        //    /*

        //    Anlatımı notlarda var

        //    */

        //    string[] ogrenciIsimListesi = new string[5];
        //    ogrenciIsimListesi[0] = "Muhammet";
        //    ogrenciIsimListesi[1] = "Mücahit";
        //    ogrenciIsimListesi[2] = "Çetinkaya";
        //    ogrenciIsimListesi[3] = "Arden";
        //    ogrenciIsimListesi[4] = "Zayn";

        //    Console.WriteLine("foreach ile olan");

        //    foreach (string item in ogrenciIsimListesi)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine("for ile olan");

        //    for (int i = 0; i < ogrenciIsimListesi.Length; i++)
        //    {
        //        string gelenIsim = ogrenciIsimListesi[i];
        //        Console.WriteLine(gelenIsim);
        //    }

        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 94 Dizi Örnek 2 Adet

        //static void Main(string[] args)
        //{

        //    /*

        //    VİDEO 94 Dizi - Örnek Kullanımlar ( 2 farklı örnek uygulama içerir )

        //    */


        //    /*

        //    Uygulama - 1

        //    int veri tipinde bir dizi oluşturalım, kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin
        //    ve dizi içerisindeki alanlara değer ataması yapsın.

        //    burda bir for döngüsünden yararlanacagız
        //    diziyi olustururken dizinin eleman sayısını kullanıcıdan isteyeceğiz
        //    tür dönüşümü yapacağız

        //    daha sonra dizi içerisindeki elemanların toplamlarını ve ortalamasını ekrana yazdıran bir uygulama yazalım.


        //    kodun anlatımı

        //    önce veri kümesinin uzunlugunu istedik
        //    sonra girilen sayıyı int e cevirdik

        //    yeni bir dizi olusturduk girilen sayı kadar elemanlı olacak sekilde

        //    for ile dizinin içinde dönüyoruz
        //    sıfırdan baslaması önemli index 0 dan baslıyor çünkü

        //    kaç elemanlı bir diziyse onun uzunlugu kadar dönecek
        //    her seferinde bizden veri isteyip int e cevirecek

        //    bittiğinde cıkacak for dan tebrikler kısmını yazacak

        //    sonra toplama kısmına geliyor

        //    bildiri yazdı

        //    toplama ve ortalama için 2 tane degisken olusturduk
        //    bu kısmı foreach ile yapalım
        //    int tipindeki uygulama1Dizi nin içinde dön hepsine item de
        //    bütün sıradaki item ları ekrana yazdır

        //    toplam zaten basta sıfırdı sıradaki item ile toplayıp
        //    toplamın ustune atama yapıyoruz

        //    +---------

        //    uygulama1Toplamı

        //    bildirim

        //    ortalama aldık uzunluguna böldük

        //    bildirim

        //    */

        //    Console.Write("Lütfen oluşturmak istediğiniz veri kümesinin uzunluğunu giriniz : ");
        //    int diziElamanSayisi = Convert.ToInt32(Console.ReadLine());


        //    int[] uygulama1Dizi = new int[diziElamanSayisi];

        //    for (int i = 0; i < uygulama1Dizi.Length; i++)
        //    {
        //        Console.WriteLine("{0}. index e denk gelen değeri giriniz : ", i);
        //        uygulama1Dizi[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Console.WriteLine("Tebrikler dizinin içerisindeki tüm alanları doldurdunuz.");


        //    Console.WriteLine("Dizi içerisindeki değerler ve toplam ortalama değeri aşağıdaki gibidir.");

        //    int uygualama1Toplam = 0, uygulama1Ortalama = 0;

        //    foreach (int item in uygulama1Dizi)
        //    {
        //        Console.WriteLine(item);
        //        uygualama1Toplam = uygualama1Toplam + item;

        //    }
        //    Console.WriteLine("+---------------------");

        //    Console.WriteLine(uygualama1Toplam);

        //    Console.WriteLine("Dizi içerisindeki eleman sayısı : {0}", uygulama1Dizi.Length);
        //    uygulama1Ortalama = uygualama1Toplam / uygulama1Dizi.Length;
        //    Console.WriteLine("Ortalama : {0}", uygulama1Ortalama);


        //    /*

        //    Uygulama - 2

        //    20 elemanlı bir int dizi oluşturalım. Değerlerimizi random sınıfının next fonksiyonu ile 1 - 20 arasındaki değerler
        //    ile dolduralım daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri
        //    oldugunu bulalım

        //    */

        //    int[] uygulama2Dizi = new int[20];
        //    Random random = new Random();


        //    for (int i = 0; i < uygulama2Dizi.Length; i++)
        //    {
        //        uygulama2Dizi[i] = random.Next(1, 20);
        //    }

        //    int uygulama2Bul = 0;

        //    foreach (int item in uygulama2Dizi)
        //    {

        //        Console.WriteLine(item);

        //        if (item == 4)
        //        {
        //            uygulama2Bul++;
        //        }

        //    }
        //    Console.WriteLine("Dizi içindeki 4 {0} tane vardır. ", uygulama2Bul);
        //    Console.ReadLine();

        //}

        #endregion

    }
}