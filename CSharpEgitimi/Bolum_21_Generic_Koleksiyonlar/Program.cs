
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Bolum_21_Generic_Koleksiyonlar
{
    internal class Program
    {

        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion

        #region VİDEO 170 Generic mimariden önce tip güvenli listeler ile çalışmak

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 21 Generic Koleksiyonlar V170 Generic mimariden önce tip güvenli listeler ile çalışmak

        //    */

        //    /*

        //    1. not baslangıc

        //    bu bölümde genericleri yani şablon tipleri inceliyor olacagız

        //    geceric mimari .net 2.0 ile birlikte geldi 
        //    genericten önce olusturmus oldugumuz arraylist lerimizi koleksiyonlarımızın içindeki degerleri tip güvenli yapabilmek için yani sadece istemiş oldugumuz tiplerin koleksiyon içerisinde barınabilmesi için 
        //    farklı bir yol izliyorduk generic mimariden sonra bunların hiç birine gerek kalmadı yazılım tarafında daha fazla esnekliğe kavusmus olduk 

        //    generic mimari nedir anlatmadan önce genericten önce 1.0 daki generic gibi kodlama yapabilmek için neler yaptıgımızdan bahsetmek istiyorum 
        //    nerden nereye geldik

        //    generic mimari ile birlikte koleksiyonları inceleyeceğiz
        //    generic mimariyi detaylı inceleyeceğiz
        //    koleksyionlar 
        //    class lar 
        //    metotlar 
        //    interface ler 
        //    kalıtımsal generic bolumlerını gordukten sonra ornek uygulama ve odevlerle devam edeceğiz 

        //    bu bolumden sonra generic mimariyi yogun kullanıp bunun üzerinde bişeyler ogrenmeye baslayacagız 

        //    genericten once biz neler yapıyorduk

        //    bir arraylist olusturalım newleyelim

        //    1. not bitiş

        //    2. not baslangıc

        //    ArrayList liste = new ArrayList();
        //    liste.Add();

        //    arraylist ler system.collection kütüphanesinde bulunan 
        //    içerisinde object ten deger tasıyan 
        //    bir koleksiyondu
        //    object tipinden veri kabul ettiği için .net framework teki her veri tipini buraya ekleyebiliyordum

        //    benım isteğim olusturmus oldugum koleksiyonuma sadece int girilebilsin sadece decimal girilebilsin
        //    yada benım olusturmus oldugum custom class larım burda eklenebilsin

        //    bunların cozumu için arraylist imizi baska bir class içinde saklayıp içine datayı metotlar ile giriyoduk 

        //    sanal bir db lazım bize SanalDatabase class ını olusturalım oraya gideli

        //    2. not bitiş

        //    3. not bitiş sanaldatabase den geldik

        //    4. not baslangıc

        //    sanaldatabase i newleyelim

        //    V170SanalDatabase S1 = new V170SanalDatabase();
        //    S1.YeniKayit(1);

        //    s1.yenikayit ile içeriye int deger atatık 

        //    içeriye arraylist imizi saklayarak dısarıyada metotlar acarak istemiş oldugumuz veri tiplerimiz ile arraylist mizi besleyebiliyorduk 
        //    generic gelmeeden önce 

        //    generic geldi ne oldu 

        //    generic koleksiyonlar geldi 
        //    class ın metotun interface in generic davranışları gelişti yeni bir davranıs sekli geldi bize esneklik sundu 

        //    sıradaki derse gecelim

        //    */

        //    // 2. not baslangıc
        //    //ArrayList liste = new ArrayList();
        //    //liste.Add();

        //    // 4. not baslangıc

        //    V170SanalDatabase S1 = new V170SanalDatabase();
        //    S1.YeniKayit(1);



        //}

        #endregion

        #region VİDEO 171 Generic Koleksiyonlar - List<T> kullanımı - 1

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 21 Generic Koleksiyonlar V171 Generic Koleksiyonlar - List<T> kullanımı - 1

        //    */

        //    /*

        //    1. not baslangıc

        //    LIST GENERIC

        //    generic koleksiyonlarda list generic koleksiyonu ile baslayalım 
        //    list generic koleksiyonu arraylist koleksiyonunun generic hali gibidir

        //    günlük programlamada cok sık kullanırız

        //    bir datayı liste içerisinde tutacaksan eger generic liste içinde tutmak isteriz list gecericleri yogun olarak kullanırız

        //    arraylist ornegi yazalım

        //    ArrayList list = new ArrayList();
        //    list.Add(1);
        //    list.Add("bir");

        //    list.add dediğimiz de object veri tipinden data kabul eden bir yapısı var 

        //    1. not bitiş

        //    2. not baslangıc

        //    list generic nedir 

        //    generic dedigimiz de bilmemiz gereken bir kavran var mesela T tipi diyecegiz T tipi demek herhangi bir tip demek

        //    genericleri <T> olarak küçüktür büyüktür işaretlerinin arasına yazarız

        //    <T> T tipi demek .ner framework içerisinde olan veya bizim olusturdugumuz herhangi bir tip demek 

        //    genel yazımına bakalım

        //    List yazınca tooltype acılıyor List<> yazıyor
        //    system.collection.Generic.List<T> yazıyor

        //    system.collection.generic kutuphanesi ile geliyor bunu tanıyor

        //    yukarıdaki using kısmını silip tekrar bakalım

        //    List<int> list = new List<int>();

        //    yazınca kırmızı yere geldiğinde using.system.collection.generic cıkıyor bunu ekleyelim

        //    arraylist i nası olusturuyorsam geceric list i de oyle olusturuyorum

        //    List<int> listeGeneric = new List<int>();
        //    yazdık ornekledik yukarı using eklendi

        //    listeGeneric.Add( yazınca tooltype acılıyor ve diyorki void List<int>.Add(int item) ben int item kabul ederim diyor
        //    arraylist in add metotunda ise object item yazıyor
        //    arraylist object ten herhangi bir deger kabul ederim diyor
        //    ben tip guvenlı olsun istiyorum koleksiyon sadece int deger kabul etsin istiyorum
        //    arraylist acarsam eger class acıp arraylist i private olarak saklayıp metot ile ona int göndermem gerekiyordu tip guvenlıgı için

        //    bu generic ile gerek kalmıyor buna direk <> içine yazınca guvenlı tipe almıs alıyorsun
        //    <T> tipi yazdıgında herhangi bir tip kabul eder hale geliyor

        //    deger ataması yapalım


        //    listeGeneric.Add(1);
        //    listeGeneric.Add(2);
        //    listeGeneric.Add("üç");

        //    "üç" yazınca hata veriyor 
        //    Argument 1: cannot convert from 'string' to 'int'

        //    int olan tipe string yazmıssın diyor

        //    string tipinde bir list olusturalım


        //    List<string> isimler = new List<string>();
        //    isimler.Add("mücahit");

        //    sadece string veri tipinde degerler kabul eder

        //    isimler.Add(123); gibi bir deger kabul etmez

        //    2. nota breakponit koyalım debug yapalım

        //    list int sadece int deger kabul
        //    list string sadece string deger kabul

        //    f10 ile edevam edelim sadece belirtmiş oldugum veri tipinden degerler içinde bulunuyor

        //    diger derse gecelim
        //    diger derste kendi olusturdugumuz bir tipimizi bir koleksiyon olarak nası kullanırız buna bakalım

        //    */

        //    //// 1. not 
        //    //ArrayList list = new ArrayList();
        //    //list.Add(1);
        //    //list.Add("bir");

        //    //// 2.not baslangıc
        //    //List<int> list = new List<int>();

        //    List<int> listeGeneric = new List<int>();
        //    //listeGeneric.Add(

        //    listeGeneric.Add(1);
        //    listeGeneric.Add(2);
        //    //listeGeneric.Add("üç");

        //    List<string> isimler = new List<string>();
        //    isimler.Add("mücahit");
        //    //isimler.Add(123);


        //}

        #endregion

        #region VİDEO 172 Generic Koleksiyonlar - List<T> kullanımı - 2

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 21 Generic Koleksiyonlar V172 Generic Koleksiyonlar - List<T> kullanımı - 2

        //    */

        //    /*

        //     1. not baslangıc

        //    olusturulan bir nesneyi koleksiyon olarak kullanmayı görecegız
        //    Musteri nesnesi olusturalım

        //    Musteri nesnesine gidelim

        //    1. not bitiş

        //    2. not bitiş musteri den geldik

        //    3. not baslangıc

        //    musteri nesnesini koleksiyon olarak kullanalım

        //    List<> : <> içinde yazmamız lazım 
        //    List<> yazınca benden T tipi istiyor yanı .net framework içinde gelen veya bizim olusturdugumuz herhangi bir nesne

        //     List<V172Musteri> musteriListe = new List<V172Musteri>();
        //    musteriListe.Add(new V172Musteri()
        //    {
        //        id = 1,
        //        isim = "Mücahit",
        //        soyisim = "çetinkaya"
        //    });

        //    tek tek add yazmak yerine içine yazdık prob ları 

        //    List<V172Musteri> musteriListe = new List<V172Musteri>(); breakpoint koyalım

        //    musteriListe kısmına sonra gelecegiz su anda baslangıc

        //    Add ile kendi olusturmus oldugum nesnemi koleksiyonuma eklemiş oldum.

        //    3. not bitiş

        //    4. not baslangıc dk 2.45

        //    olusturulan nesne içinde nası donecegız

        //    for ve foreach ile içerisinde donup ekrana yazdırabiliriz

        //    for ornek

        //    int ve string tipinde olusturdugumuz generic list ler diger derste kaldı onları da buraya yazalım

        //     List<int> listeGeneric = new List<int>();
        //    listeGeneric.Add(1);
        //    listeGeneric.Add(2);

        //    for (int i = 0; i < listeGeneric.Count; i++) 
        //    {
        //        Console.WriteLine(listeGeneric[i]);
        //    }

        //    List<string> isimler = new List<string>();
        //    isimler.Add("mücahit");
        //    isimler.Add("çetinkaya");

        //    for (int i = 0; i < isimler.Count; i++)
        //    {
        //        Console.WriteLine(isimler[i]);
        //    }

        //    foreach (V172Musteri item in musteriListe) 
        //    {
        //        Console.WriteLine(item.id);
        //        Console.WriteLine(item.isim);
        //        Console.WriteLine(item.soyisim);
        //    }

        //    foreach de

        //    V172Musteri tipinde list içinde doneceksin musteriListe de dön
        //    her birine item de
        //    item. yazarak da cagırman lazım

        //    her gelen yenilin bir oncesinin üzerine geliyor 

        //    arraylist te object ten alıp cevirip öyle işlem yapıyorduk
        //    genericte verdigimiz tipe göre işlem yapıyor 

        //    boxing unboxing işlemi olmuyor zaten yazarken tipini belirtiyoruz

        //    list generic in diger metotlarını görelim diger derse gecelim

        //    */

        //    /**/

        //    /*3. not*/

        //    List<V172Musteri> musteriListe = new List<V172Musteri>();
        //    musteriListe.Add(new V172Musteri()
        //    {
        //        id = 1,
        //        isim = "Mücahit",
        //        soyisim = "çetinkaya"
        //    });

        //    /*4. not*/

        //    List<int> listeGeneric = new List<int>();
        //    listeGeneric.Add(1);
        //    listeGeneric.Add(2);

        //    for (int i = 0; i < listeGeneric.Count; i++) 
        //    {
        //        Console.WriteLine(listeGeneric[i]);
        //    }

        //    List<string> isimler = new List<string>();
        //    isimler.Add("mücahit");
        //    isimler.Add("çetinkaya");

        //    for (int i = 0; i < isimler.Count; i++)
        //    {
        //        Console.WriteLine(isimler[i]);
        //    }

        //    foreach (V172Musteri item in musteriListe) 
        //    {
        //        Console.WriteLine(item.id);
        //        Console.WriteLine(item.isim);
        //        Console.WriteLine(item.soyisim);
        //    }

        //}

        #endregion

        #region VİDEO 173 Generic Koleksiyonlar - List<T> kullanımı - 3

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 21 Generic Koleksiyonlar V173 Generic Koleksiyonlar - List<T> kullanımı - 3

        //    */

        //    /*
             
        //     1. not baslangıc

        //    Add metotu harici farklı yardımcı metotlara bakalım

        //    int sayilarım adında list generic olusturalım

        //    List<int> sayilarim = new List<int>();
        //    sayilarim.Add(1);

        //    tek bir kayıt için add ile ekleyebiliriz
        //    birden fazla eklemek için ne yapmamız lazım

        //    örnek bir dizi olusturalım db gibi kullanmak için
            
        //    int[] eklenecekData = new int[3];
        //    eklenecekData[0] = 2;
        //    eklenecekData[1] = 3;
        //    eklenecekData[2] = 4;
            
        //    sayilarim ın içine degerleri eklemek için 
        //    for ile uzunlugu kadar kadar dönüp her bir i degerini ekleyebiliriz 1. yol olur ama uzun yol

        //    for (int i = 0; i < eklenecekData.Length; i++)
        //    {
        //        sayilarim.Add(eklenecekData[i]);
        //    }

        //    2. yol AddRange metotu

        //    sayilarim.AddRange(eklenecekData);

        //    AddRange kendi veri tipine uygun koleksiyonları kabul ediyor

        //    AddRange(eklenecekData) dedigimiz de içindeki bütün verileri kendi veri tipine uyuyorsa eger direk yazıyor
        //    kendi veri tipine uyuyorsa kısmı 
        //    sayilarim int bir generic koleksiyon
        //    addrange ile eklediğimiz de sadece int olanları ekliyor 

        //    eklenecek data int dizi oldugundan hepsini kabul ediyor debug yaptık gördük

        //    5.35
        //    -------------------------------------------------

        //    içeride Add ile eklenen 1 degeri var diger degerler diziden ekleniyor

        //    capacity ve count kavramlarına bakalım

        //    dizinin boyutunu yukseltelim 3 elemanlı bir dizi 4 elemanlı olsun capacity count farkını anlamak için yapıyoruz bunu

        //    int[] eklenecekData = new int[4];
        //    eklenecekData[0] = 2;
        //    eklenecekData[1] = 3;
        //    eklenecekData[2] = 4;
        //    eklenecekData[3] = 5;

        //    int capacity = sayilarim.Capacity;
        //    int count = sayilarim.Count;

        //    capacity e breakpoint koyalım ve debug yapalım

        //    3 elamanlı oldugunda capacity e geldiğinde içinde 4 tane deger var index olarak bakıldıgında 0 dan baslıyor index e kadar gidiyor 
        //    capacity count eşit cıkıyor 

        //    4 elemanlı olunca 

        //    diziler artmaya 4 erli seviyeden devam ederler 
        //    list generic ilk olustugunda count capacity sıfır olarak olusturur
        //    ilk degeri atadıgımız da 
        //    count 1 capacity si 4 olarak bellekte yer tutar
        //    list geceric ilk degeri aldıgında 4 degerlik bos yer olusturur diger 3 degeri alabilecegı sekilde revize eder
        //    biz içerisine deger atamaya devam edince bos olan yerleri doldurmaya devam eder 
        //    demin ki ornekte tam 4 e 4 geldiği için esit gibi oldu
        //    4 elamanlı yapınca 1 deger daha var add ile gelen
        //    count 5 
        //    capacity deger 8 olur
        //    4 ü geçince 8 olur 
        //    8 i gecince 16 olur
        //    2 üzeri şeklinde artmaya devam eder capacity

        //    kontrol için .Add kısmını cogaltman lazım en basta add ile eklediğinde 4 8 16 seklinde gidiyor 

        //    capacity ve count u eşitlemek istiyorsan eger TrimExcess i kullanabilirsin

        //    // soru sayilarım koleksiyonu içerisinde bulunan datayı ekrana yazdırmak istiyorum

        //    1. yol

        //    foreach (var item in sayilarim)
        //    {
        //        Console.WriteLine(item);
        //    }


        //     2. yol list generic içindeki ForEach() metotu

        //    sayilarim.ForEach();

        //    ForEach(); bizden cok farklı parametreler istiyor 

        //    delegeleri görmediğiniz için anlatmayacagım ama ufak bir giriş yapabiliriz

        //    ForEach(); cagırdıktan sonra Action ve delege istiyor 

        //    delege iş yapan bir parca istiyor

        //    sayilarim.ForEach(i => Console.WriteLine(i));

        //    i benim yazmıs oldugum bir karakter ne oldugu onemli degil standart olarak i kullanılıyor genelde 

        //    koleksiyoni içindeki her bir degere ulasırken i örnegi ile ulas 

        //    => işareti lamda işareti öyleki diyosun 

        //    ilgili koleksiyon içinde arama yap 

        //    arama yaptın ve bunu Console.WriteLine ile konsola yaz

        //    tek satırda foreach dongusu tanımlamıs olduk

        //    => lamda ifadesi linq konusunda geçiyor 


        //    */



        //    List<int> sayilarim = new List<int>();
        //    sayilarim.Add(1);
        //    sayilarim.Add(1);
        //    sayilarim.Add(1);
        //    sayilarim.Add(1);
        //    sayilarim.Add(1);

        //    //int[] eklenecekData = new int[3];
        //    //eklenecekData[0] = 2;
        //    //eklenecekData[1] = 3;
        //    //eklenecekData[2] = 4;

        //    //1. yol

        //    //for (int i = 0; i < eklenecekData.Length; i++) 
        //    //{
        //    //    sayilarim.Add(eklenecekData[i]);
        //    //}

        //    //2. yol AddRange metotu

        //    int[] eklenecekData = new int[4];
        //    eklenecekData[0] = 1;
        //    eklenecekData[1] = 2;
        //    eklenecekData[2] = 3;
        //    eklenecekData[3] = 4;
        //    //eklenecekData[4] = 5;
        //    //eklenecekData[5] = 6;
        //    //eklenecekData[6] = 7;
        //    //eklenecekData[7] = 8;
        //    //eklenecekData[8] = 9;
        //    //eklenecekData[9] = 10;
        //    //eklenecekData[10] = 11;
        //    //eklenecekData[11] = 12;
        //    //eklenecekData[12] = 13;
        //    //eklenecekData[13] = 14;
        //    //eklenecekData[14] = 15;
        //    //eklenecekData[15] = 16;
        //    //eklenecekData[16] = 17;

        //    sayilarim.AddRange(eklenecekData);

        //    // capacity ve count kavramları

        //    int capacity = sayilarim.Capacity;
        //    int count = sayilarim.Count;

        //    sayilarim.TrimExcess();

        //    capacity = sayilarim.Capacity;
        //    count = sayilarim.Count;


        //    // soru sayilarım koleksiyonu içerisinde bulunan datayı ekrana yazdırmak istiyorum

        //    foreach (var item in sayilarim)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    // 2. yol list generic içindeki ForEach() metotu

        //    sayilarim.ForEach(i => Console.WriteLine(i));



        //}

        #endregion



    }
}
