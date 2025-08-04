
using System;

namespace Bolum_17_OOP_Sanal_Metot
{
    internal class Program
    {
        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion

        #region VİDEO 151 Nesne yönelimli programlama dünyasında sanal metot nedir ?

        //static void Main(string[] args)
        //{
        //    /*

        //    Bolum 17 OOP Sanal Metot V151 Nesne yönelimli programlama dünyasında sanal metot nedir ?
        //    Çok Biçimlilik Sanal Metot Kullanımı

        //    Bir önceki bölümde kalıtım konusunu inceledik bunla alakalı aslında diğer bolumleri de kapsayan bir uygulama yapmıştık.

        //    Şimdi çok biçimlilik konusunda sanal metot nedir ve polimorphszm içerisinde sanal metot nası kullanılır kısmını incelemeye çalışacagız

        //    Sanal Metotlar

        //    Bir önceki bölüm içerisinde kalıtım konusunu inceledik. Hatırlarsanız kalıtım içerisinde kalıtılan sınıf kendisini kalıtan sınıfa içerisindeki private metotlar haricinde bulunan tüm metotları kullanım izni sunmaktaydı.

        //    Örnek olarak baseClass adında bulunan sınıfımızı urun sınıfı kalıttığı zaman baseClass içerisinde bulunan metotlara ve özelliklere erişebiliyor baseClass içerisindeki tanımları gibi kullanabiliyordu.

        //    BaseClass içerisinde ekrana yaz adında bir metot olsa urun sınıfı içerisinde ekrana yaz metotu çağrıldığı zaman baseClass içerisinde bulunan şekli ile çalışıp metot işlemini tamamlayabiliyordu.

        //    Sanal metot dediğimiz bu bölümümüz de baseclass içerisinde bulunan bir metotun istenilirse türeyen sınıf içerisinde nasıl yeniden şekillenebileceğini inceleyeceğiz.

        //    Kalıtım konusunda tüm nesnelerin object nesnesinden kalıtıldığını ve bazı metotların object nesnesinden bize geldiğini söylemiştik.

        //    Birazdan sanal metot anlatımına object içerisinde bize standart olarak gelen tostring metotunu inceleyerek başlayacagız

        //    Sanal metotları X-men filminde bulunan mystique karakterine benzetebilirsiniz.

        //    Ortama göre kendi şeklini değiştirebilen bir karakter olması buna örnek olabilir.

        //    */

        //}

        #endregion

        #region VİDEO 152 object nesnesinden gelen ToString metotunu inceleyelim.

        //static void Main(string[] args)
        //{
        //    /*

        //    Bolum 17 OOP Sanal Metot V152 object nesnesinden gelen ToString metotunu inceleyelim.

        //    */

        //    /*

        //    1. not başlangıç

        //    şimdi tostring metotu ile sanal metotları tanımaya baslayalım

        //    kalıtım da bütün nesnelerin object ten türediğini söylemiştik

        //    object ten gelen de bazı metotların oldugunu soylemıstık mesela ToString() gibi
        //    calısmasından bahsedelim sonrada debug edecegız

        //    nesnelerimizi ornekledıgımız zaman yanı
        //    Musteri M = new Musteri();
        //    benım musteri nesnem object nesnesınden kalıtıyor ve olusuyor
        //    nesne olustugunda da object ile birlikte bazı metotlar ile birlikte geliyordu
        //    hiç bişey olusturmadan sadece new ledıgımızde 
        //    M. dedıgımızde karsımıza cıkan metotlar bunlar
        //    M.ToString(); gibi yanı musteri nesnesinde olmayan bir metoda erısmıs oluyordum objectin içerisinden bana kalıtım yoluyla geliyordu

        //    tostring metotunun kendıne ozgu bir calısma seklı var
        //    cagırdıgımız da cagrılan class ın namespace ve adını geriye döner 
        //    Bolum_17_OOP_Sanal_Metot.Musteri gibi
        //    bu .net framework içerisinde standart kullanım şekli
        //    m.tostring dedıgımde namespace ve class adını geriye doner
        //    string olarak doner konsola yazdırabiliriz

        //    object nesnesine gelen bu tostring metodu sanal bir metot yanı ben bu metodun body sini degistirebilirim
        //    namespace.musteri olarak gelme de benım yazdıgım koda göre gel diyebiliriz

        //    buda tam olarak sanal metotun acıklaması oluyor

        //    musteri nesnesi olusturalım nesnemizi ornekleyip cagıralım namespace.class adını geldıgını gorelım ve nası degistiririz onu görelım

        //    Musteri classına gidelim

        //    1. not bitiş

        //    2. not bitiş

        //    3. not başlangıç

        //    3 adet prob ekledik musteriye şimdi new leyelim
        //    V152Musteri M1 = new V152Musteri();
        //    M1. dedigimiz de içeriye eklediğimiz 3 adet prob ve ek olarak farklı sınıf lar geldi bunlar object metotunun içerisinden geldi
        //    //M1.Equals
        //    //M1.GetHashCode
        //    //M1.GetType
        //    //M1.ToString
        //    //M1.musteriID
        //    //M1.isim
        //    //M1.soyisim

        //    tostring için bakalım

        //    m1.tostring dedik bunu string üzerine aldık => string toStringMesaj = M1.ToString();

        //    sonrada cıkan degeri konsola yazdırdık => Console.WriteLine("toStringMesaj : " + toStringMesaj);

        //    kosola ne gelmesi lazım ? namespace.class adı gelmesi lazım

        //    console.writeline a breakpoint koy calıstır

        //    çıktısı

        //    toStringMesaj : Bolum_17_OOP_Sanal_Metot.V152Musteri

        //    bu sanal metotların ana davrasını oluyor bunların body sini degistirmekten bahsettik

        //    musteri class ına gidip tostring metotunu degistirelim

        //    3. not bitiş

        //    4. not bitiş

        //    5. not baslangıc

        //    override etmeden once debug yaparken tostring in içine f11 ile gidemedik sanal metot cunku
        //    musteri class ının ıcınde bunu guncelledık buraya geldik tekrar debug yapalım bakalım ne olacak
        //    isim soyisim yaptıgımız için birde atama yapalım bos gelmesin
        //    calıstırınca f11 ile devam edince musteri class ına gönderiyor ve override ettıgımız yere dusuyor kod 

        //    override ettıgım gibi calısıyor kendı calısma mantıgı olarak calısmıyor 

        //    ders bitti diger derste kendımız sanal metot olusturalım kalıtmıs oldugumuz nesnemizin içerisinde nası kullanırız bunlara bakalım

        //    */

        //    // 3. not

        //    V152Musteri M1 = new V152Musteri();
        //    M1.isim = "Mücahit";
        //    M1.soyisim = "Çetinkaya";
        //    string toStringMesaj = M1.ToString();


        //    Console.WriteLine("toStringMesaj : " + toStringMesaj);


        //}

        #endregion

        #region VİDEO 153 Sanal metot oluşturmak ve kullanmak - 1

        //static void Main(string[] args)
        //{
        //    /*

        //    Bolum 17 OOP Sanal Metot V153 Sanal metot oluşturmak ve kullanmak - 1

        //    */

        //    /*

        //    1. not başlangıç

        //    baseClass adında bir class olusturalım

        //    BaseClass a gidelim

        //    1. not bitiş

        //    3. not bitiş urun class ından geldik

        //    4. not baslangıc

        //    oncelıkle urun nesnesini new leyelım

        //    V153Urun U1 = new V153Urun();
        //    U1.EkranaYaz("urun nesnesınden bu metot cagrıldı");

        //    urun de baseclass ı miras verdik
        //    urunden baseclass daki metotu cagırdık

        //    birde aynı metodu baseclass dan cagıralım

        //    V153BaseClass B1 = new V153BaseClass();
        //    U1.EkranaYaz("BaseClass nesnesınden bu metot cagrıldı");

        //    V153Urun U1 = new V153Urun(); e breakpoint koyalım ve debug yapalım sırayla urunden baseclass a gittiğimizi gorelim baseclass dan cagırınca da aynı metot calıstı

        //    bu benim kalıtımın standart calısma seklı biz ozellık kazandırmak istiyoruz 

        //    biz baseclass içindeki metodu ellemezsek oldugu gibi calıssın ama modifiye edersek hiç base class a gitmesin ururn nesnesınden modifiye ettıgımız sekılde calıssın

        //    baseclass daki metotu sanal metot olarak olusturalım

        //    baseclass a gidelim

        //    4. not bitiş

        //    6. not bitiş baseclass dan geldik

        //    7. not baslangıc

        //    V153Urun U1 = new V153Urun(); e breakpoint koyalım debug yapalım


        //    */


        //    //V153Urun U1 = new V153Urun();
        //    //U1.EkranaYaz("urun nesnesınden bu metot cagrıldı");


        //    //V153BaseClass B1 = new V153BaseClass();
        //    //U1.EkranaYaz("BaseClass nesnesınden bu metot cagrıldı");

        //    // 7. not
        //    V153Urun U1 = new V153Urun();
        //    U1.EkranaYaz("merhaba");


        //    V153BaseClass B1 = new V153BaseClass();
        //    U1.EkranaYaz("merhaba");


        //}

        #endregion

        #region VİDEO 154 Sanal metot oluşturmak ve kullanmak - 2

        //static void Main(string[] args)
        //{
        //    /*

        //    Bolum 17 OOP Sanal Metot V154 Sanal metot oluşturmak ve kullanmak - 2

        //    */

        //    /*

        //    1. not başlangıç

        //    V154Urun U1 = new V154Urun(); e breakpoint koyarak debug yapacagız

        //    kalıtım içerisinde urun nesnesı orneklenırken baseclass ı ornekleyecek ve urun nesnesınden bır ornek almıs oldugumuz ıcın overrıde edılen ekranayaz metotu urunun altındakı ekranayaz metotu calısacak

        //    baseclass hiç bir yerden standart bir ornek alamadıgı ıcın dırek olarak obkect nesnesınden orneklendıgı ıcın baseclass ın ıcındekı halı gıbı calısmaya devam edecek 

        //    ----------------------
        //    kendı notum
        //    yani türkçesi diyorki 
        //    U1 calısırken urune gidecek urun basecalss ı miras almıs ama override oldugu için içinde urunun altındaki metot calısır baseclass ı ezer
        //    B1 calısırken zaten baseclass a gidecek herhangi bir override yok kendısı oldugu gibi calısır 

        //    aynı metot ama override ve virtual ile farklı yerlerden cagırıp farklı ıslemler yaptırıyorsun
        //    ----------------------

        //    breakpoint koyarak debug yapalım 

        //    u1 deyız u1 in ustune gelince tostring den namespace adını gösterir
        //    u1 baseclass dan miras aldı ama override oldugu için urunun altındaki ekranayaz calıstı
        //    b1 e gidince de baseclass a gider virtual var orda zaten kendınden turetilmiş ana class zaten direk o calısır

        //    bir ust class daha olusturalım bakalım ne olacak

        //    televizyon class ını olusturalım 

        //    1. not bititş

        //    2. not bitiş televizyondan geldik

        //    3. not baslangıc

        //    televizyonu ornekleyıp bakalım hangisi calısacak



        //    */


        //    V154Televizyon T1 = new V154Televizyon();
        //    T1.EkranaYaz("HANGİSİ");

        //    V154Urun U1 = new V154Urun();
        //    U1.EkranaYaz("merhaba");


        //    V154BaseClass B1 = new V154BaseClass();
        //    B1.EkranaYaz("merhaba");


        //}

        #endregion

        #region VİDEO 155 Sanal metot oluşturmak ve kullanmak - 3

        //static void Main(string[] args)
        //{
        //    /*

        //    Bolum 17 OOP Sanal Metot V155 Sanal metot oluşturmak ve kullanmak - 3

        //    */

        //    /*

        //    1. not başlangıç

        //    televizyonu ornekleyıp bakalım hangisi calısacak

        //    155 CLASS larının hepsine ctor ekleyelim ve sırasına bakalım nereye gidiyor nası calısıyor görelim

        //    t1 e breakpoint koyunca ctorların calısma sırası
            
        //    baseclass ctor
        //    urun ctor
        //    televizyon ctor

        //    hepsini tarıyor ve nerde ne var biliyor

        //    t1.ekranayaz da f11 ile gidince urun ıcındeki ekranayaz calısır
        //    override oldugundan orada tıkanır digerlerini ezer

        //    urun class ı hep kendi karsılar override oldugundan digerlerine aktarmaz

        //    */


        //    V155Televizyon T1 = new V155Televizyon();
        //    T1.EkranaYaz("HANGİSİ");

        //    V155Urun U1 = new V155Urun();
        //    U1.EkranaYaz("merhaba");


        //    V155BaseClass B1 = new V155BaseClass();
        //    B1.EkranaYaz("merhaba");


        //}

        #endregion


    }
}
