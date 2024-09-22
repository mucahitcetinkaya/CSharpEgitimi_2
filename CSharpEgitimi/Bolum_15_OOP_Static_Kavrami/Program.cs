using System.IO;

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

        #region VİDEO 136 Static neden ve nerelerde kullanılır

        //static void Main(string[] args)
        //{

        //    /*

        //     Bolum 15 OOP Static Kavrami V136 Static neden ve nerelerde kullanılır

        //    */


        //    /*

        //    Nerelerde kullanırız
        //    genelde nesne ornegının alınmasını istemediğimiz 
        //    farklı parça metotları bir arada tutmak istediğimiz
        //    yardımcı class larımız da kullanıyoruz

        //    mesela ben genelde projemde 
        //    Helper.cs adında bir class olustururum
        //    bu class ın ıcerısınde gerekli kontrollerım

        //    1 - KONTROLLER =>

        //    ilgili kişinin e mail adresi dogru mu var mı 
        //    almıs oldugum isim soy isim dogum yılı ve farklı bilgilerle
        //    bir api vaastasıyla tc kimlik numarası dogru mu 
        //    yada bana gelen data istediğim aralıkta mı gibi gibi
        //    cok parcalı cok karısık olan bolumlerımı 
        //    helper dedıgım yardımcı class ın içerisinde 
        //    toplar ve bunu bir kere yazarım
        //    daha sonra projelerımde bunu rahatlıkla kullanırım
        //    Helper içerisindeki bagımlılıklar
        //    ya bir api uzerınde olur 
        //    yada almıs oldugu parametreler içerisindeki filtrelere göre oldugu için
        //    proje bazlı bagımlılık olmaz
        //    ve ben bu class ımı istediğim projeme ekleyip kullanabilirim
        //    yanı static kavramını biz gercek hayatta 
        //    dagınık yapıdaki kontrollerımı bir class ın altında toplamak için yapıyoruz

        //    2 - Olusturmus oldugumuz nesnemizin =>

        //    içerisinde olması gereken bazı kontroller var 
        //    ve biz bu kontrollere ulasmak için 
        //    biz bu nesnenın ornegını alayım 
        //    onun uzerınden bu metota ulasayım 
        //    gibi karısık bir yapı istemeyiz
        //    bunu helper tarafına da atmak istemeyiz cunku nesne içerisinde
        //    nesneye ozel olur bunlar
        //    arka tarafta programın farklı parcaları ile bagımlı olur
        //    zaten bagımsız olsa helper.cs in içerisine koyardık
        //    farklı nesnelere bagımlı oldugu için 
        //    içerisinde o uygulamaya ozel prosesler yanı işlemler 
        //    barındıracagı için
        //    ilgili nesnenin içerisinde static metot yazarız

        //    3 -

        //    Olusturmus oldugumuz nesnemizin mesela Musteri diye
        //    bu nesnenin içerisinde bazı sabit degerler vardır
        //    musterinin database e giderken alacagı standart degerler gibi
        //    yada degismesini ortak merkezi olarak istediğim bazı field ları
        //    static olarak ayarlarım ve daha sonra bunların içerlerine degerlerimi atarım
        //    nesne içerisinde kullanımına geçtiğimde
        //    tek bir noktadan static tanımını cagırır ve bunu kullanırım
        //    eger ben o static degeri degistirmek istersem
        //    uygulama içerisinde heryerden degistirmem de 
        //    static field olarak ayarlamıs oldugum bolume gider
        //    bolumu degistirir o static field i referans olarak goren
        //    her yerde de degismesini saglarım

        //    class içerisinde bir static field tanımı yapar 
        //    igili field içerisine bir deger ataması yaparız
        //    daha sonra uygulama içerisinde n farklı yerde 
        //    olusturmus oldugumuz static field ımıza ulasır
        //    degerimizi okuruz

        //    süreç degisiklikleri büyük projelerde devamlı olur
        //    bugun bir iş emrinin geldiği bir sistemde
        //    ilgili iş emrinin sla süresi yasam süresi 2 günken
        //    3 gun sonra entegre oldugunuz bankalarla yapmıs oldugunuz anlasmada
        //    bu süre 1 güne geri cekilebilir veya 1 haftaya uzatılabilir
        //    yada bazı dogal afet deprem teror gibi olaylardan dolayı
        //    servis oraya gidemez ve sla i bapatmak zorunda kalırsınız
        //    bunlar hep static bir noktadan okunması gereken işlemlerdir
        //    şimdi her surecre bu degistiğinde ben kodumu guncellemek yerine
        //    static bir field olusturup
        //    olusturmus oldugum static field içerisine 
        //    gün bazında ay bazında yada parametrik olarak
        //    farklı bir şekilde bunun tanımını yaparım
        //    eger standar bir bölge ise 
        //    bankanın vermiş oldugu saat birimini tutarım
        //    eger deprem teror vs gibi bir olay orda olduysa
        //    sla i istersem uzatabilirim
        //    istersem kapatabilirim
        //    hepsi olusturmus oldugum field in uzerınden tek bir noktadan olur

        //    4 - 

        //    genel olarak bir yere bagımlı kalmayacagınız 
        //    helper gibi davranmasını istediginiz ama ozel olarak yazdıgınız
        //    işlemlerde kullanabilirsiniz
        //    helper dedıgımız de karısık bir sürü metotum var 
        //    bu karısık bir sürü metot içerisinde ben bunları
        //    bölüm olarak içeriye aktarıyorum ve bunların devamını saglıyorum

        //    bir kutuphaneyi uygulamama referans ettıgımde onun içerisinde bulunan
        //    bazı metotların yine süresiz olarak işlenip 
        //    ilgili kutuphaneye gidip deger almasını isteriz
        //    ve bu kutuphane için helper metot yazarız
        //    x kutuphanesinin helper metotu olarak kayıt eder
        //    ilgili referans ile haberleşmek için kullanırız
        //    nesne ornegine ihtiyac olmayacak durumlarda 
        //    bunuda içeride static olarak tanımlarız
        //    araya bir katman olustururuz
        //    olusturmus oldugumuz katmanda süreçlerimizi işler ve 
        //    datayı geri alırız

        //    [ Uygulama ] => [ozelHelper] => [DLL] 

        //    Uygulamamız ozelHelper metotuna gider belli parametreler ile gelir
        //    bu metotun içerisinde static metotlarımız field larımız olur
        //    bu ozelhelper metotun bagımlılığı bizim dıs bir programdan aldıgımız 
        //    bir api olur bir dll olur yanı dıs bir katman olur 
        //    bir kutuphane olur
        //    kutuphaneye içerideki data işlenerek gider
        //    ben parcalı data alırım 
        //    isim soyisim email musterinin bazı bilgilerini alırım
        //    kutuphaneye gönderirken json formatında gördermem gerekir
        //    json formatını ozelhelper içerisinde ayarlar dll e gönderirim
        //    dll bana degeri json doner donen json ı yine tipe cevirir
        //    uygulmaya geri gönderirim bundan dolayı helper içine kaydetmem de
        //    ozelhelper metot sınıf olustururum bunun içinde 
        //    işlemlerimi yaparım

        //    */

        //}

        #endregion

        #region VİDEO 137 Static Field Kullanımı

        //static void Main(string[] args)
        //{
        //    /*

        //     Bolum 15 OOP Static Kavrami V137 Static Field kullanımı

        //    */

        //    /*

        //    1. not baslangıc

        //    Personel class ını tanımlayalım gidip field ları yazalım

        //    1. not bitiş
        //    2. not bitiş

        //    3. not baslangıc

        //    ornekleme yapalım
        //    P1. nokta dedigimiz de static olmayan prop lar geliyor
        //    ornekleme yaptıgımız için digerleri cıkmıyor

        //    field ları dolduralım

        //    Personel class ımıza donelim

        //    3. not bitiş
        //    4. not bitiş

        //    5. not baslangıc

        //    breakpoint koyup debug edelim
        //    basta p1 null f10 ile devam edelim
        //    bilgiler geldi
        //    Cinsiyet 0
        //    EmailAdres null
        //    Isim null
        //    SoyIsim null
        //    _emailAdres null

        //    birde altında static members alanı var burda da static alanlara ulasabilirsiniz

        //    domainAdres "firmam.com"
        //    f10 ile devam edelim 
        //    ısım soyisim atandı

        //    emailadrese gelince f11 ile devam ediyorum ki diger tarafa gidelim

        //    5. not bitiş
        //    6. not bitiş

        //    7. not baslangıc            

        //    emailadres staticmembers olan bir domainadresınden gelen veri ile olustu

        //    hepsini de bitirdik oldu

        //    7. not bitiş

        //    */

        //    Personel137 P1 = new Personel137();
        //    P1.Isim = "Mücahit";
        //    P1.SoyIsim = "Çetinkaya";
        //    P1.EmailAdres = "mucahitcetinkaya";
        //    P1.Cinsiyet = 717777001; // 001 bay 002 bayan

        //}

        #endregion

        #region VİDEO 138 Static Metot Kullanımı

        //static void Main(string[] args)
        //{
        //    /*

        //     Bolum 15 OOP Static Kavrami V138 Static Metot Kullanımı

        //    */

        //    /*

        //    1. not baslangıc

        //    yeni bir personel olusturdugumuz da 
        //    insan kaynaklarına bu personelin bilgisini verecek
        //    static bir metot hazırlayalım

        //    Personel138 den devam edecegiz 137 den kopyalayalım

        //    email gönderme işlemleri olacak 
        //    biz burda emailadresi metota parametre olarak gecip 
        //    metotun body blogunu bos bırakacagız
        //    console ekranda oraya mail gönderildi yazdıracagız
        //    egitim setinin içerisinde c# ile emailnasıl gönderilir
        //    detaylı bir şekilde bulabilirsiniz 

        //    Helper138 class ını olusturalım
        //    bütün kucuk işlemlerimi burda yapmak istiyorum

        //    Helper class ına gecelım

        //    1. not bitiş
        //    2. not bitiş

        //    3. not başkangıc

        //    helper uzerınden devam edecegiz

        //    helper metodu static new lemeye gerek yok
        //    parametreleri var onları doldurmamız lazım

        //    Helper138.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.SoyIsim);

        //    buraya breakpoint koyup devam edelim

        //    static metota dusup ekrana yazdırdı

        //    diger dersimiz de static yapıcı metot uzerıne konusalım


        //    */

        //    Personel138 P1 = new Personel138();
        //    P1.Isim = "Mücahit";
        //    P1.SoyIsim = "Çetinkaya";
        //    P1.EmailAdres = "mucahitcetinkaya";
        //    P1.Cinsiyet = 717777001; // 001 bay 002 bayan

        //    Helper138.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.SoyIsim);


        //}

        #endregion

        #region VİDEO 139 Static Class Kullanımı

        //static void Main(string[] args)
        //{
        //    /*

        //     Bolum 15 OOP Static Kavrami V139 Static Class Kullanımı

        //    */

        //    /*

        //    1. not baslangıc

        //    Video 138 den gerekli bilgileri buraya gecirdik
        //    Video 139 Helper139 Personel139 olarak

        //    static class ları inceleyeceğiz

        //    Helper139 class ına gidelim

        //    1. not bitiş
        //    2. not bitiş

        //    3. not başlangıc

        //    Helper static class oldu bakalım new lenecek mi
        //    Helper139 H1 = new Helper139();

        //    hata veriyor olmuyor

        //    static class ların nesne ornegi alınmaz 
        //    kendi içlerinde ise sadece sadece static olan field ve metotları barındırırlar

        //    Helper a geçelim

        //    3. not bitiş
        //    4. not bitiş

        //    5. not başlangıc


        //    Helper139.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.SoyIsim);

        //    demiştik bunu 2 kere yollayalım bakalım nolcak

        //    helper139 a gidiyor static yapıcı metot calısıyor

        //    sonra emailgonder calısıyor program.cs e donuyor

        //    sonra ikinci satır calısıyor

        //    tekrar Helper139 a gidiyor ama bu sefer yapıcı calısmadı
        //    direk emailgonder metotu calıstı

        //    static yapıcı metot 1 kere calıstı

        //    field metot ve class ları static olarak inceledik
        //    static leri uygulamamız içerisinde kullanıyoruz
        //    static class içerisindeki tüm field metotları
        //    veya Personel139 nesnemiz de var burda
        //    buna da bir sonraki video da devam edelim

        //    mesela ornek olarak

        //    benım class ım static degil 
        //    ama içeride static BinaryReader domain adresi adında bir field ım var 

        //    ben istiyorum static field ıma static yapıcı metot uzerınden deger atayayım

        //    bunu da bir sonraki dersimiz de inceleyelim


        //    */

        //    Personel139 P1 = new Personel139();
        //    P1.Isim = "Mücahit";
        //    P1.SoyIsim = "Çetinkaya";
        //    P1.EmailAdres = "mucahitcetinkaya";
        //    P1.Cinsiyet = 717777001; // 001 bay 002 bayan

        //    //Helper139 H1 = new Helper139();

        //    Helper139.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.SoyIsim);

        //    Helper139.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.SoyIsim);

        //}

        #endregion

        #region VİDEO 140 Static Yapıcı metot ile Standart Yapıcı metot davranış farkı

        //static void Main(string[] args)
        //{
        //    /*

        //     Bolum 15 OOP Static Kavrami V140 Static Yapıcı metot ile Standart Yapıcı metot davranış farkı

        //    */

        //    /*

        //    1. not baslangıc

        //    bir önceki videomuz da konustugumuz sartımızı yapalım
        //    personel nesnemiz statik degil
        //    içeride bir statik metot kullanımı yapacagız
        //    domain adresini statik metot da atamak istiyorum

        //    Personel140 class ını olusturalım ordan devam edelim

        //    1. not bitiş
        //    2. not bitiş

        //    3. not baslangıc

        //    Helper140 ı olusturduk 

        //    Personel140 ı 2 kere doldurduk ki tekrar gitsin ve 
        //    statik olana tekrar girecek mi ona bakalım diye

        //    debug anlatımı

        //    Personel new lenecek
        //    ilk önce yapıcı metotlar calısacak
        //    ilk önce her zaman static metot lar calısır yapıcı metot için gecerli degil bu 
        //    statik metotların calısma önceliği var
        //    statik yapıcı calısır standart yapıcı calısır
        //    sonra buraya dönüp p1 ler dolacak

        //    sonra p2 e gelecek newlenecek
        //    sadece standart yapıcı metot calısacak
        //    buraya gelip p2 ler calısacak

        //    helper lar calısacak


        //    */

        //    Personel140 P1 = new Personel140();
        //    P1.Isim = "Mücahit";
        //    P1.SoyIsim = "Çetinkaya";
        //    P1.EmailAdres = "mucahitcetinkaya";
        //    P1.Cinsiyet = 717777001; // 001 bay 002 bayan

        //    Personel140 P2 = new Personel140();
        //    P2.Isim = "Mücahit";
        //    P2.SoyIsim = "Çetinkaya";
        //    P2.EmailAdres = "mucahitcetinkaya";
        //    P2.Cinsiyet = 717777001; // 001 bay 002 bayan

        //    Helper140.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.SoyIsim);

        //    Helper140.emailGonder("ik@firmam.com", "Yeni personel bilgilendirme", P1.Isim + P1.SoyIsim);

        //}

        #endregion

        #region VİDEO 141 Bölüm Sonu Ödev { Tüm bölümlerin genelini kapsar }

        //static void Main(string[] args)
        //{

        //    /*

        //     Bolum 15 OOP Static Kavrami V141 Bölüm Sonu Ödev { Tüm bölümlerin genelini kapsar }

        //    */

        //    /*
             
        //    1. not başlangıc 

        //    Musteri141 class i olusturalım

        //    2. not bitiş 

        //    3. not baslangıc

        //    Musteri141 i new ile ornekleyelim null oldugunu görelim
        //    Musteri141 M1 = new Musteri141();
        //    olusturduk breakpoint ekledik
        //    içeride yapıcı metotun onemını görmek istiyorum 

        //    ustune gelince M1 in butun field lar null olarak gelmıs 
        //    Static members kısmı var 
        //    musteriDatabase null olarak gelmıs 
        //    benım istediğim musteriyi ilk cagırdıgım noktada static yapıcı metotum calıssın 
        //    musteriDatabase olan koleksiyonum new ile orneklensin ve 
        //    yeni kayıt almaya hazır halde beklesin 
        //    neden static yapıcı metot 

        //    static yapıcı metotlar uygulama içerisinde ilgili nesne cagrıldıgında bir kere calısıyor 
        //    eger ben koleksiyonu standart olan yapıcı metot ile orneklemıs olsam 
        //    her nesne orneklendıgın de 
        //    koleksiyonum yenıden orneklenecekti ve içerisindeki datayı kayıp edecektim 

        //    Musteri141 e gidelim 

        //    3. not bitiş 
        //    4. not bitiş 
             
        //    5. not baslangıc

        //    tekrar breakpoint koyup static members lara bakalım ne olmuslar

        //    musteriDatabase Count = 0 olarak gelmıs 
        //    calısır calısmaz new ile orneklendı ve add metotu ile içine veri eklenebilir hale geldi

        //    Musteri141 e gidelim

        //    5. not bitiş 

        //    6. not bitiş

        //    7. not baslangıc

        //    nesneyi olusturduk new ledik

        //    M1. ile Musteri141 içindeki alanları doldurduk

        //    ve bunları sanaldatabase e eklemek istiyorum

        //    sanaldatabase static olarak nesne içerisinde saklı 

        //    Musteri141.MusteriEkle(M1);

        //    dediğimiz de içerideki süreçler calısacak

        //    bir nesne daha olusturalım M2 olsun buda 
        //    size farklı bir nesne ornekleme göstereyim

        //    normalde M2 diyip yazmamız lazım 
        //    hızlı tip denilen bir kavram var 

        //    Musteri141 M2 = new Musteri141() {
            
        //    }

        //    new Musteri141() dedikten sonra ; noktalı vürgül koymak yerine süslü parantez acıyoruz

        //    ilgili nesnenin public field larını görebilirsiniz
        //    aralarda virgül ile gider

        //    birde M3 olusturalım M1 in kopyası kopya olmasını isteme sebebim bunu eklemek istersem sistemde var olacak 

        //    izin vermemesini bekleyeceğiz

        //    M1 e bir breakpoint koyalım ve Musteri141 in içindeki yapıcı metota bir breakpoint koyalım
        //    set bloguna 
        //    tüm static metotlara bir breakpoint koyalım süreçleri görelim

        //    programı calıstırınca 

        //    Musteri nesnem orneklenirken arka tarafta benim static yapıcı metotum orneklenecek
        //    ben aslında arka tarafta olusturmus oldugum database imi orneklemıs olacagım

        //    f11 ile devam edince static yapıcı metota geldik
        //    new ile orneklendıgını görduk musteriye geri döndü 

        //    kullanıcıadına gelince f11 ile devam edelim Musteri141 e gidicek

        //    KullanıcıAdi set bloguna düşüyor 

        //    içeride bu kullanıcı adı var mı diye bakacak

        //    musteeriKullaniciAdiKontrol metoduna f11 ile gidelim

        //    parametresine bakalım gönderdıgımız deger gelmiş 

        //    kontrol false dedi
        //    musteriDatabase içinde count u kadar donmemız gerek ama ilk kayıt gerek olmayacak donmesıne

        //    kontrol false dedi yokmus yani kayıt

        //    KullanıcıAdi set bloguna geri dönecek

        //    true olsa sistemde kayıtlı ile bildiri verecekti false geldi else e girecek

        //    value u eklemıs oldu 

        //    şifreyi de atatık 

        //    burdan da MusteriEkle static metotuna gidiyoruz 

        //    kontrol leri yapacak 

        //    sistem de yok ve kontrollerden gececek ilk kayıt

        //    add ile ekleme yapacak

        //    M1 e bakınca count artık 1 oldu 

        //    burdan içine bakınca da ekleme yapmıs sorun yok 

        //    m2 içinde ekleme yapalım 

        //    kayıt eklendi dedi sorun yok 

        //    m3 içinde yapalım bu sefer de içeride var diyecek hata verecek

        //    kontrol lere gelecek içeride var diyecek sonra null a cekecek ordan 
        //    return diyip bos dönecek ekleme yapmayacak

        //    */

        //    Musteri141 M1 = new Musteri141();

        //    M1.musteriID = 1;
        //    M1.isim = "Mücahit";
        //    M1.soyIsim = "Çetinkaya";
        //    M1.emailAdres = "mucahitcetinkaya@outlook.com";
        //    M1.KullaniciAdi = "mucahit.cetinkaya";
        //    M1.sifre = "1";

        //    Musteri141.MusteriEkle(M1);

        //    Musteri141 M2 = new Musteri141()
        //    {
        //        musteriID = 2,
        //        isim = "Zayn",
        //        soyIsim = "Çetinkaya",
        //        emailAdres = "zayncetinkaya@hotmail.com",
        //        KullaniciAdi = "zayn.cetinkaya",
        //        sifre = "2",
        //    };

        //    Musteri141.MusteriEkle(M2);


        //    Musteri141 M3 = new Musteri141();

        //    M3.musteriID = 1;
        //    M3.isim = "Mücahit";
        //    M3.soyIsim = "Çetinkaya";
        //    M3.emailAdres = "mucahitcetinkaya@outlook.com";
        //    M3.KullaniciAdi = "mucahit.cetinkaya";
        //    M3.sifre = "1";

        //    Musteri141.MusteriEkle(M3);


        //}

        #endregion



    }
}
