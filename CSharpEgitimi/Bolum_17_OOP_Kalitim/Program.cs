using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolum_17_OOP_Kalitim
{
    internal class Program
    {
        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion

        #region VİDEO 151 Nesne yönelimli programlama dünyasında kalıtım nedir ?

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 17 OOP Kalıtım V151 Nesne yönelimli programlama dünyasında kalıtım nedir ? 

        //    */

        //    /*

        //    1. not başlangıç

        //    Bu bölümde oop de kalıtım konusunu inceleyeceğiz 
        //    bir önceki bölümde innertype demiştik innertype kısmında standart bir nesne olusumunun icerisinde field olarak 
        //    kendi yapmıs oldugumuz nesnelerimizi cagırmaya innertype diyoduk bunu gördük
        //    cok basit bir konu oldugu için cok örnek yapamadık ama kalıtım konusu öyle degil 
        //    kalıtım konusu nesne yönelimli programlamanın tam ortası diyebileceğimiz bir sonraki konunun habercisi olan zorlukta bir konudur 

        //    Nesne Yönelimli Programlama - Kalıtım

        //    Nesne yönelimli programlama içerisinde önemli bir yere sahip bir başka konuya ulaştık.
        //    Konumuz kalıtım veya miras alma da diyebiliriz başka kaynaklar kullanıyorsanız inharance olarak geçebilir

        //    Kalıtım yolu ile oluşturmuş oldugumuz nesnelerimiz birbirlerinden türetilebilir ve türeyen nesne türetilen nesnenin tüm özelliklerini kullanabilir
        //    C# programlama diline başlarken tip dönüşümlerinde tüm nesneleri tanıyan her türden nesneyi kabul eden
        //    - hatta boxing unboxing diye özel video cektigimiz bir object tipi vardı işte bu object tipi ----
        //    object tipinden bahsetmiştik.

        //    Object tipi framework içerisindeki tüm nesnelerin atası olan bir tip olduğu için ( tüm nesneler object nesnesinden kalıtıldığı için ) türetilen tip kendisinden türeyen tüm tipleri tanır ve tam bir uyumluluk sağlar.

        //    Ogrenci O1 = new Ogrenci();

        //    Yukarıda nesne örneği alınan ögrenci nesnesi aslında object tipinden türetilmiş bir nesnedir.

        //    inceleyelim ve sunumumuza devam edelim

        //    kod kısmından devam edelim ..

        //    Ogrenci151 adında bir class olusturalım 

        //    ordan devam edelim 

        //    1. not bitiş

        //    2. not bitiş 

        //    3. not başlangıc

        //    ogrenci yi new leyeceğiz 

        //    Ogrenci151 O1 = new Ogrenci151();

        //    O1. dedigimiz de yazdıgımız field lar geldi ama ek olarak 4 tane de metot geldi 

        //    Equals GetHashCode GetType isim ogrenciId soyisim ToString

        //    peki bu metotlar nası geldi ben bunları yazmadım 
        //    demekki bir yerden ogrenilip geldi buraya 
        //    benım ogrenci nesnemin bu metotları ögrendiği yani miras aldıgı tipimizin adı object

        //    ben bunu nası biliyorum belki object degil 

        //    O1. dedigimiz de yanda tooltype cıkıyor C# programlama dilini ogrenmek istiyorsanız bunlara dikkat etmek okumak gerek

        //    Equals uzerıne geldimiz de bool object.Equals(object obj) yazıyor
        //    bool veri tipi döner 
        //    object. dediği yer object nesnesinin içinden geliyor

        //    mesela ToString metoduna bakalım 

        //    string object.ToString() yazıyor bunu daha sık kullanacagız
        //    geriye string deger dönerim diyor 
        //    object nesnesinin bir metodu olan metot oldugunu () lerden anlıyoruz
        //    metodu olan ToString i seninle paylaşıyorum diyor 

        //    peki bunu nası yapıyor benim ogrenci nesnem orneklenirken .netframework un ana mantıgından yararlanıyor 
        //    gidip object nesnesini alıyor ondan bir kopya alarak kendini türetiyor 
        //    benim içerisine yazmıs oldugum field lar ogrenci nesnesi için konusuyorum field lar metotlar vb tüm işlemler 
        //    aslında bir şablon olarak alınan object nesnesinin üzerinden geçip benım özel tipim haline geliyor

        //    ve ben bu olusturmus oldugum özel tipimi de türetip farklı tipler de kullanabiliyorum 
        //    şimdi slaytımıza geri dönelim bunları zaten detaylı olarak inceleceğiz...

        //    3. not bitiş 

        //    4. not başlangıç - dk 8

        //    Uygulama içerisinde gördüğünüz gibi ögrenci nesnesi aslında bizim olusturdugumuz özel bir tip ama içeride bizim ona yazmdıgımız metotların oldugunu ve bunların object nesnesinden kalıtılma ile geldiğini söyledik.

        //    Kalıtım konusunu biz aslında yine ilişkisel veri tabanı mantıgında ortak değerlere sahip olan alanlarımızı nesnesel olarak modellerken kullanırız.

        //    (Kalıtım konusunu biz aslında yine ilişkisel veri tabanı mantıgını modellerken kendisini tekrar eden field lar metotlar vb işlemleri kullanabilmemiz için bir merkezilik saglayabilmek için ki bunu cok biçimlilik Polymorphism konusunda biraz zor bir konudur orda biraz daha net anlayacagız modelleme için kullanırız biz aslında class ları database içindeki datamıza erişip o datayı c# tarafında kullanabilmek için modelleriz modellediğimiz olan class ı da uygulama içerisinde kullanırız hiç class kullanmasak cok guzel uygulamalar yapamaz mıyız yaparız tabiki ama cok uzun sürer neden uzun sürer herseyi defalarca yazmamız gerekir ama nesne yönelimli programlama da ana amac zaten bir veriyi bir ana noktayı merkezileştirmek merkezileştirip referanslar üzerinden giderek işlemleri alabilmek dolayısıyla kalıtım nesne yönelimli programlanın tam ihtiyacı olan bir konudur.)

        //    C# programlama dilinde olusturmus oldugumuz tüm nesnelerimiz default olarak türetilmeye acık olarak gelmektedir.

        //    istersek olusturmus oldugumuz nesnelerimizin türetilmesini engelleyebiliriz
        //    neden kapama ihtiyacı duyarız bırakalım türesinde diyebiliriz ama 
        //    kendi uygulamamız içerisinde biz bu nesnelerimizi bir anahtar kelime ekleyerek class ın uzerıne kapatmayabiliriz 
        //    fakat uygulamayı dıs programcılara verdigimiz de benim bir kutuphane yazdıgımı dusunun 
        //    public olarak internete dagıttıgımı düşünün yada bir banka entegrasyonu olabilir yada bir 3. parti bir yazılımcı ile kutuphaneyi verip paylaştıgım söz konusu olabilir
        //    ki bunlar olabilir ama nesnemin kullanılmasını istemem aldıgı hatayı benim nesneme atar bir program cıksa anlamazsa işten geri döner nesneyi onla paylaşmam ileride bende güvenlik problemleri olusturabilir cunku kalıtıyorum ve diyorum ki sen bu nesne gibi bir nesne türet bunu istemediğimiz durumlarda nesnemizi kalıtıma kapatmaya geceriz ve baska nesneler tarafından katılmasını engelleriz cok basit bir işlemdir.

        //    Bu bölüm içerisinde erişim belirleyicilerinden internal erişim belirleyecisini inceleyeceğiz

        //    kalıtım konusu önemli bir konu detaylı bakacagız Polymorphism konusuna geldiğimiz de işte orda biraz kafamız karısacak ki kalıtım konusunu net olarak anlamamız buna baglı Polymorphism konuna gectigimiz de bir class daki bir metot bir işlem yaparken aynı class daki aynı isimli aynı metot farklı işlem yapabilecek
        //    çok biçimlilik olacak işte bu nokta da karısmamak için kalıtım konusunu yavas ve detaylı atlatmadan izleyin 


        //    */

        //    /* 3. not kod kısmı baslangıc */

        //    //Ogrenci151 O1 = new Ogrenci151();
        //    //O1.

        //}

        #endregion

        #region VİDEO 152 Kalıtım ile nesne modelleme

        //static void Main(string[] args)
        //{
        //    /*

        //        Bolum 17 OOP Kalıtım V152 Kalıtım ile nesne modelleme

        //    */

        //    /*

        //    1. not başlangıc

        //    bir önceki bölümde kalıtılım ne oldugunu inceleyip slaytlar ile konusmustuk 
        //    ogrenci adında nesne tasarlayıp bunun içerisine bir kaç tane field ekleyip bunu daha da acacagımızı guzellestireceğimizi söylemiştik

        //    Uygulamalarımızın veri tabanlarını olusturacagımız zaman bazen uygulama seviyesindeki bazı ayarların kayıt bazında tutulmasının istenmesinden veya 
        //    uygulamamızın içerisindeki tanımların birbirinin bazı alanlarının aynı olması nedeni ile tablolar aynı kolonları içerebilirler

        //    yazmıs oldugumuz kodlarımız ise veri tabanlarımızdan data alma veya data gönderme temel görevlerini yerine getirebilmek için şemasal olarak database tiplerinin modelleri olarak olusurlar 

        //    OOP'da kalıtım tam bu noktada bize yardımcı olur ve sınıflarımızı tanımlarken merkezi bir mimari ile daha az ve daha merkezli kod yazmamızı sağlar 

        //                                    Personel                        Egitmen                         Ogrenci
        //                                    Id                              Id                              Id
        //                                    ReferansKod                     ReferansKod                     ReferansKod
        //                                    TcKimlikNo                      TcKimlikNo                      TcKimlikNo
        //                                    Isim                            Isim                            Isim
        //                                    SoyIsim                         SoyIsim                         SoyIsim
        //                                    Cinsiyet                        Cinsiyet                        Cinsiyet
        //                                    IsBaslangicTarih                IsBaslangicTarih                Bolum
        //                                    IsBitisTarih                    IsBitisTarih                    Seviye
        //                                    IzinGun                         IzinGun                         KayitTarih
        //                                    KayitTarih                      Brans                           KayitKullanici
        //                                    KayitKullanici                  Seviye                          GuncellemeTarih
        //                                    GuncellemeTarih                 KayitTarih                      GuncellemeKullanici
        //                                    GuncellemeKullanici             KayitKullanici                  Silindi
        //                                    Silindi                         GuncellemeTarih                 
        //                                                                    GuncellemeKullanici             
        //                                                                    Silindi                         

        //    yukarıda bulunan tablo uzerınden gideceğiz Personel Egitmen ve Ogrenci
        //    kendi field leri oldugu gibi ortak olan field lerı var
        //    kalıtım nesnelerimizi database modellerimizi .netframework tarafında modellerken bizim bu ortak özellikleri aldıgımız kısımlarda işimize yarıyor 

        //    şu sekilde bir islevsellik olacak birazdan 
        //    Solutions içerisine eklemiş oldugumun console uygulamasında ki ogrenci nesnesinin içerisindeki field ları bosaltıp daha sonra diger entityleri de olusturup
        //    personel ve egitmen class larını da olusturup burada ki modeli .netframework ortamına tasıyacagız

        //    peki biz neden bu sekılde tablo yapıları kullanırız 

        //    personel egitmen ogrenci adında 3 farklı tablom var bunların 3 nun de kendı ortaklarında kesismiş oldugu field lar var 
        //    uygulamarımız veri tabanlarını olusturacagımız zaman bazen uygulama seviyesinde bazen de kayıt bazında biz bu dataların tutulmasını isteriz

        //    burda kayıt bazında tutulma söz konusu uygulama bazında olsaydı buraya bir tablo tipi ve tablonun referansid ve kodunu alarakta bu işlemi çözebilirdim 
        //    ama o zaman daha bir ilişkiselliğe dogru gidiyor 
        //    bu tamamiyle database tasarımcısının tasarımcı sizseniz sizin o uygulamanın içerisine adam bolu maliyete göre degisebiliyor 

        //    ama her halukarda ne kadar ilişkisel tabloları kucultup kucultup kullansakta .netframework içerisinde biz onu bir nesne olarak cekmek istediğimiz de kalıtım konusunu kullanıyoruz 

        //    yazmıs oldugumuz kodlarımız veritabanın dan data alınım veya data gönderme en temel gorevlerı bunları yerine getirebilmek için semasal olarak database tiplerinin modellerini olustururlar bizde bu dersimiz de bu modelleri olusturup daha sonraki derslerimiz de de kalıtımın detaylarına iniyor olacagız 

        //    Ogrenci152 Personel152 Egitmen152 class larını olusturalım 

        //    hepsini olusturup hepsini public yaptık ve olusturmus oldugumuz class larımız kendi içerisinde bir baska class a ihtiyac duyacaklar
        //    benim en temel anlamda bir tip olusturmam ve olusturmus oldugum tipin içerisinde de ortak seviyede denk gelen field ları kullanabilmem lazım

        //    3 nesnemizinden türemesini istediğimiz ortak class ımızı olusturup ortak olanları bu class içine yazalım 
        //    TemelTip adında baska bir class olusturalım normalde bu BaseType BaseClass olarak gecer egitim anlasılsın diye boyle isimlendirdik

        //    TemelTip içerine gidip ortak field larımızı olusturalım

        //    1. not bitiş

        //    3. not bitiş

        //    4. not baslangıc

        //    Egitmen class ını new leyerek bakalım TemelTip class ını almıs mı 
        //    Egitmen152 E1 = new Egitmen152();
        //    E1. dedigimiz de temeltip içindeki bütün field lar gelmıs görüyoruz

        //    eger ben bunu innertype olarak yapmıs olsaydım E1.TemelTip. gibi gitmem gerekirdi

        //    Egitmen class ına gidip oradaki field ları olusturalım

        //    4. not bitiş

        //    5. not bitiş

        //    6. not baslangıc

        //    program.cs de 
        //    E1. dedigimiz de artık Egitmen içerisine yazdıgımız 2 field da cıkıyor karsımıza 
        //    tooltype okumanın onemınden bahsetmiştik
        //    E1. dedigimiz de Brans ın uzerıne gelince 
        //    string tipinde Egitmen152.Brans olarak gozukuyor
        //    Cinsiyet e baktıgımız da temeltip içerisinden geldiğini yani kalıtımdan gelmiş
        //    int deger aldıgını get ve set bloklarını okunabilir ve yazılabilir oldugunu anlıyoruz

        //    personel nesnesine gidelim

        //    6. not bitiş

        //    8. not bitiş

        //    9. not baslangıc

        //    egitmen den geldik

        //    ben burda egitmen E1. diyip temeltipe ulasabildiğim gibi
        //    personel uzerınden de p1. diyip temeltipe ulasabiliyorum

        //    ogrenci class ına gidelim

        //    9. not bitiş 

        //    */

        //    Egitmen152 E1 = new Egitmen152();
        //    //E1.

        //    Personel152 P1 = new Personel152();
        //    //P1.

        //}

        #endregion

        #region VİDEO 153 Kalıtım ile nesne modelleme - Yapıcı metot davranışları

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 17 OOP Kalıtım V153 Kalıtım ile nesne modelleme - Yapıcı metot davranışları

        //    */

        //    /*

        //    1. not baslangıc

        //    video 152 de nesnemizi modelledik ama calıstırıp davranıslarına bakmadık
        //    Video 153 için 152 de yazdıgımız nesneler üzerinde calısmalar yapacagız
        //    kendimize bir nesne belirleyip bu nesne ile temeltip arasındaki etkileşime bakalım
        //    152 deki yaptıgımız class ları 153 olarak yeniden olusturalım

        //    153 adında Egitmen Personel Ogrenci TemelTip class larını olusturduk burdan devam edecegız

        //    ornek alacagımız nesne Egitmen olsun temeltip ile arasındaki baglantıyı anlatmak istiyorum

        //    bunu daha net anlamak için class ların bazı davranıslarını ön plana cıkartmak gerekli 

        //    nesnemizi ornekledıgımız de yapıcı metot calısacak bunu tekrardan yazıp mudahale edelim ki ne calısıyor görelim

        //    yapıcı metot da egitmen için egitmen class ının yapıcı metodu calıstı
        //    yapıcı metot da temeltip için temeltip metodunun yapıcı metodu calıstı yazdıralım

        //    daha sonra nesnemizi ornekleyip yapıcı metotların hangisinin daha once calıstıgına bakalım 

        //    temeltip153 e gidelim

        //    1. not bitiş

        //    3. not bitiş

        //    4. not baslangıc

        //    Egitmen153 ü ornekleyip hangisinin once calıstıgına bakalım 

        //    Egitmen153 E1 = new Egitmen153();
        //    buraya breakpoint koyalım

        //    davranısı inceleceğiz class lar kendı davranısının dısına cıkmayacak 
        //    bu class ların davranıs sıraları degisecek

        //    diger class larında yapıcı metotlarına breakpoint koyalım
        //    ilk olarak egitmen nesnesine gidiyor orneklemeye calısıyor ama
        //    beni hemen temeltipe atıyor sonra nedeni baska nesneden türediğini görüyor oncelik ona geçiyor
        //    ilk once base in calısması lazım ki framework olarak hata almayalım oradaki field lara ulasmak isteyecegımız için
        //    ilk once base in ayaga kalkması sonra digerlerinin calısması gerekiyor
        //    temeltipin ctor u calıstı

        //    konsolda yazısı yazdı yani bu demek ki temeltip içindeki bütün field lar ram uzerınde acıldı demek default degerlerını aldı 

        //    sonra egitmene geri dondu ctor calıstı
        //    program.cs e geldi calıstı kodu bitirdi.

        //    konsolda cıkan sonuc 

        //    TemelTip153 nesnesinin yapıcı metodu çalıştı.
        //    Egitmen153 metodunun yapıcı metodu çalıştı.

        //    Egitmenin içine gitti once miras aldıgı class ı calıstırdı sonra kendısine donup onu calıstırdı

        //    aklımızda daha da kalıcı olması için ram ı tekrar tasarlayalım 

        //    Ram tarafını konusalım 

        //    bir dikdörtgen çizelim 
        //    -------------------------------------
        //    I    Stack       I       Heap       I
        //    I                I                  I
        //    I                I                  I
        //    -------------------------------------
        //    I              Static               I
        //    I                                   I
        //    -------------------------------------

        //    ben en basta egitmen nesnesi olusturmak istiyorum dedım 
        //    E1 adındaki egitmen nesnem stack bolgede olusurken 
        //    içeride e1 ın temeltipten kalıtıldıgını gördüm
        //    e1 in içinde tt nesnesi orneklendi 
        //    tt nin ctor calıstı içerisindeki field lar heap bolgeye atıldı
        //    daha sonra uygulama geri dondu 
        //    e1 i ornekledi 
        //    acmıs oldugu referans ın uzerıne ornekledı 
        //    tek bir tip gibi davranmasını sagladı 

        //    calısırken E1 in üzerine gittiğimiz de degerlerim default degerlerini aldı
        //    peki ben temeltip nesnesindeki bir field ıma default deger vermek istersem 
        //    mesela id e bir metot ile random deger atamak istiyorum 
        //    bunu nerde yapabilirim 2 farklı yer olabilir 
        //    nerde yapmalıyım daha mantıklı bir soru ben bunu temeltip içerisinde yapmalıyım 
        //    sebebi eger ben bu nesneyi temeltip içerisine eklediysem ve temeltip içerisinde deger almasını istiyorsam 
        //    bunu temeltip içerisinde bir metot olarak eklemeliyim ki bu nesnemden türeyen her yerde bunu kullanabileyim
        //    2. soru ben egitmene özel id nin calısmasını istiyorum 
        //    egitmen orneklendıgın de 200 ile 300 arasında degerler ile id alsın 
        //    personel de 400 500 ile arasında degerler alsın
        //    ogrenci de 500 ile 1000 arası alsın gibi farklı cesitlilik isteyebilirsiniz
        //    işte o zaman ben bunu türeyen nesne yani egitmen uzerınden bir metot ile cozebilirim gibi dusunebilirsiniz ama
        //    ben yine de bunu söylerim 
        //    bunun olması gereken yer en temelde yine temeltip dir
        //    olusturmus oldugumuz metodu sanal metot yaparız 
        //    istediğimiz metodu da class la override edebiliriz
        //    işte n katmanlı mimari bastan sona bu sekılde 
        //    herseyi kuralına göre yazarsanız istediğiniz şeyi de kuralına göre degistirebilirsiniz
        //    dolasıyla id degerini tek bir noktada atamak istiyorsak farklı tiplere göre id mizin aralıgı degismeyecekse 
        //    o zaman bizim bu id degerimizin atanması gereken yer standart olarak temeltip olmalı

        //    temeltip nesnesine gidip metot yazalım 

        //    4. not bitiş

        //    5. not bitiş

        //    6. not baslangıc

        //    bakalım atama yapacak mı breakpoint koyup da izleme yapabilirsin E1 de breakpoint var id atayacak mı ona bakacagız
        //    calısıtınca e1 null gecinde atamalar yapıyor ornekleniyor 
        //    id e atama yapmıs random olarak sistem calıstı 

        //    peki ben temeltip içindeki bu metodu egitmen içerisinde görebilir miydim ????

        //    metot private

        //    Egitmen nesnesine gidelim

        //    6. not bitiş

        //    */

        //    Egitmen153 E1 = new Egitmen153();
        //    Console.WriteLine("Egitmen nesnesi orneklendi.");

        //}

        #endregion

        #region VİDEO 154 Kalıtım ile nesne modelleme - Temel Sınıf metotlarına erişim

        //static void Main(string[] args)
        //{

        //    /*

        //           Bolum 17 OOP Kalıtım V154 Kalıtım ile nesne modelleme - Temel Sınıf metotlarına erişim

        //    */

        //    /*

        //    1. not başlangıç

        //    şimdi class larımızın içerisine bir kaç farklı metot ekleyelim
        //    153 den alıp kodları 154 uzerınden devam edeceğiz
        //    153 lerin hepsini 154 olarak olusturalım

        //    ve temeltip te olusturmus oldugumuz metotumuzu aslında egitmen nesnemizi cagırdıgımız da nası kullanabileceğimizi inceleyelim
        //    bunun için TemelTip154 e gidelim

        //    1. not bitiş

        //    2. not bitiş

        //    3. not baslangıc

        //    TemelTip üzerinden TemelTipMetot a erişelim oluyo mu

        //    TemelTip154 T1 = new TemelTip154();
        //    T1.TemelTipMetot1();

        //    egitmen nesnesi uzerınden erişebiliyor muyuz ona bakalım

        //    Egitmen154 E1 = new Egitmen154();
        //    E1.TemelTipMetot1();

        //    erişim oluyor tooltype içinde ben TemelTip içindeki metotum diyor

        //    uygulamayı build ederek davranıslarını inceleyelim

        //    TemelTip calıstı içindeki metot calıstı 
        //    egitmen calıstı temeltip içindeki metot calıstı

        //    peki bunun tam tersi olur mu 
        //    yani
        //    temeltip içinden egitmen içindeki metot a erişim olur mu 
        //    hayır bu mumkun degil
        //    bu yön tek yönlüdür
        //    türemiş oldugu nesneye gider bakar

        //    bizim bir boxing unboxing işlemimiz vardı 
        //    bunu hatırlayalım diger video için hatırlatma olsun 

        //    ben bir tane object nesnesi olusturdugum da object nesnesi bütün nesnelerin ana temeltip olarak görmüş oldugu bir nesne 
        //    mesela

        //    object O1 = E1;
        //    dedigimiz de sorun cıkartmıyor kendisinden baska tiptekileri de alabiliyor 
        //    ana tip her seyi kabul eder buna biz kutulama işlemi diyoruz boxing oluyor

        //    O1 nesnesini içinde object var tekrar E1 e cevirmek için
        //    E1 = (Egitmen154)O1;
        //    yapmamız lazım buna da unboxing işlemi denir

        //    bu işlemleri de kendi özel tiplerimiz de nasıl yaparız birlikte bunu inceleyeceğiz
        //    sonra kalıtım konusundan devam edeceğiz

        //    154. video burda bitti 

        //    */

        //    TemelTip154 T1 = new TemelTip154();
        //    T1.TemelTipMetot1();

        //    Egitmen154 E1 = new Egitmen154();
        //    E1.TemelTipMetot1();

        //    object O1 = E1;
        //    E1 = (Egitmen154)O1;

        //}

        #endregion

        #region VİDEO 155 Kalıtım ile nesne modelleme - Boxing | Unboxing işlemleri

        //static void Main(string[] args)
        //{

        //    /*

        //          Bolum 17 OOP Kalıtım V155 Kalıtım ile nesne modelleme - Boxing | Unboxing işlemleri

        //    */

        //    /*

        //    1. not baslangıc 

        //    boxing ve unboxing işlemlerini olusturmus oldugumuz temel sınıflar içerisinde nası yapıyoruz görelim
        //    aslında object te oldugu gibi bir tür dönüşümünü burda da yapıyor olacagız

        //    özel tipler de boxing unboxing

        //    burda bizim ilk sorumuz bizim objemiz nedir ?
        //    yani bizim en temel nesnemiz nedir ?

        //    bizim custom nesnemiz TemelTip o zaman TemelTip benim Objem oluyor

        //    TemelTip155 T2; diyip bıraktım

        //    hangi nesnelerde temeltip object görevi görür ? 

        //    Personel Egitmen Ogrenci

        //    neden

        //    TemelTip nesnesinden türedikleri için TemelTip nesnesi bu nesneler de object gibi davranır

        //    T2 = E1;
        //    dedik egitmen nesnesini temeltip nesnesine atadık herhangi bir hata vermedi

        //    Personel nesnesini ornekleyelim onun üzerinden gidelim

        //    Personel155 P1 = new Personel155();

        //    T2 = P1;
        //    Personel nesnesini TemelTip nesnesine atadık dedigimiz de yine herhangi bir hata almadık

        //    bunları kendi nesnelerine cevirmek için

        //    Yani T2 yi egitmen yapmak için bunun egitmen oldugunu belirtmem gerek

        //    E1 = (Egitmen155)T2;
        //    P1 = (Personel155)T2;

        //    burda da unboxing işlemi oluyor

        //    peki böyle bişey yapsak ne olurdu
        //                object O3 = T2;

        //    hiç bir sorunla karsılasmıyoruz
        //    object tipi herseyın baslangıc noktasıdır
        //    nesne türet ondan cık baska üret ona aktar cık gir farketmez
        //    en bas herseyin baslangıcı objecttir kabul eder

        //    */

        //    TemelTip155 T1 = new TemelTip155();
        //    T1.TemelTipMetot1();

        //    Egitmen155 E1 = new Egitmen155();
        //    E1.TemelTipMetot1();

        //    /* Boxing - Unboxing */

        //    TemelTip155 T2;
        //    T2 = E1;
        //    E1 = (Egitmen155)T2;

        //    Personel155 P1 = new Personel155();
        //    T2 = P1;
        //    P1 = (Personel155)T2;

        //    Ogrenci155 O1 = new Ogrenci155();
        //    T2 = O1;
        //    O1 = (Ogrenci155)T2;

        //    //object O3 = T2;

        //}

        #endregion

        #region VİDEO 156 Kalıtım ile nesne modelleme - Personel & Öğrenci nesnesi modelleme

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 17 OOP Kalıtım V156 Kalıtım ile nesne modelleme - Personel & Öğrenci nesnesi modelleme

        //    */

        //    /*

        //    1. not baslangıc

        //    bu zamana kadar ogrendıklerımızi Personel ve Ogrenci nesnesi üzerinden tekrar edeceğiz
        //    Personel ve Ogrenci metotlarına yapıcı metot ekledık
        //    ornekleyip debug yapalım

        //    personel nesnesine gidip temeltip e gidiyor kalıtım var diye temeltip nesnesi içindeki metot calısıyor

        //    boxing ve unboxing işlemlerini yapalım

        //    object obj1 = O1;
        //    O1 i obj1 içine atadıgımız da sorun yok object tüm tiplerin ana tipi
        //    tekrar ben O1 e obj1 in içideki nesneyi dönmek istersem
        //    O1 = obj1 böyle olmaz 
        //    unboxing yapmammız lazım 

        //    O1 = (Ogrenci156)obj1; yazmamız lazım

        //    kalıtımın ana mantıgında nelerin oldugunu kavradık 

        //    ben istiyorum ki türemiş olan tiplerim türeyemesin 
        //    nası yani 
        //    object ten temeltip türedi 
        //    temeltipten personel ogrenci egitmen türedi 
        //    ben istiyorum ki personel ogrenci egitmen türeyemesin

        //    yani ben bir yerde kalıtımı kesmek istiyorum buraya kadar burdan sonra hiç bir nesnem türeyemecek baska nesne bunu kendisine temeltip olarak alamayacak demek istiyorum 

        //    bunu ogrenci ve egitmen için yapmak personel için yapmamak istiyorum 

        //    birazdan personelden egitmeni türeteceğim orda bir kırılım yasacagız nedenini size acıklama yapacagım 
        //    önce bir keyword görelim 
        //    o keyword ile türeme işlemini engellemeyi göreceğiz 
        //    sonra da temel bir mantık degişikliği var ona deginip konuyu bitireceğiz

        //    diger video a gecelim 

        //    */

        //    Personel156 P1 = new Personel156();
        //    P1.TemelTipMetot1();

        //    Ogrenci156 O1 = new Ogrenci156();
        //    O1.TemelTipMetot1();

        //    object obj1 = O1;
        //    O1 = (Ogrenci156)obj1;

        //    obj1 = P1;
        //    P1 = (Personel156)obj1;

        //}

        #endregion

        #region VİDEO 157 Sealed anahtar kelimesi ile kalıtımı sonlandırmak

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 17 OOP Kalıtım V157 Sealed anahtar kelimesi ile kalıtımı sonlandırmak

        //    */

        //    /*

        //    1. not baslangıc

        //    şimdi yapmıs oldugumuz nesnelerimizi yani Ogrenci ve Egitmen nesnemizi öncelikle bir ana tip gibi belirleyelim 
        //    onlardan bir nesne örneği alalım kalıtalım yani kalıttıktan sonra bunu nası yapamayacagımızı görelim 

        //    yeni bir nesne olusturalım 

        //    Test157 ve Egitmen den miras alalım 

        //    Test157 T1 = new Test157();
        //    T1. dedigimiz de 

        //    Egitmen nesnesini ve egitmenin de miras aldıgı bütün metot ları kullanabildiğimi görüyorum 

        //    bir yerde yapmıs oldugumuz nesnelerin bu sekilde türetilmesini istemeyiz 
        //    eger diger yazılımcının bizle herhangi bir bagı yoksa benimle ortak yerlerde birleşmiyorsa 
        //    benim nesnelerimi cok kendi içinde kullanmıyorsa yada dıs bir firma ise 
        //    nesnemin bu sekılde kalıtılmasını istemem ve özel olarak gercek hayatta da bu işlemi yaparım nesnemi mühürlerim 

        //    benim nesnemden nesne orneği alamasın eger cok lazımsa içeride innertype olarak kullansın 
        //    bunu nası yapacagız 

        //    biz hangi nesnemizin kalıtılmasını istemiyoruz 
        //    egitmen nesnemizin kalıtılmasını istemiyoruz o zaman egitmen nesnemizi sealed olarak işaretlememiz gerekiyor

        //    sealed anahtar kelimesi nesnenin içerisine verildiğinde netframework e sunu söylüyor

        //    bu nesnenin kalıtımı yapılamaz kalıtım sonlandı 
        //    egitmen nesnesine gidelim

        //    1. not sonu

        //    2. not sonu

        //    4. not bitiş

        //    5. not baslangıc

        //    diger video da neler yapacagız giriş yapalım

        //    bizim Personel ve Egitmen nesnelerimizin içinde kendilerini tekrar eden field lar vardı 
        //    benim temel olarak görmem gereken 

        //    Personel nesnesinin ana field ları Egitmen nesnesinin içerisinde tekrarlanmıs 
        //    benim egitmen nesnem temeltipten türemiş personel nesnem de temeltipten türemiş 
        //    öyle bir işlem yapmalıyım ki 

        //    egitmen nesnem hem personel nesnesini görebilmeli hem personel nesnesinin içerisindeki temeltipi görebilmeli 
        //    bir sonraki video da bu sistemin mantıgı hakkında konusacagız 
        //    yapacagımız işlem basit ama mantıgını anlamaya calısacagız 

        //    mantıgını anladıktan sonra neden personel nesnesini sealed olarak işaretlemedik onun da cevabını almıs olacaksınız 


        //    */

        //    Test157 T1 = new Test157();

        //}

        #endregion

        #region VİDEO 158 Kalıtılan nesne içerisinde kalıtım yapmak ( Detaylı inceleme )

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 17 OOP Kalıtım V158 Kalıtılan nesne içerisinde kalıtım yapmak ( Detaylı inceleme )

        //    */

        //    /*

        //    1. not baslangıc

        //    neden Personel nesnesini sealed olarak işaretlemedik bundan bahsedelim 

        //    ana temel olarak bizim modellemelerimiz de su kural gecerlidir 

        //    Personel nesnesinin içerisinde olan
        //     public DateTime IsBaslangicTarihi { get; set; }
        //     public DateTime IsBitisTarihi { get; set; }
        //     public int IzınGunSayisi { get; set; }
        //    aslında Personele özel olan alanlarımız 

        //    Egitmen class ına baktıgım da 

        //    public string Brans { get; set; }
        //    public int BransSeviye { get; set; }

        //    Egitmene ozel olan alanlarımız 

        //    Benim Egitmen nesnemi Personel nesnemden kalıtmam gerekiyor

        //    Personel nesnem de TemelTip nesnesiniden kalıtıldıgı için ben yine hiç bir şey kaybetmeyecegim

        //    aslında bakarsanız daha bir esneklik kazandırmıs olacagım 

        //    Egitmen158 Personel158 ve TemelTip158 class larını acalım ve 157 den kod ları alalım

        //    Egitmen158 e gidelim

        //    1. not bitiş

        //    2. not bitiş

        //    3. not baslangıc

        //    Egitmeni örnekleyip gerekli yerlere breakpoint koyup bakalım neler yapıyor

        //    Egitmen e giriyor nerden miras almış Personel de 
        //    Personele gidiyor nerden miras almış TemelTip
        //    TemelTip teyken de object ten bir örnek alıyor

        //    sonra sırayla geri geliyor

        //    İlk TemelTip calısıyor sonra
        //    Personel ctor calısıyor
        //    sonra Egitmen ctor calısıyor


        //    */

        //    //Egitmen158 E1 = new Egitmen158();

        //}

        #endregion

        #region VİDEO 159 Kalıtım ile protected kullanımı

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 17 OOP Kalıtım V159 Kalıtım ile protected kullanımı

        //    */

        //    /*

        //    1. not baslangıc

        //    bu bolume kadar erişim belirleyicilerinde sadece public ve private kullandık

        //    kalıtım konusunun kendisine özel bir erişim belirleyicisi bulunmakta

        //    bu erişim beliryecisi ise 

        //    Protected

        //    Protected Nedir ? 
        //    Kalıtım konusunda bize sagladıgı avantajlar nedir ?
        //    biraz bunlardan bahsedelim

        //    önce işlemiş oldugumuz erişim belirleyicilerini biraz tanıyalım

        //    Public : Uygulamamızın içerisinde veya dısarısında ulaşabilir anlamına gelir.
        //    Private : Sadece tanımlandıgı class içerisinde erişebilir olur.
        //    Protected : Normal kullanımda private olarak davranır. Kalıtım yolu ile baska bir class içerisinde public olarak kullanılır.

        //    TemelTip e gidelim ve protected bir metot olusturup bakalım

        //    1. not bitiş

        //    2. not bitiş

        //    3. not başlangıç

        //    Benim TemelTip metodumu örnekledıgım de TemelTipMetot2 metodunu görememem lazım metot protected dısarıya kapalı
        //    TemelTip159 T1 = new TemelTip159();
        //    T1.
        //    dedigimiz de TemelTipMetot2 cıkmıyor protected oldugu için class dısından cagıramıyorum

        //    private olarak nası davranıyor ona bakalım

        //    TemelTip159 a gidelim

        //    3. not bitiş

        //    5. not bitiş

        //    peki ben ogrenci nesnesini ornekleyerek protected olan metot veya field a ulalabilir miyim
        //    cevap hayır

        //    Ogrenci159 O1 = new Ogrenci159();
        //    O1. dedigimiz de TemelTipMetot2 gelmiyor

        //    protected oldugundan ulasamıyorum

        //    ya kendi class içinde olmalı veya kalıtım yapıldıgı yer olmalı

        //    */

        //    TemelTip159 T1 = new TemelTip159();

        //    Ogrenci159 O1 = new Ogrenci159();

        //}

        #endregion

        #region VİDEO 160 Uygulama Ödev

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 17 OOP Kalıtım V160 Kalıtım ile protected kullanımı

        //    */

        //    /*

        //    1. not baslangıc

        //    öncelikle bir BaseClass olusturalım ve problarını yazalım

        //    BaseClass a gidelim

        //    1. not bitiş

        //    ---------------------------------------------------------
        //    5. not baslangıc Televizyon nesnesine denk geldi soru 

        //    Ödev uygulamasındaki

        //    1.soru

        //    ben televizyon ve bilgisayar nesnelerimi urun nesnesinden kalıtmak istiyorum kalıttıgım zaman aslında genel olarak kalıtım seması nası olur

        //    program.cs calısır 
        //    hangisi new lendiyse ona göre işlenir 
        //    mesela urun new lendiyse
        //    urunden base e gider sonra urune gider

        //    televizyon new lendiyse miras urunse
        //    televizyondan urune urunden base e base den urune urunden televizyona sonra program.cs e 

        //    yukarıdaki sema bilgisayar içinde gecerli

        //    5. not bitiş
        //    ---------------------------------------------------------

        //    6. not baslangıc

        //    bilgisayar nesnesini olusturalım

        //    ---------------------------------------------------------
        //    Ödev uygulamasındaki ikinci soru 

        //    2. soru

        //    Ben Bilgisayar veya Televizyondan bir nesne örneği aldııgımda id degerini girmek istemiyorum aynı zamanda uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyorum bunun için ne yapmak gerekir

        //    öyle bir işlem yapmak istiyorum ki B1.Id = 1; yazdıgımda hata versin ama hiç bişey yapmadıgımda da içerideki id degerini takip edip sıradaki id degerini de alabilsin

        //    ---------------------------------------------------------

        //    id degeri atanamasın için 

        //    baseclass daki id degerini encapsulation olarak ayarlamak ve private olarak baska bir field olusturmak gerekiyor

        //    baseclass a gidelim

        //    6. not bitiş

        //    7. not bitiş

        //    8. not baslangıc

        //    B1.Id = 1;
        //    da hata veriyor set private oldu cunku

        //    debug yapıp kontrol edelim

        //    Bilgisayar160 B1 = new Bilgisayar160(); break point koyduk

        //    ilk girince null örneklendıgın de null ve 0 

        //    atamalarını yapınca degerler yine 0 geliyor 

        //    biz baseclass da ilgili işlemleri yaptıgımız halde neden id degerimiz artmadı ????

        //    bunun notları için baseclass a gidelim

        //    8. not bitiş

        //    9. not bitiş

        //    10. not baslangıc

        //    şimdi bilgisayar nesnesi orneklenirken
        //    bilgisayar nesnesine gidecek
        //    urunden miras almıs urune gidecek
        //    oda baseclass dan miras almıs oraya gidecek
        //    baseclass da da yapıcı metot var her turlu orası calısacak

        //    tekrar debug yapınca id 1 olarak geldi

        //    2. ödev de bitmiş oldu böylece
        //    id dısarıdan verilemiyor otomatik olarak atıyor

        //    ---------------------------------------------------------
        //    2. İSTEK 
        //    ALIS FİYATI 0 DAN KUCUK OLAMAZ 
        //    KAMPANYA 0 DAN KUCUK OLAMAZ
        //    SATIS FİYAT ALIS FİYATTAN KUCUK OLAMAZ
        //    ---------------------------------------------------------

        //    bu problar nerde ona bakmak lazım once bakınca hepsinin Urun160.cs de oldugunu görduk o zaman işlemlere orda devam etmemiz gerek

        //    10. not bitiş

        //    11. not bitiş

        //    12. not başlangıc

        //    olmayacak degerleri verip kontrol edelim hata verecek mi

        //    hataları aldık kod calısıyor şimdi de barkod kısmından devam edelim
        //    // dk 35
        //    şimdi bir data base olusturalım ve içerisine ürün ekleyelim daha sonrada barkoda geçip ilgili barkodları da o sistem üzerinden kontrol edebiliriz

        //    ben uygulama içerisinde bir database olusturmak istiyorum bir liste olusturmak istiyorum olusturmus oldugum o listenin uygulamada tekil olmasını istiyorum 
        //    ve içerisine devamlı olarak data aktarmak isteyeceğim

        //    bunun için ArrayList kullanacagım ama bunu nası kullanmalıyım 

        //    bir nesne örneklendıgınde oda bir kere örneklensin içerisine her deger atadıgımda atamıs oldugum deger onun içerisinde saklansın benim sanal bir database im olsun 

        //    sanal database ler için static leri kullanmaya devam edeceğiz 

        //    sanaldatabase160 class ını acalım ve static yapalım 

        //    12. not bitiş

        //    13. not bitiş

        //    14. not başlangıc

        //    SanalDataBase.YeniUrunEkle(B1);

        //    breakpoint koyup kontrol edelim

        //    calıstırırken hata aldık arraylist orneklenmedi bundan dolayı add metotuda calısmadı
        //    sanaldatabase e gidelim
        //    14. not bitiş
        //    15. not bitiş

        //    16. not başlangıc

        //    sanaldatabase de db i new leyip tekrar calıstırınca sorun kalmadı

        //    16. not bitiş

        //    17. not başlangıc

        //    ----------------------------------------

        //    3. soru

        //    baseclass içinde barkod field i var
        //    buraya girmiş oldugum değer benım sanal database im de olmaması lazım
        //    eğer sanaldatabase im de olursa bir uyarı cıksın yoksa barkodu ben kabul edebileyim
        //    burada yine get ve set leri modifiye edeceğiz 
        //    yine bir ek private metot yazıp kullanabiliriz

        //    olusturmus oldugumuz static içerisinde arraylist imiz vardı onun içerisindeki elemanlarda dönüp barkodu kontrol ettireceğiz barkodu bulursak işlem yapmayacagız bulamazsak işlem yapacagız

        //    BaseClass160 a gidelim barkod prob unu guncelleyelim

        //    17. not bitiş

        //    20. not bitiş baseclassdan geldik

        //    21. not başlangıç

        //    SanalDataBase.YeniUrunEkle(B1); yeni urun ekledik aynı üründen bir tane daha alalım

        //    b1 deki barkod 1234567890

        //    Bilgisayar160 B2 = new Bilgisayar160();
        //    B2.Marka = "Lenovo";
        //    B2.Model = "Z50";
        //    B2.Islemci = "I5";
        //    B2.AlisFiyat = 1000;
        //    B2.SatisFiyat = 1500;
        //    B2.KampanyaFiyat = 1000;
        //    B2.Barkod = "1234567890";

        //    SanalDataBase.YeniUrunEkle(B2);

        //    b2 deki barkod da 1234567890

        //    hata almak için aynısından olusturduk 

        //    21. not bitiş

        //    22. not başlangıç

        //    televizyon ve bilgisayar nesneleri katılamasın diye bir ödev vardı bunun içinde bir keyword vardı
        //    sealed bunu kullanmamız lazım

        //    televizyon ve bilgisayar nesnelerine public ten sonra sealed ekleyelim

        //    22. not bitiş

        //    24. not bitiş bilgisayardan geldik

        //    25. not baslangıc

        //    bolum gitti

        //    */

        //    //Bilgisayar160 B1 = new Bilgisayar160();
        //    ////B1.Id = 1;
        //    //B1.Marka = "Lenovo";
        //    //B1.Model = "Z50";
        //    //B1.Islemci = "I5";
        //    //B1.AlisFiyat = 1500;
        //    //B1.SatisFiyat = 2000;
        //    //B1.KampanyaFiyat = 1600;
        //    //B1.Barkod = "1234567890";

        //    Bilgisayar160 B1 = new Bilgisayar160();
        //    //B1.Id = 1;
        //    B1.Marka = "Lenovo";
        //    B1.Model = "Z50";
        //    B1.Islemci = "I5";
        //    B1.AlisFiyat = 1000;
        //    B1.SatisFiyat = 1500;
        //    B1.KampanyaFiyat = 1000;
        //    B1.Barkod = "1234567890";

        //    // dk 35 devam

        //    // dk 40 devam

        //    SanalDataBase.YeniUrunEkle(B1);

        //    Bilgisayar160 B2 = new Bilgisayar160();
        //    B2.Marka = "Lenovo";
        //    B2.Model = "Z50";
        //    B2.Islemci = "I5";
        //    B2.AlisFiyat = 1000;
        //    B2.SatisFiyat = 1500;
        //    B2.KampanyaFiyat = 1000;
        //    B2.Barkod = "1234567890";

        //    SanalDataBase.YeniUrunEkle(B2);


        //}

        #endregion

        #region VİDEO SIRALARIN DEĞİŞME NOKTASI

        //static void Main(string[] args)
        //{

                /*
                 
                 burdan önce hoca videolar da güncellemeye gitmiş videoların sırası kaymıs karısıklık olabilir hocaya göre gitme kararı aldım.
                 
                 */
                
        //}

        #endregion



    }
}
