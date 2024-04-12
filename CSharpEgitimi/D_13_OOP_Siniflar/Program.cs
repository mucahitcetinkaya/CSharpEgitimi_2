using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_13_OOP_Siniflar
{
    internal class Program
    {

        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 120

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 13 OOP Sınıflar VİDEO 120 Bilgilendirme

        //    */

        //    /*

        //    notlarda acıklaması var

        //    */


        //}

        #endregion

        #region VİDEO 121

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 13 OOP Sınıflar VİDEO 121 Sınıf Tanımlama ve inceleme - 1

        //    */

        //    /*

        //    biz ne demiştik ilk derslere baslamadan once


        //    namespace D_13_OOP_Siniflar
        //    {
        //        internal class Program
        //        {

        //            static void Main(string[] args)
        //            {
        //                Console.WriteLine("Merhaba Dünya");
        //            }

        //        }
        //    }

        //    biz eğitime Console.WriteLine("Merhaba Dünya"); dan basladık
        //    tipleri gördük
        //    farklı kullanımları gördük operatörler vs
        //    bir üste cıktık metotları gördük
        //    bir üste cıkıp class ları gördük
        //    sonrada bu class lara baglı ama burda gozukmeyen seylerı de goreceğiz

        //    biz metotları görmeden once de metotları kullandıgımızı söylemiştik
        //    biz aslında merhaba dunya yazarken de aslında class ları kullandık
        //    class ı degıl class ları kullandık
        //    Program class ı ve console class ını kullandık
        //    c# .net framework yüzde yüz bir nesne yönelimli programlama dilidir.

        //    mesela string in üzerine gidip F12 e basarsam veya sag tık go to definition tıklarsak
        //    string in detayını görürüz ve string in de bir class oldugunu görürüz
        //    aslında benım metın sakladıgım degiskenımın tipi bile aslında bir class
        //    yuzde yuz nesne yonelimli ifadesini tam olarak burda alıyor

        //    ozel olarak yazılmıs bir class ın sistem içerisinde 
        //    nasıl tanımlanabildiğini inceleyelim

        //    bir class olusturalım
        //    ekleyecegımız projeye sag tık add class a tıklayıp isim vererek bir class olusturalım
        //    Musteri121 class ını olusturduk 121. video dayız
        //    ekledıgımız yerde .cs dosyası olarak olustugunu görürsünüz

        //    böyle yapmayıp yani farklı bir class acmak yerine ama boylesi daha iyi tabiki
        //    kullandıgın yerdeki scop aralıgından cıkarak farklı bir class olusturabilirsin
        //    mesela bizim su anda kullandıgımız 
        //    class Program
        //    {

        //    }

        //    bunun scop un dan cıkarak baska bir class da yazabilirsin

        //    bir namespace birden fazla classı barındarabilir bu bir uzaydı bundan bahsetmiştik

        //    Musteri121 class ına bakın aynı namespace de ler

        //    bu sekildeki kullanımlar pek tavsiye edilmiyor kodun okunaklıgı acısından

        //    bizim class larımız namespace in altında durur en ust seviye class ları barındırır
        //    class lar metotları barındırır
        //    metotlar işleri yapar

        //    Musteri121 class ına gidip orda işlemler yapalım - 1. not
        //    1. not bitişinden geldik

        //    orda yapılan degısıklerı burda görmeye calısalım 
        //    Musteri class ımızı cagıralım

        //    once olusturdugumuz class ı yazıyoruz
        //    sonra bunu sistem içinde cagırabileceğimiz bir isim gerekiyor onu yazıyoruz
        //    sonra da new anahtar kelimesi ile tekrar class ımızı yazıp new leme yapmıs oluyoruz
        //    sistemde bunun ornegını olusturuyoruz
        //    ram tarafını tekrar anlatacagız
        //    parantezlere constructor diyoruz bunu da ileride görecegiz yapıcı metot
        //    program ilk calıstıgında calısan kısım
        //    yani telefonumuz var elimize aldık su anda 
        //    içindeki özelliklere (property lere) ulasabiliriz

        //    şimdi M1. dedıgımde bu tanımlara ozelliklere ulasabilmemiz gerekiyor
        //    M1 demek benim için Musteri121 demek oluyor
        //    M1. dedıgımızde nesnenın içindeki tanımlara ulasabilmemiz gerekiyor
        //    ama M1. dedıgımız de birşey cıkmıyor
        //    cıkmama sebebini ogrenmek için tekrar Musteri121 class ımıza gidelim
        //    neyi eksik yaptık ona bakalım

        //    2. not için Musteri121 e gidelim
        //    2. not bitişten geldik

        //    3. not baslangıc
        //    TcKimlikNumarasi ni public yaptık
        //    M1. dediğimizde bu alan field olarak geliyor tooltype kısmında cıkıyor
        //    erişim belirleyicisini public yapınca dış dünyaya acmıs olduk
        //    digerlerini de public yapmamız lazım
        //    ne zaman gerekmez 

        //    Musteri class ı içinde olusturdugumuz bir alanı yine musteri içerisindeki metotların
        //    birisinde kullanıyor ve bunu dıs dünyaya acmaya gerek duymuyorsak
        //    bunu private olarak bırakabiliriz
        //    dıs dunyada bir musteri nesnesi olusacagı zaman fieldlarımızı 
        //    public olarak işaretlemeliyiz
        //    gidip diger alanları da public yapalım
        //    3. not bitiş
        //    3. not bitişten geldik

        //    diger alanları da public yaptık burda dolduralım


        //    şimdi biz uygulamımızı calıstırdıgımız da ram üzerinde nesnemiz nasıl sekillenecek
        //    ram üzerinde nasıl bir yapıya bürünüyor
        //    bunlara bakacagız

        //    */

        //    //// 1. not 
        //    //Musteri121 M1 = new Musteri121();

        //    //// 2. not 
        //    //Musteri121 M1 = new Musteri121();
        //    //M1.Selam();

        //    //Musteri121.Selam();

        //    //// 3. not 
        //    Musteri121 M1 = new Musteri121();
        //    M1.TcKimlikNumarasi = "12345678910";
        //    M1.isim = "Mücahit";
        //    M1.soyIsim = "Çetikaya";
        //    M1.cinsiyet = 717770001;

        //}

        ///*

        //class Musteri121Programcs
        //{

        //}

        //*/

        #endregion

        #region VİDEO 122

        //static void Main(string[] args)
        //{
        //    /*

        //    Bölüm 13 OOP Sınıflar VİDEO 122 Sınıf Tanımlama ve inceleme - 2

        //    */

        //    /*

        //    121 in devamı notlar karısmasın 122 e göre not alınacak
        //    yeni bir musteri class ı acılacak

        //    debug anlatımı

        //    Musteri122 e breakpoint koyalım
        //    calıstıralım 
        //    M1 in üstine gelince null yazdıgını görüyoruz
        //    neden M1 null yazıyor ona bakalım


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


        //    M1 in null kısmını stack kısımda bir nokta olarak dusunelim
        //    biz nesnemizi program içinde cagırdıgımız da 
        //    stack bolgesindeki M1 e ulasıyoruz
        //    M1 demek stack bolgede bir pointer işaretçi olarak durması demek
        //    = new Musteri dediğimiz de Musteri nesnemizin içerisinde bulunan
        //    tüm alanların metotların bir paket olarak 
        //    heap bölgede acılması demek

        //    breakpoint i ilerlettiğimiz de M1 null olmayacak
        //    new lenmıs olacak
        //    M1 bir musteri yi gostermıs olacak
        //    heap bolgede duran bir musteriyi işaret etmiş olacak
        //    buna referans tipli bir davranıs deniyor

        //    ilerlettiğimiz de ben artık null degilim diyor
        //    benim işaret ettiğim bir bölge var diyor
        //    oda
        //    {NetFramework.D_13_OOP_Siniflar.Musteri122}
        //    dir diyor
        //    bunu ok kısmından actıgımız da ram uzerınde olan degerlere ulasabiliyoruz
        //    henuz bir deger ataması yapmadıgımız için default degerler ile geliyor
        //    string in default degeri null
        //    int in default degeri 0 dır

        //    programı ilerletip degerleri atalım ok kısmından tekrar bakalım degerler atandı
        //    atanan degerler
        //    heap bolgedeki kısımda tutuluyor
        //    buda Musteri122 nin field kısmında olan kısma deger ataması yapmıs oluyosun

        //    buraya ulasmak için M1 i kullanıyoruz

        //    bir Musteri daha tanımlayalım M2 diyelim

        //    M2 ye de M1 i atayalım

        //    bu sefer ne olacak

        //    M2 de stack kısımda olusacak

        //    ama heap bolgede işaret ettiği yer M1 ile aynı yer olacak
        //    M2 için tekrar heap bolgede bir yer olusturmayacak
        //    ortak yerleri kullanacak

        //    uzaktaki birinin bir vazoyu gosterdiğini dusunun
        //    baska bir kişi gelince aynı seyi göstermesi için
        //    onunda kişiyi degil vazoyu göstermesi gerekir

        //    2. kişi 1. kişiyi gösterirse mantıklı olmaz 
        //    amac vazo vazoyu gostermesi gerekir

        //    vazoyu degistirip baska bişey koyarsan oraya gosterilen yer aynı 
        //    o zaman deger degişir

        //    1 kişiyi kaldırdım yine vazoyu gosterir
        //    2 sinide kaldırırsak neyi gosterdiğini bulamayız

        //    Musteriden yeni bir new leme yapalım

        //    sistemde bir pointer daha olusturduk ama bu M2 oldu
        //    bunun ozel bir degeri olmayacak
        //    M1 neyi gosteriyorsa onu gosterecek

        //    M1 neye bakıyorsa sende ona bak diyoruz

        //    ben m1 veya m2 uzerınden bir degeri degistirdiğim de 
        //    degerin degismesi gerekir yapalım


        //    kurgulayarak gidelim kişi olarak anlatacagız sizde öyle yapın
        //    nesne yonelimli programlayamayı ogrenırken 
        //    gercek hayattan ornekleri bolca kullanmalıyız
        //    cunku biz gercek hayatta da nesne yönelimli bir dunya da yasıyoruz
        //    telefon bilgisayar vs hepsi birer nesne aslında

        //    M1 nesnesi olusurken
        //    M1 null olarak duruyor new ile orneklenmesı gerekir
        //    new lenmediği için ondan dolayı null

        //    diyoruz ki suraya bak baktıgında new lenme işlemi oldugunda ornek olusmus oluyor
        //    sonra diyoruz ki oraya su degerleri yaz

        //    sonra M2 olusacak once null new lenmesı gerekiyor
        //    M2 e diyoruz ki m1 in yanına git neye bakıyorsa aynı yere bak

        //    şimdi biz m2 e diyoruz ki isim degerini guncelle
        //    ram e gidip guncelleyecek m1 bu guncellemeyi gorur aynı yere bakıyorlar
        //    m1 e desek oda aynı işlemi yapacak bu sefer de m2 gorecek


        //    M2 ve m1 den degisiklik yapıp degistirdik
        //    degerler degisti


        //    burası referans tipli davranısın anlatımı 
        //    class lar referans tiplidir.

        //    ---------------------------------------------

        //    birde soyle yapalım M2 ve M1 yi null a alıp yani bos a cekelim
        //    sonrada atama işlemi yapalım o zaman ne olacak

        //    şimdi buradaki mantıgı anlatacagız
        //    bellekten dusmeler nasıl oluyor

        //    garbage collector çöp toplama nasıl işliyor

        //    garbage collector dedıgımız bir mantık var
        //    bizim burda o mantıga dokunmamız anlamsız
        //    .net framework garbage collector dediğimiz bir yapı ile ram den dusen artık atıl kalan 
        //    nesneleri temizliyor bu temizleme mantıgından biraz bahsedelim

        //    M2 null kısmına breakpoint koyalım
        //    m2 e diyoruz ki sen ortamdan cekil
        //    m2 e diyoruz ki sen artık buraya bakma
        //    m2 e ulasınca null gorecegız bir yere bakmıyor yani

        //    benım degerım m1 in uzerınde 
        //    yanı benım degerımı heap bolgede degerımı stack bolgede duran
        //    bir pointerim hala tutuyor
        //    yani ben dataya m1 uzerınden hala erişebiliyorum
        //    peki ben m1 i de ortamdan kaldırdıgımda 
        //    yani m1 i de null yaptıgımız da 

        //    artık bellekte o bilgiyi tutan bir pointerim olmuyor
        //    işte tam bu boktada arkada bir yapı calısıyor

        //    heap bolgede bir deger pointersiz kalırsa
        //    yanı onu gosteren bir deger kalmaz ise

        //    bu deger ram den duser

        //    arkada atıl kalan datayı alan garbage collector yapısı bunu siler

        //    m2.isim e ulasmaya calıstıgımız da null hatası alırız
        //    m2 nin musteri nesnesi oldugunu biliyorum
        //    ama senın bana gosterdıgın deger acılmamıs diyor onun hatasını verıyor

        //    boyle bir hata alıyorsanız = new dememıssınızdır


        //    */

        //    Musteri122 M1 = new Musteri122();
        //    M1.TcKimlikNumarasi = "12345678910";
        //    M1.Isim = "Mücahit";
        //    M1.SoyIsim = "Çetinkaya";
        //    M1.Cinsiyet = 717770001;

        //    Musteri122 M2 = M1;

        //    M2.Isim = "Muhammet";
        //    M1.TcKimlikNumarasi = "122544013250";

        //    M2 = null;
        //    M1 = null;

        //    string isim = M2.Isim;



        //}

        #endregion

        #region VİDEO 123

        //static void Main(string[] args)
        //{
        //    /*

        //    Bölüm 13 OOP Sınıflar VİDEO 123 Yapıcı Metot Kullanımı

        //    */

        //    /*

        //    biz musteri new musteri dediğimizde sistem
        //    stack bolgeden heap bolgeye datayı cıkartırken
        //    default degerler ile cıkartmıs oldugunu soylemıstık
        //    ve bunu nasıl duzeltebilecegımızden bahsedecektik

        //    tekrar hatırlayalım

        //    Musteri123 M1 = new Musteri123(); e 
        //    breakpoint koyalım
        //    calıstıralım uygulamayı
        //    buraya geldıgınde M1 in uzerıne gelınce null olarak yazıyor
        //    gecınce nesneyi new lemıs orneklemıs oluyor
        //    stack bolgede bir point tutuyor

        //    sonra M1. diyip field larını doldurunca field lar heap bolgede tutuluyor
        //    nesne üzerinden bir işlem yaptıgında heap bolgeyi işaret etmiş oluyosun

        //    nesne olusturdugunda new Musteri() deki () parantezler
        //    bir nesne olustur ama default degerler ile olustur demek oluyor

        //    default degerleri degıstırmek için tam bu noktada 
        //    Constructor yapıcı metot olarak bilinen bir metot var
        //    tam olarak bu noktada calısıyor

        //    bu metodun detayına inmek için 
        //    Musteri123.cs i olusturalım gerekli field alanlarını yazalım 
        //    erişim belirleciyi kısımlarını public yapalım

        //    1. not oraya gidelim
        //    Musteri123 den geldik 1.not bitişi

        //    2. not başlangıc

        //    debug edelim

        //    gerekli nesneyi new leyelim
        //    field alanlarını dolduralım

        //    Musteri123 e breakpoint koyalım
        //    TcKimlikNumarası null mı olacak ctor da verdiğimiz deger mi gelecek
        //    ona bakalım

        //    ilk calısıtında M1 null ornekleme olmadı
        //    ilerletelim
        //    f10 üstünden geçiyor f11 içine giriyor

        //    f11 ile gidince ctor içine gitti ilk yapıcı metot calıstı
        //    f10 ile devam ettik sonra
        //    ilk ctor calıstıgı için oradaki degeri aldı
        //    ilk default ayarını degistirmiş olduk
        //    diger kısımlar default ayarları duruyor onlara bişey vermedik

        //    Musteri123() deki () parantezler bir metodu gösteriyor demiştik
        //    bu bir metodu gosteriyorsa ve ben bunu ezdiysem
        //    ezmekten kastımız su var olan bir metodun terkar üzerinden 
        //    geçip bunu kullan diyoruz

        //    bu konuyu virtual metotlarda goreceksınız burda olay ezmek kısmını anlamak

        //    var olan bir yapı var ben buna mudahale etmek istiyorum
        //    var olan seklini bozmak ezmektir zaten ve ben bunu ezdim

        //    f11 ile içeriye dogru gittiğimde yapıcı metota gitti
        //    musteri class ının içerisindeki ctor a gitti

        //    tckimliknumarası default degeri degil benim verdiğim degeri aldı

        //    f10 ile devam edince nesne orneklendı default ayarlarını degıstırmıs olduk

        //    bu işlemi yapıcı metot olayını
        //    Musteri123() deki () parantezler arasında yapıyor
        //    nesne orneklenmeden once yapıcı metotlar calısıyor
        //    default degerleri degistiriyor boylece

        //    peki bizim birden fazla yapıcı metodumuz olabilir mi 
        //    hatırlarsanız metotlar kısmında bir metot ismi ile 
        //    overload asırı yukleme yapmıstık

        //    toplama int + int 
        //    toplama string + string
        //    toplama decimal + decimal gibi

        //    ben istiyorum ki benım musteri orneklenirken 
        //    orneklenme asamasında benden parametre olarak bazı degerler istesin
        //    ben o bazı degerleri verdiğimde o degerlere göre nesne orneğini alayım
        //    vermezsem default degerleri ile belleğe cıksın 

        //    bunun için Musteri123 e gidelim 

        //    2. not baslangıc
        //    2. not bitiş Musteri123 den geldik

        //    3. not baslangıc

        //    gerekli yapıcı metotları olusturduk
        //    sımdı burda yenıden new leyeme kalktıgımız da 
        //    Musteri123 M1 = new Musteri123( yazdıgımız da 
        //    4 tane overload cıkıyor yapıcı metotlara biz yazdık bunları
        //    bize diyor ki 
        //    dilersen bos bırak default degerler gelsin
        //    dilersen sadece tckimlikno ver
        //    dilersen tc ile isim
        //    dilersen tc isim soyisim ver

        //    mesela burda da deger vermek için 
        //    string _tcKimlikNo, string isim diyor
        //    string sekilde tc verdiyor string sekilde isim yaz diyor

        //    Musteri123 M1 = new Musteri123("123123123","Mücahit");
        //    a breakpoint koyalım debug yapalım
        //    f11 ile devam edelim parametredeki metotu yakalamak için

        //    m1 null orneklenmeden once Musteri123 e gidecek
        //    gerekli overload a dusecek

        //    Musteri123 e gidelim 

        //    3. not devam 
        //    3. not bitiş Musteri123 den geldik

        //    4. not baslangıc
        //    atama işlemlerını yapıp buraya new lemeye geri gelecek

        //    new len dıgınde direk ctor dan verdiğimiz verilerle gelecek
        //    vermezsek eger bos default ayarları ile gelir

        //    iş biz bu mantıga yapıcı metot diyoruz
        //    hiç dokunmazsak default degerleri ile gelir veri tipine göre
        //    bos olarak calısır

        //    yada biz buna mudahale edip class içinde yapıcı metotları olusturup kullanırsak
        //    o zaman da şöyle bir artımız olur 
        //    sen burda degerleri alırken su kriterler ile al 
        //    sunu kontrol bu field içine bunu ver 
        //    veya sabit olarak bunu ver gibi ayarlar yapabiliyoruz

        //    yogun olarak kullandıgımız sekilde budur

        //    cok nadir nesnenin içine dokunmadan işlem yaparız

        //    oop de database e giden katmanlar da 
        //    cogunlukla dokunuruz
        //    ctor lar kullanılan onemli bir alan

        //    diger dersimiz de 
        //    nesneyi ornekleyip cagırırken M1. gibi 
        //    field alanlarında bizim olusturmadıgımız 
        //    ama gozuken kodlar cıkıyor 
        //    mesela ToString gibi bunlar nedir nerden geldi bunlara bakacagız

        //    ufak olarak bu konulara girecegız bunlar normal de kalıtım konusunun konuları

        //    diger derse gecelim

        //    */

        //    // 2. not
        //    Musteri123 M1 = new Musteri123("123123123","Mücahit");
        //    M1.TcKimlikNumarasi = "1";
        //    M1.Isim = "Mücahit";
        //    M1.SoyIsim = "Çetinkaya";
        //    M1.Cinsiyet = 717770001;


        //    // 1. not
        //    //Musteri123 M1 = new Musteri123();
        //    //M1.TcKimlikNumarasi = "1";
        //    //M1.Isim = "Mücahit";
        //    //M1.SoyIsim = "Çetinkaya";
        //    //M1.Cinsiyet = 717770001;

        //    //Musteri123 M2 = M1;

        //    //M2.Isim = "Muhammet";
        //    //M1.TcKimlikNumarasi = "2";

        //    //M2 = null;
        //    //M1 = null;

        //    //string isim = M2.Isim;


        //}

        #endregion

        #region VİDEO 124

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 13 OOP Sınıflar VİDEO 124 Sınıflarda Metotların Kullanımı

        //    */

        //    /*

        //    bu derste sınıfların içinde metot kullanımlarına bakacagız
        //    Musteri class ı olusturacagız
        //    field larımızı yazacagız

        //    public private olarak inceleme yapacagız

        //    Musteri124 e gidelim bir metot olusturalım

        //    1. not baslangıc
        //    1. not bitişi Musteri124 den geldik

        //    2. not baslangıc

        //    gerekli işlemleri yaptık nesne olustur field ları doldur vs 

        //    metotlarla işimiz var M1. uzerınden metot cagıralım

        //                bool musteriKontrol = M1.MusteriKontrol();

        //    parametre vermiyoruz buraya breakpoint koyalım debug yapalım

        //    bu metot onemli sebebi public bir metodun içinde private bir metot cagırıp 
        //    dönen degeri döndürüyoruz ondan dolayı onemli 

        //    şimdı bunu yazdık breakpoint koyup cagırdık

        //    M1 in üzerine gelince içinde alanlarını görebiliyoruz

        //    f11 ile devam edince metotun içine dallanıyor

        //    musterikontrol metotu herhangi bir parametre almıyor

        //    musterikontrol metodu dısarıdan onu cagıran kişiden herhangi bir deger almıyor

        //    musteri nesnesinin içindeki field ları kullanacak

        //    o verileri kullanacak işlemlerini yapacak zaten deger ram de var

        //    calısturıp f11 ile içine geçtiğimde
        //    MusteriKontrol body sine geliyor scoplarına düşüyor kod 

        //    MusteriKontrol içinde de MusteriKontrolDataBase adlı farklı bir metoda ulasmak istiyor
        //    MusteriKontrolDataBase private aynı yerde oldukları için ulasabiliyor

        //    parametre istiyor istediği parametre Musteri124 ün içindeki alanlardan

        //    aldıgı veri ile MusteriKontrolDataBase metoduna gidiyor
        //    gelen deger ile kayıtlı olan deger aynı true u alıyor tekrar bu kısımda kurgusal olarak
        //    database de kontrol etmıs gibi davrandık
        //    MusteriKontrol e return ediyor

        //    oda tekrar kontrol degiskenını program cs e return ediyor
        //    dış dünyaya program.cs e MusteriKontrol ün cagrılan yerine gönderiyoruz

        //    nesne içinde metot
        //    metot içinde metot 
        //    metot içinde parametre 
        //    return edilen sonucu return etmiş oluyoruz

        //    peki M1 içinde 

        //    MusteriKontrolDataBase metoduna bakalım göremiyoruz neden
        //    cunku public olarak işaretlenmemiş
        //    private oldugu için sadece olusturuldugu yerde kullanabiliyoruz

        //    yeri gelmişken diger erişimbelirleyicilerine bakalım 
        //    private olanı internal yaptıgımızda 
        //    M1. dediğimizde MusteriKontrolDataBase metodunu görebiliriz
        //    internal demek bu namespace içinde bu classı ornekleyenler bu classa ulasabilirler

        //    yani bu namespace guvenli alandır demıs oluyoruz 
        //    yanında da bir kalp ikonu cıkıyor internal diyince

        //    public kim cagırırsa cagırırsın herkese acık oluyor
        //    internal namespace catısı altında geçerli oluyor

        //    MusteriKontrolDataBase kısmında sql de veri tabanında kayıtlı kısımlardan 
        //    tckimlik numarasına göre kullanıcı bulup ekli oldugunu varsayalım 
        //    digerleri ileri konular


        //    */


        //    Musteri124 M1 = new Musteri124();
        //    M1.TcKimlikNumarasi = "1";
        //    M1.Isim = "Mücahit";
        //    M1.SoyIsim = "Çetinkaya";
        //    M1.Cinsiyet = 717770001;

        //    Musteri124 M2 = M1;
        //    M2.Isim = "Muhammet";
        //    M1.TcKimlikNumarasi = "2";

        //    bool musteriKontrol = M1.MusteriKontrol();
        //}

        #endregion










    }
}
