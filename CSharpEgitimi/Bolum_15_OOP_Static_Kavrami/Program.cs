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

        #region VİDEO 135 Static Nedir - 2

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 15 OOP Static Kavrami V135 Static Nedir - 2

        //    */

        //    /*

        //    1. not baslangıc

        //    Video 134 un devamı
        //    Ogrenci135 class ı acalım oraya gidelim

        //    1. not bitiş
        //    2. not bitiş

        //    3. not baslangıc

        //    Ogrenci135 in stack alanlarını olusturalım
        //    O1 i new lemeden olusturduk
        //    direk class uzerınden test2 metotuna ulastık

        //    O1 i new ledikten sonra test1 i cagırdık

        //    tekrar ram yapısını çizelim

        //                STACK                   HEAP
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

        //    Ogrenci135 O1; dedigimiz de 
        //    stack bölgede bir pointer olusturduk
        //    olusturdugumuz pointer in ismini de O1 olarak işaretledik
        //    O1 new lenmedıgı için heap bölgede herhangi bir yeri işaret etmiyor
        //    ama
        //    Ogrenci135 O1 olusurken 
        //    arka tarafta static bir yapıcı metot calıstı
        //    ve static içerisinde yer alan
        //    field metot olusturuldu
        //    su anda da static bir metot var içeride 
        //    Ogrenci135 in içindeki Test2

        //    Test2 static oldugu için O1.Test2 diyemiyoruz static zaten direk 
        //    class uzerınden gidebiliriz Ogrenci135.Test2 diyebiliriz

        //    O1 pointer i stack bolgede olusan
        //    heap bolgedeki nesne yıgınına yanı heap bolgede olusacak field metot vb
        //    işlemlerin yıgınının ulasacagı pointer siz eger static uzerınde 
        //    static tanımınıza ulasacaksanız class ınız adını yazmanız ve 
        //    nokta operatörü ile static olarak olusturmus oldugunuz
        //    bölümlere erişmeniz gerekiyor

        //    yanı ben O1 ile static bolgeye ulasamıyorum
        //    Ogrenci135 uzerınden static bolgeye ulasabiliyorum

        //    O1 tanımı stack bolgede bir pointer dır
        //    new ile orneklendıgınde test1 e orneklendıgı
        //    degisken adı uzerınden ulasabiliriz

        //    Test1 static degil once new leyip sonra onun uzerınden gidebiliriz

        //    debug yapalım

        //    en basa pointer koyalım

        //    Ogrenci135 O1;

        //    uygulama bizi Test2 e gönderecek

        //    nesne ornegı alınamdan kullanılabilir yazdı ekranda

        //    yukarıdaki O1 e bakıyorum hala null yazıyor
        //    neden
        //    cunku nesne ornegı alınmadı new ile orneklenmedı

        //    sımdı ben onu O1 = new Ogrenci135(); diyip
        //    nesne ornegını aldıgım zaman

        //    O1 kendı standart degerlerıne kavusacak Musteri135 in içindeki field lara

        //    sonrada O1 uzerınden Test1 e gidiyoruz

        //    Nesne örneği alındıktan sonra calısan metotdur. yazdı ekranda

        //    şimdi de bunu biraz daha detaylandıralım 

        //    Musteri135 e gidelim

        //    3. not bitiş


        //    */

        //    Ogrenci135 O1;
        //    Ogrenci135.Test2();

        //    O1 = new Ogrenci135();

        //    O1.Test1();

        //}

        #endregion



    }
}
