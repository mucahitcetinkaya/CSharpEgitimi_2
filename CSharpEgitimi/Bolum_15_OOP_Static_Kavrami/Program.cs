namespace Bolum_15_OOP_Static_Kavrami
{
    internal class Program
    {

        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 133 Static Nedir ?

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 15 OOP Static Kavrami V133 Static Nedir ?

        //    */

        //    /*

        //    OOP - Static

        //    Nesne Yönelimli Programlama - Static Kavramı

        //    biz bu bolume kadar neler yaptık
        //    bir nesne olusturduk
        //    nesnemizi new ile ornekledıgımız de 
        //    onun steak (pointer) ve heap tarafında bir bölüm oldugunu gördük
        //    referans tipli davranısını inceledik

        //    daha sonra sınıf içerisinde olusturmus oldugumuz alanlarımızı
        //    nasıl özelleştirebileceğimizi inceledik

        //    şimdi ram kısmını cizerken hatırlasınız ki burayı biraz daha sonra anlatacagım

        //    o kısma geldik

        //            STEAK                   HEAP
        //    ----------------------------------------------
        //    I                     I                      I
        //    I                     I                      I
        //    I                     I                      I
        //    I                     I                      I
        //    ----------------------------------------------
        //    I                                            I
        //    I                                            I
        //    ----------------------------------------------
        //                        STATİC


        //    nesne üzerinde static nedir
        //    static içerisinde olusturdugumuz 
        //    field lar metotlar nelerdir

        //    Nesne Yönelimli Programlama konusunda önemli bir
        //    bölüm olan static konusuna geldik

        //    STATİC Class - Field - Metot

        //    Bölüm içerisinde

        //    Static Nedir ?
        //    Statik ram bölgesindeki yeri

        //    Static class nedir
        //        Static yapıcı metot nedir ?
        //        Standart yapıcı metot'dan farkı nedir

        //    Static field nedir nasıl ulasırız default deger nası atarız

        //    Static metot nedir

        //    Konularını örnekler ile inceliyor olacagız

        //    bir önceki orneklerımız de kapsulleme de 
        //    her bir string içerisinde dönerken
        //    char ın statik olan bir metotundan faydalanmıstık
        //    IsNumber
        //    .net framework un de kullandıgı gibi bizde kendı özel class larımız da 
        //    staticleri kullanıyoruz neden kullandıgımızı da ayrı olarak
        //    konusacagız

        //    */

        //}

        #endregion

        #region VİDEO 134 Static Nedir - 1

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 15 OOP Static Kavrami V134 Static Nedir - 1

        //    */

        //    /*
             
        //    1. not başlangıç              
             
        //    Static : Nesne örneği alınmadan ulaşabildiğimiz metot field 
        //    static class dedıgımız nesne ornegi alınamayan alınmasını engelledıgımız
        //    içerisinde metot ve field ları barındıran bir sınıf 

        //    biz static dedigimiz de = new kısmına ihtiyac duymuyoruz

        //    yani

        //    yeni bir class olusturup new ledik nesne ornegi olusturduk diyorduk
        //    static bir class olusturdugumuz da new lemeye gerek kalmıyor

        //    once ram uzerındeki yerınden bahsedip sonra da calısma mantıgına bakalım

        //    once bir class olusturalım

        //    Ogrenci134 adında bir class olusturalım

        //    class a geçip notlar alalım

        //    1. not bitiş
        //    2. not bitiş

        //    3. not başlangıc

        //    Ogrenci134 nesnesini cagıralım ve bir isim verelim
        //    Stack bölge içerisinde pointer ımız olustu...
        //    Ogrenci134 O1;

        //    Stack bölgede pointer olustugu zaman arka tarafta yanı sistemin 
        //    calısma zamanında run time da static olan bir yapıcı metot calıstı
        //    ve yine class içerisinde tanımlı olan static field static metot
        //    bunların hepsi static dedigimiz bölgede olusturuldu

        //    new lemeden once 

        //    Ogrenci.Test2();
        //    yazarak
        //    Test2 adındaki metotuma ulasabildim

        //    daha sonra ben ogrencıden bir nesne ornegi almak istediğimde 
        //    O1 = new Ogrenci134();

        //    stack bölgede olusan pointer kendisini heap bölgede tamamladı
        //    neyi tamamladı
        //    static olmayan tanımlarını tamamladı

        //    ogrenci ornegını aldıktan sonra yanı new ledıkten sonra
        //    Test1 adındaki metotuma ulasabildim
        //    O1.Test1();



        //    */

        //    Ogrenci134 O1;

        //    Ogrenci134.Test2();

        //    O1 = new Ogrenci134();
        //    O1.Test1();

        //}

        #endregion




    }
}
