
using System;

namespace Bolum_18_OOP_Interface_Abstract
{
    internal class Program
    {
        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion


        #region VİDEO 157 Interface ve Abstract genel olarak nedir ?

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 18 OOP Interface ve Abstract V157 Interface ve Abstract genel olarak nedir ?

        //     */

        //    /*

        //    1. not başlangıç

        //    Bu bölümde abstract ve interface nedir bunlar üzerinde biraz konuşuyor olacağız

        //    Object orientent  konusunun artık sonlarına geldik

        //    Bu bölümden sonra nesne yönelimli programlama kısmında bir çok şeyi anlamış ve kullanmış oluyoruz bunun sonrasında ise farklı bölümler ile aslında nesne konuları tekrar bizim karşımıza cıkacak

        //    Bu bölüm ve bu bölümden sonra anlatılanlar artık ileri C# olarak size sunulacaktır

        //    -------------

        //    Abstract & Interface

        //    C# nedir, neden kullanırız avantajları nelerdir.

        //    Abstract & Interface

        //    C# programlama dilinde aslında VIP dediğimiz alana geldik bu bölümde öğreneceğiniz konuların örnek kullanımları ve açıklamaları uygulama yaptığımız zaman net olarak anlaşılacaktır.
        //    Bölüme başlamadan önce neden bu bölümden VIP olarak bahsetmiş olduğumu anlatayım.
        //    Interface veya abstract ( Interface daha sık kullanılır ) aslında bizim uygulama içerisinde kullanmayacağımız ama her noktada varlığından faydalanacağımız tanımlardır.
        //    Kurumsal projelerde kodlama yapacağımız zaman çok sık göreceğimiz bu kavramları kendi başımıza proje yaptığımız zaman ( tasarım deseni zorunlu değilse ) kullanmayız.
        //    Fakat kurumsal projelerde bir ekibin kodlamasında görev alıyorsak sık kullandığımız tanımlardır.

        //    Hatırlarsanız nesne yönelimli programlama konusunda girdiğimiz bölümlerden bu yana devamlı olarak nesnelerimizi oluşturduk farklı kullanımlar olsa bile bir şekilde nesnemizi örnekledik kullandık.
        //    Nesnelerimizin içerisinde ise birçok tanım oluşturduk ve bu tanımları çağırıp kullandık.
        //    Abstract ve Interface tanımlarında bir örnekleme söz konusu değildir.
        //    Kendimize işe yapacak bir rol model çıkartırız. Nasıl olacağının kurallarını hazırlar ve nesnelerimiz de kurallarmızı kullanırız.
        //    Bu bölümde oluşturmuş olduğumuz nesnelerimizi nasıl kurallar ile şartlayabileceğimizi konuşacağız.
        //    Not : Bu bölümde anlatılan konular biraz havada kalabilir bu konuların sizin pratiğinizde oturabilmesi için bizim biraz ilerlememiz gerekir.




        //     */

        //}

        #endregion

        #region VİDEO 158 Abstract Nedir - Abstract class kullanımı

        //static void Main(string[] args)
        //{

        //    /*

        //            Bolum 18 OOP Interface ve Abstract V158 Abstract Nedir - Abstract class kullanımı

        //    */

        //    /*

        //    1. not başlangıç

        //    Nesne yönelimli programlama da herşeyin başında bir nesne oluşturup bunların içinde field metot atadık kalıttık static leri gördük bir çok işlem yaptık
        //    Bu işlemlerim ortasında yaptığımız işlemlerimizi daha da profesyonelleştirmek için kullanılan bu iki tanımıda bu oluşturmuş olduğumuz class larımızın içerisinde kullanacagız
        //    Sınıf olusturup bildigimiz şekilde inceleyelim daha sonra bu sınıfın hayatına bir abstract gelirse ne olur bundan bahsedelim.
        //    yeni bir class olusturalım

        //    temelSınıf a gidelim

        //    1. not bitiş

        //    2. not bitiş temelSiniftan geldik

        //    3. not baslangıc

        //    temelSinif i newleyelim

        //    V158temelSinif T1 = new V158temelSinif();

        //    temelsınıf orneklenirken bir yerden kalıtılmıs mı diye bakar katılmamıssa obje den kalıtır kendını

        //    sımdı bunu abstract yapalım

        //    3. not bitiş temelSınıf a gidelim

        //    4. not bitiş temelsınıftan geldik

        //    5. not baslangıc

        //    temelSinif i abstract yapınca V158temelSinif T1 = new V158temelSinif(); hata verdi

        //    new kısmında hata veriyor yani diyoki bunu ornekleyemezsin diyo abstract ve interface oldugunda orneklenemez

        //    temelSınıfı şablon olarak ayarladık nerde kullanacagız

        //    bir baska sınıfta kullanacagız 
        //    nasıl kullanacagız bakalım

        //    yeni bir sınıf olusturalım musteri oraya gidelim

        //    5. not bitiş

        //    6. not bitiş musteriden geldik

        //    7. not baslangıc

        //    musteri nesnesini ornekleyelim m1. dediğimiz de temelsınıftaki prop larda bana geliyor

        //    m1 e breakpoint koyalım ve bakalım 
        //    musteri nesnesine gidecek musteride temelsiniftan kalıtılmıs temelsınıfa gitmeliyim diyor ama temelsınıfa giderken uygulama bunun abstract sınıf oldugunu biliyor
        //    temel sınıfa gidiyor ve ctor calısıyor

        //    yani abstract olunca abstract olan nesne orneklenemiyor ama kalıtım yoluyla orneklenebiliyor
        //    ayrıca miras aldıgı probları da görüyor ve kullanabiliyor 

        //    temelsınıfa gidelim

        //    7. not bitiş

        //    8. not bitiş temelsınıftan geldik

        //    9. not baslangıc

        //    temelsınıf içinde metot olusturduk bunu musteri yanı m1. diye cagıralım
        //    m1.test();
        //    calısıyor sorun cıkartmadı

        //    ben bir sınıfın içindeki bir metotu böyle kullanıyorsam 
        //    kalıtılan nesne kalıtan nesneyi orneklemek zorunda yoksa class ın mimarisi bozulur

        //    orneklenmemiş bir class ın içindeki bu sekılde yazılmıs static olmayan bir metotu ben kullanamam 
        //    kullanabilmem için o nesnenin diger nesneyi ben ornekleyemesem de ornekleyip bana sunması gerekiyor

        //    ben class a direk mudahale ile ornekleyememem problem degil 
        //    problem su benım orneklemıs oldugum nesne temelsınıf nesnesini orneklemek zorunda cunku kalıtım kuralları var 
        //    ben diyo base olarak gormus oldugum sınıfın içindeki field ları metotları public duzeydeyse internal duzeydeyse private degilse yani sana kullanıma acarım diyo 
        //    bana kullanıma acman için bu metodun bellekte ayaga kalkması lazım 
        //    demekki bu abstract class kavramında ornekleyememe sadece ilk cagırımlarda gecerlı oluyor kalıtım konusunda gecerlı degıl 

        //    abstract keyword unu alıp bir metotun içine yerleştirsem sen abstract bir class ın ve içinde de abstract bir metot olsun o zaman ne olacak

        //    temelsınıf a gidelim abstract metot olusturalım

        //    9. not bitiş

        //    10. not bitiş diger derse geç temel sınıf içinde bitti ders



        //    */

        //    //5. notta abstract yapınca hata verdi
        //    //158temelSinif T1 = new V158temelSinif();

        //    // 7. not baslangıc

        //    V158Musteri m1 = new V158Musteri();
        //    m1.test();

        //}

        #endregion

        #region VİDEO 159 Abstract metot nedir , kullanımı

        //static void Main(string[] args)
        //{
        //    /*

        //    Bolum 18 OOP Interface ve Abstract V159 Abstract metot nedir , kullanımı

        //    */

        //    /*

        //    1. not baslangıc

        //    V158 in sonu temel sınıf içinde bitiyor V159temelsınıf olusturalım ve aynı senaryoyu olusturalım Musteri sınıfını olusturalım

        //    1. not bitiş temelSinif a gidelim

        //    3. not bitiş musteriden geldik

        //    4. not baslangıc

        //    musteri class ını new leyelim


        //    V159Musteri M1 = new V159Musteri();
        //    M1.test(); // temel sınıf içindeki test
        //    M1.testAbstract(); // musteri içindeki testAbstract

        //    debug yapalım 

        //    M1.testAbstract(); e breakpoint koyalım
        //    buraya gelince musteri içine dustu orada calıstı temelsınıf içindeki testAbstract calısmadı cunku oraya gondersede calısacak bir body si yok orada

        //    6. dk

        //    su ana kadar ne görduk

        //    abstract bir class nası yapılır bunu görduk
        //    abstract class ların ilk cagırım da orneklenemedigini ama kalıtımsal acıdan baktıgımız da kalıtan nesnenin abstract class ı ornekleyebildigini gorduk 
        //    abstract olan bir metot olursa bunun body si olmaz bunu imza olarak ekliyoruz bunu ekledıgımız nesneyi kalıtan bir nesne var ise bunu orada implement yapmak zorundayız

        //    bunu ne zaman kullanırız

        //    ekip olarak calıstıgımızı dusunun herkes farklı bir bölüm yazıyor database e giden bir metot seklimiz olmalı sımdı ben musteri class ını yazıyorum ona göre rolum var
        //    arkadasım sıparıs yazıyor digeri e ticaretten login leri ayarlıyor içerisi biraz curcuna yani herkes kendıne göre bir seyler yapmak ıstıyor 
        //    ben metotun adını testabstract yazdım obur arkadasım aynı metot olsun diye herkesın kendı class ında aynı metotdan aynı metot imzalarıyla bulunsun diye bir karar verdik 
        //    bizden sonraki yazılımcılar için de kolaylık olsun yada birisi gelmez işten cıkar vs biz onun kodunu devralmak istersek bizimde basımıza farklı seyler gelmesın diye standarta oturtmak istiyoruz

        //    ama gel görki t sini yazmadın klavye basmadı herhangi bir kodlama hatası oldu herkes böyle bişey yapsa noldu ortaya acayip metotlar cıkmıs oldu 
        //    herkesın kendı standartlarına gore yazmıs oldugu bir mimariye kavusmus olduk 
        //    artık birisi ekipten ayrılsa izine cıksa içeride yine bir surecsel uzama olur bunu anlayıp cozeceksin ben bunu anlamayamadım arkadas cok degisik kodlamıs dedıgınız senaryolar olabilir 

        //    interface ve abstract bu noktada yardımcı olur 
        //    sen sablon olustur insanlara dagıt bunu kullanmak zorunda kalsınlar 
        //    dolayısıyla developerler metot imzası ile ugrasmaz class alır implement eder içini doldurur gecer bir standarta kavusmus oluruz 

        //    */

        //    // 4. not baslangıc

        //    V159Musteri M1 = new V159Musteri();
        //    M1.test(); // temel sınıf içindeki test
        //    M1.testAbstract(); // musteri içindeki testAbstract

        //}

        #endregion

        #region VİDEO 160 Abstract ile sealed kullanılır mı ?

        //static void Main(string[] args)
        //{

        //    /*
              
        //        Bolum 18 OOP Interface ve Abstract V160 Abstract ile sealed kullanılır mı ?
             
        //     */

        //    /*
            
        //    1. not baslangıc

        //    V160-temelSinif-Musteri class larını olusturalım V159 dan alabiliiriz notlarını

        //    abstract metot olusturup temelSinif içinde Musteri de temelSinifi miras verdik
        //    temelSinif içinde abstract metot oldugundan imzasını attık sadece body si yok
        //    Musteri de bunu implement yapıp cagırdık ve kullandık kullanmak zorunda bırakıldık şablon oldu

        //    Musteri nesnesini de kalıtırsak temelSinifa ulasacagım bu sürecte testAbstract kısmını gorurmuyuz gorursek bunun tooltype in de ne yazar nerde oldugunu gorurum 
        //    temelSınıf içinde olan prob ları musteriden kalıtmıs oldugum nesne de gorur muyum 

        //    Musteri yi baseClass yapalım
        //    SuperMusteri adında bir class olusturalım

        //    SuperMusteriye gidelim

        //    1. not bitiş

        //    2. not bitiş supermusteriden geldik

        //    3. not baslangıc

        //    supermusteriyi newleyelim bakalım diger metot veya prob lara erişim var mı 

        //    V160SuperMusteri S1 = new V160SuperMusteri();
        //    S1. diyince metot veya prob lara erişebiliyoruz 

        //    problar neredeyse ordan gelmiş 
        //    metot musteriden gelmiş temelsınıf içinde olusturuldu ama orada abstract body si yok kullanılan yer musteri ondan dolayı orayı kullanıyor

        //    V160SuperMusteri S1 = new V160SuperMusteri();

        //    S1.guncellemeTarih = Convert.ToDateTime("2025-08-09"); // temelsınıf içindeki
        //    S1.kayitTarih = Convert.ToDateTime("2025-08-09"); // temelsınıf içindeki
        //    S1.musteriID = 1; // musteri içindeki
        //    S1.test(); // temelsınıf içindeki
        //    S1.testAbstract(); // musteri içindeki

        //    temelsinifa gidelim

        //    3. not bitiş

        //    4. not bitiş temelsınıftan geldik

        //    5. not baslangıc

        //    genel notlar

        //    abstract sınıflar türetilmez direk ulasıp kullanılmaz
        //    abstract sınıflar abstract metotlar içerir sadece imzası olur body si olmaz 
        //    abstract sınıflar standart metotlar içerir imza ve body si de olabilir

        //    istersek standart metot yazarız istersek abstract metot yazar türetilen sınıf uzerınden body sını yazabiliriz

        //    abstract sınıflar içinde static metotlar yazılabilir ornek olusmadan cagrılabilir
            
        //    V160temelSinif.testAbstract2(); // static metot new lemeden cagırdık

        //    metotlar static ve abstract aynı anda olamaz 

        //    abstract metot virtual olamaz body si olması lazım body si yok zaten abstract oldugunda miras aldıgı yerde override olacak mecbur 

        //    diger ders interface birden fazla sınıfı kalıtamadıgımızı gormedık onu görecegız ordan da interface e gececegiz

        //    5. not bitiş

        //    */

        //    // 3. not baslangıc

        //    V160SuperMusteri S1 = new V160SuperMusteri();

        //    S1.guncellemeTarih = Convert.ToDateTime("2025-08-09"); // temelsınıf içindeki
        //    S1.kayitTarih = Convert.ToDateTime("2025-08-09"); // temelsınıf içindeki
        //    S1.musteriID = 1; // musteri içindeki
        //    S1.test(); // temelsınıf içindeki
        //    S1.testAbstract(); // musteri içindeki

        //    // 5. not baslangıc

        //    V160temelSinif.testAbstract2(); // static metot new lemeden cagırdık


        //}

        #endregion


    }
}
