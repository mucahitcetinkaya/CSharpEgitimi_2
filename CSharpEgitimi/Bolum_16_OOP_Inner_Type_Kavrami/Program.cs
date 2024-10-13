using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolum_16_OOP_Inner_Type_Kavrami
{
    internal class Program
    {

        //#region VIDEO

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VIDEO 144 Bilgilendirme

        //static void Main(string[] args)
        //{
        //    /*

        //     Bolum 16 OOP Inner Type Kavrami V144 Bilgilendirme

        //    */

        //    /*

        //    1. not başlangıç 

        //    OOP - Inner Type

        //    Nesne yönelimli programlama - İç içe nesne kullanımı

        //    Bu bölümde nesne yönelimli programlama da inner type nedir bunu inceleyeceğiz

        //    Bu bölüm içerisinde aşağıdaki konular ele alınacaktır.

        //    Inner Type Nedir ?

        //    Neden Kullanılır ? Bir ihtiyaç mıdır ?

        //    Örnekler ile innertype kullanımı

        //    Bölüm sonu uygulaması

        //    Nesne yönelimli programlama konusunda sık kullandıgımız bir tanımlama olan ınnertype olarak isimlendirdiğimiz iç içe nesne kullanımı konusuna geldik.
        //    Aslında bu zamana kadar da bilinçsiz bir şekilde kullanıdıgımız bir kavramdı sistemin tiplerini kendi özel tiplerimizin içerisinde kullandıgımızda da 
        //    aslında bir innertype yapıyoduk nedeni .netframework zaten genel olarak bir class mimarisi üzerine kurulu 
        //    kendi veri tipleri de arka tarafta class olarak barınmakta.

        //    bundan dolayı class içerisinde class kullanmak innertype ın tam karsılıgıdır

        //    innertype nedir neden kullanırız 

        //    innertype i kullandıgımız yerler ilişkisel veri tabanı modellerimizi uygulama katmanında örnekleyebilmek datamızı daha dogru daha okunabilir 
        //    şekilde tek bir class içerisinde toparlayabilme isteğimizdir
        //    yazmıs oldugumuz uygulamalarımız da bir musteri dediğimiz zaman aslında o musterinin bir cok farklı ozellıgıni database tarafında 
        //    ilişkisel tablo duzeyınde dagınık bir şekilde tuttugumuz için bunun C# programlama tarafında ise yine dagınık bir şekilde olan nesneleri 
        //    tek bir nesnenin içerisine toparlayarak datayı bir bütün olarak elde ederiz 

        //    tabiki ilişkisel veri tabanını bilen arkadaslarımız oldugu gibi bilmeyen arkadaslarımız da vardır 
        //    ilişkisel veri tabanından biraz bahsetmek gerekirse aslında şudur 

        //    örnek olarak bir Musteri tanımına geldiğimiz de 
        //    musterimizin id si ismi soyismi bize ne zaman kayıt oldugu iletişim bilgileri ve bizden yapmıs oldugu alısverişlerin bir listesi 
        //    aklımıza en basit sekilde gelenlerdir

        //    biz bunu ilişkisel veri tabanı dedıgımız mantıkla dagıtacak olursak 
        //    Oncelıkle musteri nesnesi olusturmak gerekiyor 
        //    musterinin id si olur id uniqe tir ve bir tane olur bunu int olarak tutabiliriz
        //    isim ve soyisim degerleri de o musteriye ait tekil degerlerdir string olarak tutulabilir
        //    musterinin database e kayıt tarihi datetime tipindedir
        //    peki musterinin adres bilgisi
        //    musterinin bir cok adresi olabilir
        //    ev iş veya birden fazla da iş adresleri olabilir yani bir adresleri olabilir

        //    bundan dolayı adreslerini farklı bir data kumesı üzerinde tutmak isterim 

        //    burda adres bilgileri yer alır 
        //    adresin tanımı
        //    il ilçe mahalle vs 
        //    ve adresin kendisi 

        //    burası 1 e n bir yapıda olur yani
        //    1 müşterinin n tane adresi olabilir 

        //    aynı sekılde iletişim bilgileri de bu sekildedir
        //    cep mi ev mi iş mi 
        //    dahili numarası vs 

        //    sımdı ben bunların hepsini musteri nesnemin içerisinde toparlamak istersem 

        //    Musteri class ının içinde 1 den fazla adres olabilmesi için bir arraylist adres tipinde tutabilirim
        //    Musteri class ının içinde 1 den fazla iletişim olabilmesi için bir arraylist iletişim tipinde tutabilirim

        //    su an arraylist i bildiğimiz için arraylist diyorum
        //    ilerleyen konularda list generic anlatıldıgın da bu arraylist lerin hepsi list generic olacak 

        //    bir dizi yani bir koleksiyon içeriye atmam gerekiyor 
        //    koleksiyonun içericeği deger Adres tipi Iletisim tipi olmalı 

        //    Musteri içerisinde olusturdugumuz Custom nesnelerimizi cagırdıgımız zaman 
        //    nesne içindeki nesneyi
        //    aslında bir innertype yapmıs oluyoruz 

        //    ben Musteri nesnesine odaklandıgım da musterinin ve musterinin içerisinde bulunan
        //    adres ve iletişim bilgilerinden yararlanarak musterinin tum datasına erişip
        //    uygulama katmanında kullanabilirim
        //    nesne yönlü programlama da gerçek hayatta innertype lar standart olarak kullanılır 
        //    tek basına bir nesnenin kullanılması cok dusuk bir ihtimaldir

        //    nası bir ihtimal olur il ilçe gibi il ilçe mahalle gibi
        //    veya bazı standart tanımlar nesne tekil olarak hiç bir farklı ozel nesneye ihtiyac duymadan cagrılıp kullanılabilir
        //    ama musterı kullanıcı urun ve benzeri openasyonel surecler içerisinde yaptıgımız ve kullandıgımız nesnelerimiz
        //    tamamiyle kendi içlerinde iç nesneler yani innertype lar barındırır

        //    -------------------------------

        //    Bir ihtiyaç mıdır ?

        //    evet anlatmıs oldugum openasyonel işlemler de bir ihtiyactır 
        //    database iniz de farklı tablolar uzerınde duran datalarımızı birleştirmeye yarayan bir tanımdır 

        //    database bolumune gectiğimiz de ilişkisel veri tabanı konusunu detaylı olarak anlatacagım 
        //    bu noktada bir veri kumesını parcalarayak tablolama olarak bilmenız yeterli 

        //    */

        //}

        #endregion

        #region VIDEO 145-146 Inner Type Modelleme - 1 - 2

        //static void Main(string[] args)
        //{

        //    /*

        //     Bolum 16 OOP Inner Type Kavrami V145 - V146 Inner Type Modelleme - 1 - 2


        //    */

        //    /*

        //    1. not baslangıc

        //    Once ne yapmak istiyoruz Musteri nesnesine ihtiyacımız var onu olusturalım 
        //    Musteri145 olacak

        //    Musteri145 e gidip orda devam edelim

        //    1. not bitiş

        //    7. not bitiş

        //    8. not baslangıc

        //    Musteri145 i ornekleyelim

        //    145 ve 146. videolar ortak oldu surelerı kısa oldugu için 
        //    147. video uzun olacak ornekleme ve devam etme anlatma metotlar vs olacak ordan devam edelim

        //    */

        //    Musteri145 M1 = new Musteri145();

        //}

        #endregion

        #region VIDEO 147 Inner Type Modelleme - Incelemesi

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 16 OOP Inner Type Kavrami V147 Inner Type Modelleme - Incelemesi

        //    */

        //    /*

        //     1. not baslangıc

        //    video 145 ve 146 daki class ları 147 olarak tekrar acalım notlar orda kaldı burda anlatımları olacak karısmamıs olacak
        //    Musteri147 MusteriAdres147 MusteriIletisimBilgisi147 MusteriSiparis147
        //    nesneleri public yapalım ve içerisindeki propları da yazalım

        //    Nesneleri olusturduk prop larını yazdık public yaptık
        //    Musteri147 i ornekleyelim breakpoint koyup bakalım start yaptık

        //    neler olacak 

        //    Musteri147 den M1 diye bir nesne orneği alacagım 
        //    almıs oldugum M1 steak tarafta içerisiyse heap bölgede acılırken 
        //    aslında içeride tanımlamıs oldugum field ların default degerlerini alacaklar 
        //    int 0 string ler null boolean lar false gibi degerler alacaklar 

        //    olusturmus oldugum dizilerim ise bakalım nası bir davranıs sergileyecekler 

        //    f10 ile gidip M1 in içine bakalım

        //    olusturmus oldugum diziler koleksiyonlar da null olarak bir default deger aldıgını görebilirsiniz

        //    ben m1 üzeirinde isim kullanıciId musteriId olusturmaTarihi soyIsim tcKimlikNumarasi yani 
        //    aslında koleksiyon dısarında olan bütün degerlerime bir atama yapmak istiyorum

        //    daha sonra içeride dizi olarak olusturmus oldugum degerlerime göre atama yapmak istiyorum

        //    buradaki atamalarda bir problem yasayacak mıyım 
        //    programı durdurup atamalara baslayalım

        //    M1.musteriId = 1; gibi vs 


        //    // burdan sonra inner type lara gecelim

        //    M1.musteriAdres147Liste[0] = new MusteriAdres147() { };
        //    musteriAdres147 nin 0. index ine atama yapıyoruz

        //    M1.musteriAdres147Liste[0] = new MusteriAdres147()
        //    {
        //        Il = "Istanbul",
        //        Ilce = "Beşiktaş",
        //        Adres = "Adres...",
        //        AdresTip = "İş Yeri"
        //    };

        //    süslü parantez içinde new ile atama yapmayı göstermiştik
        //    M1 Musteri147 oluyor Musteri147 nin içindeki MusteriAdres147 e gidip onun field larına ulasıyoruz

        //    şimdi ben bir musteri nesnesi olusturdum
        //    olusturmus oldugum musteri nesnesi içerisindeki musteriadresleri koleksiyonunun 0. index ine bir musteriadres tanımı yaptım
        //    farkındaysanız musteriadreste benim ozel tipim musteri de benım özel tipim

        //    ben tam olarak burda bir hata almak istiyorum
        //    almıs oldugum hata yapıcı metotun onemını vurgulayacak hata alacagım sekılde yazdım

        //    tekrar calıstıralım 

        //    musteri orneklecek adres kısmında bir hata verecek

        //                hata alınan kısım

        //     Musteri147 M1 = new Musteri147();
        //    M1.musteriId = 1;
        //    M1.tcKimlikNumarasi = "12345678901";
        //    M1.isim = "Mücahit";
        //    M1.soyIsim = "Çetinkaya";
        //    M1.olusturmaTarihi = DateTime.Now;

        //    // burdan sonra inner type lara gecelim

        //    M1.musteriAdres147Liste[0] = new MusteriAdres147()
        //    {
        //        Il = "Istanbul",
        //        Ilce = "Beşiktaş",
        //        Adres = "Adres...",
        //        AdresTip = "İş Yeri"
        //    };

        //    System.NullReferenceException: 'Nesne başvurusu bir nesnenin örneğine ayarlanmadı.'

        //    bu hatanın sebebi dk 4.30

        //    içeride koleksiyon olarak tanımlamış oldugum inner type ların default degerleri null seklinde
        //    henuz ben dizilerimi = new ile orneklemedıgım için bu hatayı aldım

        //    bunu yapmanın 2 farklı yolu var 

        //    dilerseniz musteri nesnesini olusturdugunuz her yerde yazacagım kodu yazmak zorundasınız 
        //    yada tek bir de yazarak bu referans lama işlemini çözebilirsiniz

        //    ornek olarak new liyoruz kac adres almak istiyoruz mesela 5 olsun

        //    M1.musteriAdres147Liste = new MusteriAdres147[5];

        //    nesne orneklenecek sonra MusteriAdres147 new lenecek 5 elemanlı boş bir dizi olusturacak
        //    ve ben 0. index ine bir deger ataması yaptıgım da her hangi bir hata ile karsılasmayacagım

        //    M1.musteriAdres147Liste = new MusteriAdres147[5];
        //    buna breakpoint koyalım

        //    üstteki adreslerim dolu musteriAdresleri kısmım null olarak geldi 
        //    benim bu null olan innertype ımı new ile örneklemem lazım 
        //    benim nesnelerim üzerlerine deger almadan standart tek bir nesne de olsa bunu yapacaktı 
        //    new ile örneklenmeli ki kendi içinde de steak heap kırılımı olsun 

        //    new ile orneklendıgın de musteriAdresleri kısmında 5 elemanlı bir dizi olarak sisteme kendini tanıtmıs oldugunu görebiliyoruz

        //    ve 0. index ine yeni bir musteriAdresi ataması yapacagız 
        //    bunu gectıgımız de de herhangi bir hata almadık 0. index ine atama yaptı 

        //    ben bunu bir secenek olarak her yerde cagırmalıydım ne zaman ben musteri nesnesi kullansam bunu hep new ile orneklemem lazım o zaman

        //    bu böyle yapılmaz
        //    neden
        //    tekrar eden kodlar olur unutulabilir degistirmek istenilebilir o zaman da bütün kodlar da degisiklik gerekir uzun süre alır 

        //    bizim bu tip koleksiyonları inner type ları örnekledıgımız yerler ilgili ana tipin yapıcı metotudur

        //    yani bu böyle yapılmaz!!

        //    M1.musteriAdres147Liste = new MusteriAdres147[5];

        //    burda da calısır ama yeri burası degil 

        //    musteri nesnesine gidip ctor olusturup orda new leyelim 

        //    1. not bitiş

        //    2. not bitiş

        //    3. not baslangıc

        //    Musteri147 M1 = new Musteri147(); breakpoint koyalım

        //    öncelikle nesne örneklenmeye calısacak bu calısırken yapıcı metot calısacak 
        //    nesne orneklendıgın de ınnertype lar da orneklenmıs olacak

        //    yani ben new musteri dedigim de ana tipim musteri yanında bu musterıye baglı olan tum koleksiyonlarımı sisteme tanıtmıs olacagım 

        //    ve atama işlemi yaparsam sistem null referance hatası vermeyecek 

        //    f11 ile gidince yapıcı metota dusuyor 

        //    .net framework deki oop nin cok onemlı bir noktası burası bir nesne orneklenırken yapıcı metot siz ezmezseniz kendi default unda arka planda calısır 

        //    ezerseniz bu sekılde mudahale edebilir ve olusmasını istediğiniz ilk nesne olusurken yapılmasını istediğiniz bütün işleri buraya koyabilirsiniz

        //    ilgili işlemleri buraya koydugunuzda da ise o müsteri nesnesi yada herhangi bir nesneyi nerde cagırırsanız cagırın arka tarafta bir logic olusturmus 
        //    olusturmus oldugunuz bu logic i tek bir noktadan yönetebilirsiniz

        //    şimdi bana birisi desin ki sen musteri nesneni uygulama içinde yuz bin yerde kullandın hadi bunların musteri adreslerını 10 elemanlı bir dizi yap
        //    boyle yaptıgımız da musteri class ına gidip sadece yazdıgımızı 10 yapmak olacak
        //    diger turlu bütün yerlerde degisiklik gerekir 

        //    devam ettiğimiz de koda ctor da hepsi orneklendi geri program.cs e geldi kod 
        //    m1 içine baktıgımız da butun koleksiyonlar da orneklenmıs oldu kac elemanlı yazdıysak artık 

        //    ilk once m1. ile atamaları yapıyor sonra da 0. index e atama yapıyor 

        //    M1.musteriAdres147Liste[0] = new MusteriAdres147() gelince 
        //    musteriadres147liste nin de yapıcı metodu calısacak 

        //    bu da bir class her class ın bir yapıcı metodu vardır 
        //    ben bu yapıcı metotları duzeltebilirim
        //    musteriadres147liste nin yapıcı metotu na birşey eklemediğim için arka tarafta benım görmediğim bir yapıcı metot calısacak

        //    buna da mudahale edersem bunun da yapıcı metotunu calıstırabilirim

        //    f11 ile devam edince de 0. index e gerekli atamayı yaptı 

        //    MusteriAdres147 e gidip bir yapıcı metot ekleyelim

        //    3. not bitiş
        //    4. not bitiş

        //    5. not baslangıc

        //    MusteriAdres147 e yapıcı metot yazdık bir cw yazdık sadece oraya da gidip calıstıgını görmek için

        //    bütün breakpoint leri kaldıralım 

        //    M1.musteriAdres147Liste[0] = new MusteriAdres147() buraya breakpoint koyalım

        //    burası calısırken MusteriAdres147 nin yapıcı metotuna gidecek 
        //    kendi özel tiplerinizin yapıcı metotları inner type olsada calısacaktır

        //    class kendı davranısından vazgecmez 

        //    kodu devam ettirince de konsola yazıyı yazdırıyor

        //    deginmek istediğim farklı bir nokta innertype larımızın içerisindeki metotlara ulasabilmek 

        //    nesne içerisindeki nesnenin metoduna nasıl ulaşabilirim bunu diger video da görelim

        //    VİDEO 147 BİTİŞ


        //    */

        //    Musteri147 M1 = new Musteri147();
        //    M1.musteriId = 1;
        //    M1.tcKimlikNumarasi = "12345678901";
        //    M1.isim = "Mücahit";
        //    M1.soyIsim = "Çetinkaya";
        //    M1.olusturmaTarihi = DateTime.Now;

        //    // burdan sonra inner type lara gecelim

        //    // yani bu böyle yapılmaz!!

        //    //M1.musteriAdres147Liste = new MusteriAdres147[5];

        //    M1.musteriAdres147Liste[0] = new MusteriAdres147()
        //    {
        //        Il = "Istanbul",
        //        Ilce = "Beşiktaş",
        //        Adres = "Adres...",
        //        AdresTip = "İş Yeri"
        //    };



        //}

        #endregion


    }
}