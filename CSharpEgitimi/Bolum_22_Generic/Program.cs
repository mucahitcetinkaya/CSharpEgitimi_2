using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolum_22_Generic
{
    internal class Program
    {
        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion

        #region VİDEO 177 Generic sınıflar ne degildir

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 22 Generic V177 Generic sınıflar ne degildir

        //    */

        //    /*

        //    1. not baslangıc

        //    generic olmayan ve olan olarak 2 farklı sekılde bir anlatım yapacagız farklarına bakacagız

        //    Musteri class ı acalım 

        //    1. not bitiş

        //    2. not bitiş musteri den geldik

        //    3. not baslangıc

        //    Musteri i new leyelim ve problarını dolduralım

        //    //3. not baslangıc

        //    V177Musteri M1 = new V177Musteri();
        //    M1.ID = 1;
        //    M1.TcKimlikNo = "12254401254";
        //    M1.MusteriNo = "MS123";
        //    M1.Isim = "Mücahit";
        //    M1.SoyIsim = "Çetinkaya";
        //    M1.DogumTarihi = DateTime.Parse("13-06-1994");

        //    gerekli alanlarını doldurduk

        //    generic olmayan bir class tanımı yaptık generic class lar kısmını size anlatabilmem için bir senaryodan bahsetmem gerekiyor
        //    standart anlatımda su sekılde bahsedilir

        //    bir Musteri class ı olusturduk id degeri int ben bunu GUID olarak runtime da almak istersem şöyle yapmalıyım
        //    MusteriNo string ama biz bunu generic yapalım Runtime a göre değişsin her an musteri no tipi değişebilir gibi 

        //    orneklerle de generic class lar anlatılabiliyor gercek hatayı tam olarak yansıtmıyor

        //    oncelıkle yansıtmayan halini inceleyelim once onu anlayalım ki gercek hayattaki konularına sizi cekebileyim

        //    şimdi de MusteriGeneric class ını olusturalım ve bakalım

        //    3. not bitiş

        //    4. not bitiş musterigeneric ten geldik

        //    5. not baslangıc

        //    MusteriGeneric i newleyelim ve bakalım duruma

        //                //5. not baslangıc

        //    V177MusteriGeneric<int> M2 = new V177MusteriGeneric<int>();
        //    M2.ID = 1;

        //    new lerken ne veri tipi verirsek prob lara verdiğimiz T tipi de o tipi alıyor
        //    int verdik id de T tipi id int oldu

        //    V177MusteriGeneric<Guid> M3 = new V177MusteriGeneric<Guid>();
        //    M3.ID = Guid.NewGuid();

        //    guid verdik id t tipinden guid oldu

        //    MusteriGeneric e gidip bir metot olusturalım

        //    5. not bitiş

        //    6. not bitiş musterigeneric ten geldik

        //    7. not baslangıc

        //    metot için bir newleme yapalım

        //    V177MusteriGeneric<Guid> M4 = new V177MusteriGeneric<Guid>();
        //    M3.MusteriNumarasiAl();

        //    parametre almam ve geriye guid dönerim diyor generic ve t tipinden guid verdik onu alıyor

        //    int için bu metodu cagırınca int dönerim diyor

        //    M2.MusteriNumarasiAl();

        //    yanlıs anlasılan kısımı anlatmak için musterigeneric e gidelim

        //    7. not bitiş

        //    8. not bitiş musterigeneric ten geldik

        //    9. not baslangıc

        //    bu derste generic class ların mantıgnı gorduk fakat kullanma yontemi bu degil diger derste katmanlı mimari ile ogrenecegız


        //    */

        //    //3. not baslangıc

        //    V177Musteri M1 = new V177Musteri();
        //    M1.ID = 1;
        //    M1.TcKimlikNo = "12254401254";
        //    M1.MusteriNo = "MS123";
        //    M1.Isim = "Mücahit";
        //    M1.SoyIsim = "Çetinkaya";
        //    M1.DogumTarihi = DateTime.Parse("13-06-1994");

        //    //5. not baslangıc

        //    V177MusteriGeneric<int> M2 = new V177MusteriGeneric<int>();
        //    M2.ID = 1;

        //    V177MusteriGeneric<Guid> M3 = new V177MusteriGeneric<Guid>();
        //    M3.ID = Guid.NewGuid();

        //    //7. not baslangıc

        //    V177MusteriGeneric<Guid> M4 = new V177MusteriGeneric<Guid>();
        //    M3.MusteriNumarasiAl();

        //    M2.MusteriNumarasiAl();

        //}

        #endregion


        #region VİDEO 178 Generic Class Nedir

        //static void Main(string[] args)
        //{

        //    /*
            
        //        Bolum 22 Generic V178 Generic Class Nedir
             
        //    */

        //    /*
             
        //    1. not baslangıc
            
        //    generic class lar nedir bunlardan bahsedelim

        //    once ufak bir çizim yapıp bazı mimarilerden bahsedeceğim
        //    bazı iletişim kurallarından bahsedeceğim

        //    biz datamızı nasıl oluyorda database den cekıyoruz 
        //    cekmıs oldugumuz data uzerınde ne gibi işlemler yapabiliyoruz
        //    bunları alırken de generic class lar bize nasıl yardımcı oluyor 

        //    generic mimariyi inceleyeceğiz gercek hayatta da karsımıza bu sekılde gelirler

        //    bizim oncelıkle datayı okudugumuz bir database miz var 
        //    bu database miz de şimdilik MSSQL olsun 

        //    burada datalarımızı saklıyoruz
        //    musterı urun ve benzerı uygulamanın calısacagı veya calısması ıcın gereklı olan tum datalarımızı database mız da saklıyoruz

        //    bir de elimiz de uygulamamız var bu uygulamadan da database mizi yonetiyoruz

        //    musteri buraya veri getiriyor deger girisi yapıyor deger sorguluyor yada operasyonel bir surec baslatıyor
        //    bız de bunu C# ile yazıyoruz 
        //    burda web mobil masaustu platformdan bahsetmıyoruz 
        //    uygulama dilinden bahsediyoruz

        //    mssql içinde var olan bir tablo uzerınden gidelim bir onceki dersimiz de ornegımız musteri idi 

        //    bizim tblMusteri adında bir tablomuz olsun 

        //    tablo ıcındekı field ların isimleri ve veri tiplerini yazalım 

        //    adı                 sql veri tipi                   c# veri tipi
        //    id                  int                             int
        //    musteriNumarasi     uniqueidentify                  (Guid)
        //    isim                nvarchar(50)                    string
        //    soyisim             nvarchar(50)                    string
        //    dogumTarih          datetime                        datetime

        //    bu nesnenin c# tarafında nesne ornegını almaya calısırken bir onceki derste yapmıs oldugum gibi bunları K L T tipi gibi ayrıstırıp daha sonra ilgili nesnenin içindeki field lara aktarmam mantıksız

        //    id zaten int ilerlerde guid olmayacak olursa da id olarak tutmus oldugum int larımı guid e cevirmem gerek olmayacak bir surec bu 

        //    yada dogumTarihi datetime dı ben bunu string tutmam string tutmak bunu K tipi yapmak nesneyi orneklerken datetime demek bunlar cok utopik ornekler 

        //    gercek hayat orneklerıne bakarsan ben dogumtarihini c# da da datetime olarak tutarım 

        //    burda generıc mimariyi kullanmak aslında uygulamanın tasarım desenlerıne giriyor 

        //    mesela biz tasarım deseni olarak

        //    UnitOfWorks u kullanıyorsak => Generic Class || Generic Interface || DBFirst veya CodeFirst yaklasımlarından bir tanesini kullanacagız işte generic class lar bize bu nokta da yardım edecek 

        //    bizim iş katmanlarımızı biz bunları Repository olarak adlandıracagız 

        //    Repository lerimizi daha dinamik yazabilmemizi bir kere yazıp birden fazla kere farklı farklı entity lerimiz için kullanmamızı saglayan yapılardır generic class lar 

        //    sımdı generic bir repo ornegi yazalım ve generic class ı anlatmaya calısalım 

        //    Musteri nesnesi olusturalım 

        //    1. not bitiş

        //    2. not bitiş Musteri den geldik

        //    3. not baslangıc

        //    genericRepository adında bir class acalım

        //    generic repository leri biz enttity frame work yaklasımlarımız da yogun olarak kullanacagız 

        //    UnitOfWorks tasarım deseni yaklasımını kullanıp generic mimariyi de bu egitim seti içerisinde goreceksınız

        //    generic konusu oyle bir konudur ki şimdi anlatıcam bir kac bolum sonra gercek orneklerı de kullanmaya baslayacagız 

        //    bu nedenle generıc nedir nasıl tanımlanır class field içerisinde tanımlayabilmeniz yeterli ama generic koleksiyonları anlamanız gerekiyor 

        //    generic koleksiyonları bilmeniz gerekiyor ogrenmenız gerekiyor 
        //    generic class lar için henuz erken 

        //    generic class ları da burda gosterıyorum konu butunlugu bozulmaması ıcın 

        //    GenericRepository class ına gidelim

        //    3. not bitiş
            
        //    4. not bitiş GenericRepository den geldik

        //    5. not baslangıc

        //    GenericRepository i ornekleyelim

        //    V178GenericRepository<V178Musteri> M1 = new V178GenericRepository<V178Musteri>();

        //    olsturmus oldugum Musteri class ını genericrepository e veri tipi olarak verdim

        //    bu ne demek

        //    git database e musterileri getir dicem bana 

        //    M1. diyerek devam edelim

        //    M1.Getir(); dedigimiz de diyorki ben herhangi bir parametre almam sana list generic koleksiyonundan musteri nesnesi donerim
        //    List<V178Musteri> V178GenericRepository<V178Musteri>.Getir()

        //    gorevi nedir

        //    gidecek database e Musteri tablosundaki kayıtları entityframework dbfirst codefirst yaklasımlarından herhangi birini alarak getirecek
        //    bunu list generic musteriye cevirecek ve bana iletecek

        //    cagırdıgımızı bir degiskene atalım List generic musteri donuyor 

        //    List<V178Musteri> musterilerim = M1.Getir();

        //    generic class ı gercek hayatta kullanabilecegımız bir ornekle sızın karsınıza getirmiş oldum

        //    ne yapmıyoruz ozel olarak olusturmus oldugumuz tablo class larımızı biz bunlara entity diyoruz varlıklarımızı generic olarak olusturmuyoruz 
        //    uygulama içerisinde yazmıs oldugumuz operasyonel sureclerımızı bir kere yazabilmek için generic koleksiyonlar olusturup 
        //    ekranda gordugunuz sekılde kullanıyoruz en basiti olarak

        //    genericrepository mizi olusturduk
        //    ıcerısıne musterı nesnemızı attık 
        //    ve kullanacagımız butun metotlar ne oldu musterı tablosunu goren ve musterı tablosu uzerınde ıslem yapabilen bir class yıgını haline geldi veya class içerisinde metot yıgını haline geldi 

        //    yeni bir class olusturalım 

        //    Urun oraya gidelim

        //    5. not bitiş

        //    6. not bitiş Urun den geldik

        //    7. not baslangıc

        //    urun class ını tip olarak kullanalım repo da 

        //    V178GenericRepository<V178Urun> repoUrun = new V178GenericRepository<V178Urun>();

        //    sen dedım urunle ilgili işlem yapacaksın 

        //    getir ile cagırınca da 

        //    List<V178Urun> V178GenericRepository<V178Urun>.Getir()

        //    list generic urun donerım diyor 

        //    ne yapmıs oldum database git urun tablosundan urunlerı list generic olarak getir demıs olduk

        //    renericrepository mi bir kere yazdım ve olusturmus oldugum varlıklarımı kullanarak database den kayıt okumus olduk 
        //    tek bir metot yazdık içeride getir adlı bir metot var 

        //    geriye T tipi donecek sekılde bana datayı getiriyor 

        //    V178GenericRepository e gidelim yeni bir metot yazalım kayıt eklemek için

        //    7. not bitiş

        //    8. not bitiş V178GenericRepository den geldik

        //    9. not baslangıc

        //    kayıt ekleme olayına bakalım

        //    repoMusteri.yeniKayitEkle(null); yazınca tooltype in de asagıdaki yazıyor

        //    void V178GenericRepository<V178Musteri>.yeniKayitEkle(V178Musteri data)

        //    repoMusteri V178Musteriden aldıgı için yeniKayitEkle nin tipi musteri oldu t tipinden bana musteri ver onu kayıt edeyim diyor

        //    repo urun olarak yenikayıtekle yi cagırınca t tipinden V178Urun olur bana urun ver gidip onu kayıt edeyim diyor

        //    tooltype in de yazan

        //    void V178GenericRepository<V178Urun>.yeniKayitEkle(V178Urun data)

        //    yani ben bir class a birden fazla entity için işlem yapabilme imkanı sunmus oluyorum generic class ları kullanarak

        //    generic class ları tasarım desenlerın de daha net gorecegız 

        //    bir kac kuraldan daha bahsedeyım veya kullanım sekıllerı

        //    V178GenericRepository e gidelim

        //    9. not bitiş

        //    10. not bitiş V178GenericRepository geldik

        //    11. not baslangıc

        //    dersi tamamladık diger konuya gecelim


        //    */

        //    V178GenericRepository<V178Musteri> repoMusteri = new V178GenericRepository<V178Musteri>();
        //    List<V178Musteri> musterilerim = repoMusteri.Getir();


        //    V178GenericRepository<V178Urun> repoUrun = new V178GenericRepository<V178Urun>();
        //    List<V178Urun> urunlerim = repoUrun.Getir();

        //    repoMusteri.yeniKayitEkle(null);
        //    repoUrun.yeniKayitEkle(null);



        //}

        #endregion

    }
}
