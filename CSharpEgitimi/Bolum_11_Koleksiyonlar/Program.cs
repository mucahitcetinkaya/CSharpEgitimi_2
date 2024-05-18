namespace Bolum_11_Koleksiyonlar
{
    internal class Program
    {

        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 96 Bilgilendirme

        //static void Main(string[] args)
        //{

        //}

        #endregion

        #region VİDEO 97 ArrayList Nedir ?

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 11 Koleksiyonlar VİDEO 97 ArrayList Nedir ?

        //    */

        //    /*

        //    ArrayList Genel Kullanım
        //    Genel kullanım
        //    normalde dizi olustururken

        //    string[] isimler = new string[10];

        //    10 elemanlı string bir diziyi böyle olusturuyorduk
        //    ArrayList te bu biraz farklı

        //    ArrayList yazdıgımızda kırmızı yanıyor hata veriyor sebebi yukarıya kütüphane eklememiş olmamız
        //    yukarıdaki tanımlar .net kutuphaneleri
        //    using e basınca yukarıya ekleme yaptı
        //    yukarıda yazan kutuphane kullanılıyorsa eger aktif olarak gözüküyor
        //    kullanılmıyorsa gri olarak yazar orda dursa da silinse de sorun olmaz


        //    using System.Collections;

        //    .net içinde olan bir sınıf bu ArrayList
        //    system collections içinden kullan demıs olduk

        //    ArrayList a1 = new ArrayList();

        //    class lar dersın de görecegız ama kısa olarak anlatmak gerekirse
        //    yeni bir class tanımlandıgın da onu new lemek zorundasın kullanmak için
        //    artık a1 uzerınden işlem yapabiliriz

        //    a1. dedigimiz de kullanabileceğimiz yardımcılar geliyor
        //    mesela
        //    a1.Add sadece 1 deger eklememıze yarar
        //    object veri tipinden deger aldıgı için bu degerler herhangi bir deger olabilir
        //    int string double decimal boolean vs gibi
        //    yada ileride gorecegımız bizim kendı olusturacagımız tipler de olabilir
        //    sadece string yazıyosan eger "" içinde yazarsan onun string anlar

        //    ---------------------------------------------------------------------------------------------

        //    Tek Değer eklemek için                                  Add

        //    string[] isimler = new string[10];

        //    ArrayList a1 = new ArrayList();
        //    a1.Add("Mücahit Çetinkaya");
        //    a1.Add(100);

        //    ---------------------------------------------------------------------------------------------

        //    Birden fazla deger eklemek için                         AddRange

        //    yeni bir ArrayList olusturalım deger girelim
        //    ArrayList a2 = new ArrayList();
        //    a2.Add("Arden");
        //    a2.Add("Arthur");

        //    a1 koleksiyonuna birden fazla deger eklemek istiyoruz burda
        //    bunun için a2 yi kaynak olarak gösteriyoruz ve AddRange i kullanıyoruz

        //    a1.AddRange(a2);

        //    a1 koleksiyonu içerisine a2 koleksiyonundaki degerleri aldı

        //    debug anlatım
        //    string ten baslayarak breakpoint ile debug yaptıgımızda
        //    10 elemanlı bir dizi olusturdu kullanmadık sadece olusturduk


        //    a1 arraylist olusturdu veri girmedik daha count 0 olarak yazıyor
        //    0. ve 1. index e elemanları girdi
        //    a1 in 0 ve 1. index leri dolu suanda
        //    2 farklı deger tutuyor birisi metin birisi sayısal


        //    a2 arraylist olusturdu 0 ve 1. ixdex e elemanlarını girdi
        //    a1.AddRange(a2); yi okudugunda a1 e a2 deki verileride kayıt etti
        //    a1 de 2. ve 3. index de dolmus oldu kaldıgı yerden devam ettı

        //    a1 i a2 den beslemiş olduk

        //    s2 nin içindeki degerler kayıp olmadı duruyor

        //    ---------------------------------------------------------------------------------------------

        //    gördüğünüz gibi dizilerden biraz daha kolay
        //    içerideki komutlara göre işlemler yapabiliyoruz
        //    daha farklı ne gibi işlemler yapabiliriz örneklere devam edelim


        //    karısmaması için yeni bir main metodu olusturmak istiyorum

        //    2. main metodundan devam


        //    ---------------------------------------------------------------------------------------------

        //    */


        //    string[] isimler = new string[10];

        // /* tek veri eklemne */

        //    ArrayList a1 = new ArrayList();
        //    a1.Add("Mücahit Çetinkaya");
        //    a1.Add(100);


        // /* Birden fazla veri eklemne başka kaynağı kullanarak başka bir kaynağa */

        //    ArrayList a2 = new ArrayList();
        //    a2.Add("Arden");
        //    a2.Add("Arthur");


        //    a1.AddRange(a2);

        //}

        #endregion

        #region VİDEO 97 Capacity Count

        //static void Main(string[] args)
        //{

        //    /*

        //    2. main metot devam

        //    Capacity ve Count kavramlarına bakalım

        //    önce degiskenlerını olusturduk
        //    int Capacity = 0;
        //    int Count = 0;

        //    sonra bunları kullanarak A1 ve A2 in içindeki capacity ve count larına atama yaptık

        //    Capacity = A1.Capacity;
        //    Count = A1.Count;

        //    şimdi burda anlatmak istediğimiz konu
        //    ArrayList olusturdugumuz zaman new leme yaptıgımız da sadece ArrayList olusuyor demıstık

        //    daha sonra veri ekleme yaptıgımız da bos olan arraylist arka tarafta bazı degerler ile belleğe çıkıyor
        //    belleğe cıktıgı bu degerler
        //    capacity ve count kavramı

        //    biz bunu dizilerde eleman sayısı olarak görmustuk arraylist te bu biraz daha farklı

        //    ArrayList A1 den breakpoint ile debug yapalım

        //    en basta A1 null olarak duruyor cunku daha new leme yapmadık
        //    new leme yapıp içine girince bazı bilgiler yazıyor
        //    Capacity ve Count gibi ikiside 0 sıfır suanda

        //    Capacity Koleksiyonun alabileceği maksimum değeri ifade eder
        //    Conut Koleksiyon içerisindeki mevcut deger sayısını ifade eder

        //    for ile capacity ile dönersek farklı sonuc count kadar dönersen farklı sonuc alırsın

        //    şimdi bu degerler 0 deger ekledıgınde

        //    Capacity i 4 Count u 1 yapacak
        //    bunun sebebi
        //    ArrayList ilk elemanı aldıgında kendısını 4 elemanlı bir dizi gibi düşünüyor
        //    4 elemanı geçince Capacity sini 8 yapıyor 2 nin üstü olarak böyle gidiyor
        //    yani
        //    Capacity 8 se eğer Count 5 veya 8 olabilir demek bu

        //    bir deger daha ekleyelim
        //    Capacity 4 Count 2 oldu

        //    A2 nin verilerini A1 e ekleyip Capacity sini cogaltalım 4 den fazla olursa ne oluyor

        //    Capacity 8 oldu Count 5 oldu


        //    başka bir main metodu acıp oradan devam edeceğim

        //    3. main metot devam

        //    */

        //    int Capacity = 0;
        //    int Count = 0;


        //    /* tek veri eklemne */

        //    ArrayList A1 = new ArrayList();
        //    A1.Add("Mücahit Çetinkaya");

        //    /*

        //    4 4 mü artıyor 2 nin üstü olarak mı onu kontrol etmek için burayı yaptım
        //    4 8 16 olarak gidiyor 2 nin üstü olarak

        //    A1.Add("Arden");
        //    A1.Add("Arthur");
        //    A1.Add("Zayn");
        //    A1.Add("Arden");
        //    A1.Add("Arthur");
        //    A1.Add("Zayn");
        //    A1.Add("Arden");
        //    A1.Add("Arthur");
        //    A1.Add("Zayn");
        //    */

        //    Capacity = A1.Capacity;
        //    Count = A1.Count;

        //    A1.Add(100);

        //    /* Birden fazla veri eklemne başka kaynağı kullanarak başka bir kaynağa */

        //    ArrayList A2 = new ArrayList();
        //    A2.Add("Arden");
        //    A2.Add("Arthur");
        //    A2.Add("Zayn");

        //    A2.Add("Arden");
        //    A2.Add("Arthur");
        //    A2.Add("Zayn");

        //    A1.AddRange(A2);

        //    Capacity = A1.Capacity;
        //    Count = A1.Count;

        //}

        #endregion

        #region VİDEO 97 Veri Ekleme ve İçindeki Değere Ulaşma

        //static void Main(string[] args)
        //{

        //    /*

        //    3. main metodu

        //    biz ArrayList içindeki bir elemana nasıl ulasırız güncelleriz değiştirebiliriz

        //    A1[ yaptıgımızda indexer acmaya calıstıgımızda
        //    object ArrayList[int Index] yardımcı penceresi cıkıyor
        //    dizilerde olan fonksiyonite buraya da yansımıs durumda
        //    dizileride anlamak bundan dolayı onemliydi

        //    dizilerdeki indexer arraylist e
        //    arraylist deki capacity count kavramı genericlist lere dogru evriliyor

        //    istediğim arraylist e bir index acıp istediğim index numarasını obje tipinde ulasım sagyalabilirim

        //    object O1 = A1[3];

        //    koleksiyon içinde objeler deger saklamakta bundan dolayı

        //    a1 in içinde 3. index de olan deger Arden string bir deger
        //    direk object olarak degilde string olarak almak istersek

        //    string S1 = A1[3].ToString();

        //    olarak dönüştürme yapabiliriz

        //    int almak istersek eger A1 içindeki 1. index int

        //    int I1 = (int)A1[1];

        //    değiştirmek için

        //    A1[3] = "3. index değeri değişti 3. main metod";


        //    debug anlatımı
        //                object O1 = A1[3];
        //    kısmına breakpoint koy

        //    ilk olustugunda null olarak olusuyor

        //    A1 içinde 5 tane veri var
        //    3. index deki degere ulasacagız Arthur

        //    object üstüne alıp string e basıyoruz degeri

        //    direk Arthur u cekti ordan

        //    a1 i de int üstüne aldık aynı işlem
        //    object tipinden int tipine dönusturduk

        //    en sonda da A1 in 3. index inin verisini degistirdik üstüne yazdırdık direk

        //    yeni main 4 deger silme

        //    */


        //    /* Koleksiyon içerisine veri ekleme */

        //    ArrayList A1 = new ArrayList();
        //    A1.Add("Mücahit Çetinkaya");
        //    A1.Add(100);
        //    A1.Add("Arden");
        //    A1.Add("Arthur");
        //    A1.Add("Zayn");



        //    /* Koleksiyon içindeki değere ulaşmak */

        //    object O1 = A1[3];

        //    string S1 = A1[3].ToString();

        //    int I1 = (int)A1[1];

        //    /* Koleksiyon içindeki değeri değiştirmek için */

        //    A1[3] = "3. index değeri değişti 3. main metod";

        //}

        #endregion

        #region VİDEO 97 Dizilerde Değer Silme

        //static void Main(string[] args)
        //{

        //    /*

        //    97 notları devam main 4 deger silme

        //    Remove() metodunu kullanacagız
        //    parantez içinde koleksiyondan sileceğin degeri istiyor obje tipinde

        //                A1.Remove("3. index değeri değişti 3. main metod");

        //    bunu bul liste içinden kaldır diyebiliyoruz

        //    calıstırdıgımızda 3. index deki deger komple kalktı diger deger 3. index e geldi bir üste kaydı hepsi

        //    kaldırmanın farklı yolları da var mesela

        //    RemoveRange baslangıc ve bitiş index i veriyosun ona göre kaldırma işlemi yapıyor

        //                A1.RemoveRange(2,2);
        //    2. index den basladı kendı dahil sildi

        //    RemoveAt metodu direk index veriyosun index e göre siliyor

        //    A1.RemoveAt(1);

        //    peki remove metodu varken removeat e ne gerek var
        //    index e göre silmek ne kadar dogru
        //    biz degeri bilip silme işlemi yapabiliyoruz
        //    koleksiyon içerisinde cok fazla veri olabilir
        //    çalışma zamanında degerin ne geldiğini bilmediğin durumlar olabilir
        //    sabit bir şekilde verilerin yoksa
        //    hangi deger hangi index de onu da bilememe ihtimalin var
        //    once degerin index i ni bulup sonra da index e göre koleksiyondan data yı cıkartmamız lazım

        //    genelde veriler database den cekilir hangi index hangi degere geliyor bilemeyiz
        //    bundan dolayı bu işlem kullanılır.

        //    main 5 den devam

        //    */

        //    ArrayList A1 = new ArrayList();
        //    A1.Add("Mücahit Çetinkaya");
        //    A1.Add(100);
        //    A1.Add("Arden");
        //    A1.Add("Arthur");
        //    A1.Add("Zayn");

        //    /* Koleksiyon içindeki değeri değiştirmek için */

        //    A1[3] = "3. index değeri değişti 3. main metod";

        //    /* Koleksiyon içindeki değeri silmek için */

        //    A1.Remove("3. index değeri değişti 3. main metod");
        //    A1.RemoveRange(2,2);
        //    A1.RemoveAt(1);

        //}

        #endregion

        #region VİDEO 97 Arraylist Sıralama

        //static void Main(string[] args)
        //{

        //    /*

        //    97 notları devam main 5 Arraylist Sıralama

        //    Arraylist Sıralama

        //    A dan Z ye sıralama

        //    A1.Sort();

        //    Dizinin mevcut sıralamasını terse döndürme

        //    A1.Reverse();

        //    sort yaparken dizi içinde baska bir tip varsa eger hata alırsın bizim dizimizde
        //    a1 dizinin hepsi int
        //    a2 dizisinin hepsi string
        //    hepsi aynı tip bundan dolayı sort yapabiliyor
        //    ama arasına baska bir tip koyarsak hata alırız
        //    1 ile a yı nasıl sıralasın ondan dolayı

        //    reverse yaparken baska bir tip olsa da hata vermiyor sebebi direk cevirme yapıyor ne olduguna bakmıyor

        //    main 6 dan devam


        //    */


        //    ArrayList A1 = new ArrayList();
        //    ArrayList A2 = new ArrayList();

        //    A1.Add(1);
        //    A1.Add(2);
        //    A1.Add(3);
        //    A1.Add(4);
        //    A1.Add(5);

        //    A2.Add("a");
        //    A2.Add("b");
        //    A2.Add("c");
        //    A2.Add("d");
        //    A2.Add("e");

        //    A1.Sort();
        //    A2.Sort();

        //    A1.Reverse();
        //    A2.Reverse();


        //    /*

        //    10 elemanlı string ArrayList içindeki değerleri Z-A olacak şekilde sıralayın

        //     */

        //    ArrayList siralama = new ArrayList();
        //    siralama.Add("Ezel");
        //    siralama.Add("Ramiz");
        //    siralama.Add("Eyşan");
        //    siralama.Add("Kenan");
        //    siralama.Add("Ali");
        //    siralama.Add("Cengiz");
        //    siralama.Add("Bayraktar");
        //    siralama.Add("Karaeski");
        //    siralama.Add("Tefo");
        //    siralama.Add("Sekiz");

        //    siralama.Sort();
        //    siralama.Reverse();


        //}

        #endregion

        #region VİDEO 97 ArrayList Yardımcı Komutlar

        //static void Main(string[] args)
        //{

        //    /*

        //    97 notları devam main 6 Yardımcı Komutlar

        //    .Contains() metodu dizi içinde parantez içine yazdıgımız veri var mı diye bakıyor bool dönüş yapıyor
        //    mesela

        //    bool kontrol1 = A1.Contains(1);
        //    bool kontrol2 = A1.Contains("Mücahit");
        //    bool kontrol3 = A1.Contains(100);
        //    bool kontrol4 = A1.Contains("Merve");

        //    kodlarının sonucları true veya false olarak gelir

        //    Diger Komut

        //    IndexOf

        //    index ini bilmedigimiz verilerin index ini bulmaya yarıyor

        //    int indexDeger = A1.IndexOf("Mücahit");

        //    a1 içindeki Mücahit degerinin index ini indexDeger içine ata demiş olduk
        //    mesela burdan index degerinin 6 oldugunu ögrendık bunu sarta da baglayabiliriz

        //    if (A1.Contains(1))
        //    {
        //        int indexDeger2 = A1.IndexOf(1);
        //        A1.RemoveAt(indexDeger2);
        //    }

        //    a1 in içinde 1 varsa git a in içindeki 1 degerinin index ini bul sonra da onu sil


        //   7. main e gecelim


        //    */

        //    ArrayList A1 = new ArrayList();

        //    A1.Add(1);
        //    A1.Add(2);
        //    A1.Add(3);
        //    A1.Add(4);
        //    A1.Add(5);
        //    A1.Add("Muhammet");
        //    A1.Add("Mücahit");
        //    A1.Add("Çetinkaya");
        //    A1.Add("Zayn");
        //    A1.Add("Arthur");
        //    A1.Add("Arden");

        //    bool kontrol1 = A1.Contains(1);
        //    bool kontrol2 = A1.Contains("Mücahit");
        //    bool kontrol3 = A1.Contains(100);
        //    bool kontrol4 = A1.Contains("Merve");

        //    int indexDeger = A1.IndexOf("Mücahit");

        //    if (A1.Contains(1))
        //    {
        //        int indexDeger2 = A1.IndexOf(1);
        //        A1.RemoveAt(indexDeger2);
        //    }


        //}

        #endregion

        #region VİDEO 97 ArrayList Yardımcı Komutlar

        //static void Main(string[] args)
        //{

        //    /*

        //    97 notları devam main 7 Yardımcı Komutlar

        //    Claer

        //    A1.Clear();
        //    dediğimiz de dizinin içinde ne varsa hepsini siler

        //    silmesine siliyor count u sıfır yapıyor ama capacity i değiştirmiyor sıfırlama yapmıyor

        //    Capacity yeniden ayarlamak boyutlandırmak için de

        //    A1.TrimToSize(); ı kullanabiliriz yeniden 4 e cekti

        //    */

        //    ArrayList A1 = new ArrayList();

        //    A1.Add(1);
        //    A1.Add(2);
        //    A1.Add(3);
        //    A1.Add(4);
        //    A1.Add(5);
        //    A1.Add("Muhammet");
        //    A1.Add("Mücahit");
        //    A1.Add("Çetinkaya");
        //    A1.Add("Zayn");
        //    A1.Add("Arthur");
        //    A1.Add("Arden");

        //    A1.Clear();
        //    A1.TrimToSize();


        //}

        #endregion

        #region VİDEO 97 ArrayList Yardımcı Komutlar

        //static void Main(string[] args)
        //{

        //    /*

        //    97 notları devam main 8 Yardımcı Komutlar

        //    ToArray

        //    ArrayList içindeki tüm data ları dizi olarak verir

        //    */

        //    ArrayList A1 = new ArrayList();

        //    A1.Add(1);
        //    A1.Add(2);
        //    A1.Add(3);
        //    A1.Add(4);
        //    A1.Add(5);
        //    A1.Add("Muhammet");
        //    A1.Add("Mücahit");
        //    A1.Add("Çetinkaya");
        //    A1.Add("Zayn");
        //    A1.Add("Arthur");
        //    A1.Add("Arden");

        //    object[] D1 = A1.ToArray();

        //}

        #endregion

        #region VİDEO 98 ArrayList Ödev

        //static void Main(string[] args)
        //{

        //    /*

        //     Bölüm 11 Koleksiyonlar VİDEO 98 ArrayList Ödev

        //    */

        //    /*

        //    Ödev açıklaması
        //    Konsolda bir menü tasarımı yapılacak
        //    Menü
        //    1 - Değer Ekle
        //    2 - Değer Listele
        //    3 - Değer Ara
        //    4 - Değer Düzenle
        //    5 - Değer Sil
        //    6 - Uygulama Çıkış
        //    Seçiniz :

        //    Yeni bir arraylist olusturulacak
        //    kullanıcıdan gelen degere göre switch case kontrol edilecek
        //    uygulama durmadan dönecek ekle sil ara vs gibi
        //    sadece 6 ya basılırsa uygulamadan cıkacak
        //    1 dedi mesela deger eklenecek tekrar dönecek
        //    2 dedi listeleme yapacak gibi

        //    ip ucu olarak burda sonsuz döngü olmayacak do while kullanacagız once seçimi yapıp sonra secimin sonucuna göre işlem yapılacak

        //    programın beklemesını saglayacak 2 saniye
        //                System.Threading.Thread.Sleep(2000);


        //    */


        //    ArrayList degerListesi = new ArrayList();
        //    degerListesi.Add(1);
        //    degerListesi.Add(2);
        //    degerListesi.Add(3);
        //    degerListesi.Add(4);
        //    degerListesi.Add(5);
        //    degerListesi.Add("Muhammet");
        //    degerListesi.Add("Mücahit");
        //    degerListesi.Add("Çetinkaya");
        //    degerListesi.Add("Arden");
        //    degerListesi.Add("Zayn");
        //    degerListesi.Add("Arthur");


        //    degerListesi[3] = "10";

        //    string kullaniciGiris = string.Empty;

        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Menü");
        //        Console.WriteLine("1 - Değer Ekle");
        //        Console.WriteLine("2 - Değer Listele");
        //        Console.WriteLine("3 - Değer Ara");
        //        Console.WriteLine("4 - Değer Düzenle");
        //        Console.WriteLine("5 - Değer Sil");
        //        Console.WriteLine("6 - Uygulama Çıkış");
        //        Console.Write("Seçiniz : ");

        //        kullaniciGiris = Console.ReadLine();


        //        switch (kullaniciGiris)
        //        {
        //            case "1":
        //                Console.Write("Eklemek istediğiniz değeri giriniz : ");
        //                string kullaniciEklenenDeger = Console.ReadLine();
        //                degerListesi.Add(kullaniciEklenenDeger);
        //                Console.Write("Değeriniz başarılı bir şekilde eklendi : ");
        //                System.Threading.Thread.Sleep(2000);
        //                break;
        //            case "2":
        //                for (int i = 0; i < degerListesi.Count; i++)
        //                {
        //                    Console.WriteLine("{0}. Değer = {1}", i, degerListesi[i]);
        //                }
        //                Console.WriteLine("Devam etmek için bir tuşa basınız.");
        //                Console.ReadLine();
        //                break;
        //            case "3":
        //                Console.Write("Aramak istediğiniz değeri giriniz : ");
        //                string kullaniciArananDeger = Console.ReadLine();
        //                bool arananSonuc = degerListesi.Contains(kullaniciArananDeger);
        //                if (arananSonuc)
        //                {
        //                    int bulunanIndex = degerListesi.IndexOf(kullaniciArananDeger);
        //                    string bulunanDeger = degerListesi[bulunanIndex].ToString();
        //                    Console.Write($"Aranan veri {kullaniciArananDeger} koleksiyon içinde bulunuyor.");
        //                    Console.WriteLine($"Değeriniz bulundu index sırası {bulunanIndex} bulunan değer {bulunanDeger}");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Aradığınız kriterlerde bir değer bulunamadı.");
        //                    /*
        //                     Eğer aradığı kriterlerde değer bulunamadıysa kullanıcıya bu değeri listeye ekleyelim mi olarak sorun
        //                     eğer kullanıcı evet derse ekleyin hayır derse devam edin.                            
        //                     */
        //                }
        //                System.Threading.Thread.Sleep(2000);
        //                break;
        //            case "4":
        //                Console.WriteLine("Güncellemek istediğiniz değeri giriniz : ");
        //                string kullaniciDuzenlenecekDeger = Console.ReadLine();

        //                Console.WriteLine("{0} Değerini hangi değer ile güncellemek istiyorsunuz : ", kullaniciDuzenlenecekDeger);
        //                string kullaniciYeniDeger = Console.ReadLine();
        //                if (degerListesi.Contains(kullaniciDuzenlenecekDeger))
        //                {
        //                    int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDuzenlenecekDeger);
        //                    degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
        //                    Console.WriteLine("Değeriniz güncellendi.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Aradığınız değer liste içerisinde bulunamadı.");
        //                }
        //                System.Threading.Thread.Sleep(2000);

        //                break;
        //            case "5":
        //                Console.WriteLine("Tüm değerleri mi silmek istiyorsunuz : (E/N)");
        //                string kullaniciSilCevap = Console.ReadLine();

        //                if (kullaniciSilCevap.ToLower() == "E")
        //                {
        //                    degerListesi.Clear();
        //                    Console.WriteLine("Tüm değerler silindi.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Liste içerisinde silmek istediğiniz değeri giriniz : ");
        //                    string kullaniciSilDeger = Console.ReadLine();
        //                    if (degerListesi.Contains(kullaniciSilDeger))
        //                    {
        //                        degerListesi.Remove(kullaniciSilDeger);
        //                        Console.WriteLine("Değeriniz silindi.");
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Silmek istediğiniz değer liste içerisinde mevcut değil.");
        //                    }
        //                }
        //                break;
        //            case "6":
        //                break;
        //            default:
        //                break;
        //        }
        //    } while (kullaniciGiris != "6");

        //}

        #endregion

        #region VİDEO 99 HashTable Nedir

        //static void Main(string[] args)
        //{
        //    /*

        //    Bölüm 11 Koleksiyonlar VİDEO 99 Hashtable Nedir 


        //    */

        //    /*

        //    Hashtable notları 

        //    Hashtable System.Collection kutuphanesinde bulunmakta 
        //    kırmızı olursa eger yukarıya ekleme yapman lazım ctrl+. a basarsan da gelir

        //    ht lar class lardan beslendıgı için new lemen lazım

        //    Hashtable H1 = new Hashtable();

        //    ht lar kendını key ve value ile beslerler

        //    H1.Add( yaptıgında cıkan yardımcı ekranda görebilirsin key ve value istediğini
        //    key degerleri ht lar içinde benzersiz olmak zorunda
        //    value degerleri için bu konu geçerli degil

        //    key degerleri liste içinde dataya ulasmak için kullanacagımız anahtar kelimelerdir.

        //    zaten ht ların amacı bir anahtar kelimeyi bir data ya baglayabilmektir.

        //    Car ile Arabayı House ile Ev i tutuyor
        //    H1.Add("Car","Araba");
        //    H1.Add("House","Ev");


        //    Key farklı ama Value aynı olsada sorun olmuyor
        //    H1.Add("Cars", "Araba");

        //    Burda uygulama bize hata veriyor key degeri uniq olmalı kuralına takılıyoruz
        //    H1.Add("Cars", "Arabalar");



        //    */

        //    Hashtable H1 = new Hashtable();
        //    H1.Add("Car","Araba");
        //    H1.Add("House","Ev");

        //    H1.Add("Cars", "Araba");

        //    /*H1.Add("Cars", "Arabalar");*/


        //    /* 

        //    Yardımcı Metotları 

        //    Contains
        //    bizden key degeri ister varsa true yoksa false döner

        //    ContainsKey yine key degerine bakıyor
        //    ContainsValue value degerine bakar

        //    Count ilgili koleksiyonda kac deger var görebiliriz for içinde de kullanılabilir

        //    Romove key alır siler

        //    CopyTo kopyalar

        //    Clear geriye bişey dönmez void metotdur hepsini temizler
        //    */

        //    bool kontrol1 = H1.Contains("House");
        //    bool kontrol2 = H1.Contains("Door");
        //    bool kontrol3 = H1.ContainsKey("House");
        //    bool kontrol4 = H1.ContainsValue("Araba");

        //    int koleksiyonIcindekiToplamDeger = H1.Count;

        //    /*

        //    Koleksiyon içindeki bir veriyi güncellemek için 

        //    h1 bizden key degeri istiyor index olarak alıyor
        //    yazdıgın verinin value sunu guncelliyor
        //    H1["House"] = "Villa";

        //    */

        //    H1["House"] = "Villa";

        //}

        #endregion

        #region VİDEO 100 HashTable Ödev

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 11 Koleksiyonlar VİDEO 100 Hashtable Ödev

        //    Hashtable içerisine ENG - TR olarak data ekleyen uygulamayı yapacağız
        //    ENG tarafını key TR tarafını value olarak saklayacagız

        //    Yeni Kayıt eklemek istiyor musunuz (E/H) diye soracak
        //    büyük küçük harf olmayacak hepsi büyük
        //    E cevabı gelirse yeni kayıt eklemeye devam edecek
        //    H cevabı gelirse tüm liseyi yazdıracak

        //    var olan bir key değeri ekliyor ise kullanıcıya bu değer daha önceden .... şeklinde sistemimizde bulunmaktadır
        //    yazması lazım

        //    */

        //    Hashtable sozlukVeriTabani = new Hashtable();

        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Eklemek istediğiniz sözlük değerini yazınız : ");
        //        Console.WriteLine("EN karşılığı : ");
        //        string eng = Console.ReadLine();

        //        bool kontrol = sozlukVeriTabani.ContainsKey(eng);
        //        if (kontrol)
        //        {
        //            Console.WriteLine($"Eklemek istediğiniz değer {eng} sözlük içerisinde bulunmaktadır. {sozlukVeriTabani[eng].ToString()} değerin türkçe karşılığıdır.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{eng} ingilizce değerinin türkçe karşılığını yazınız.");
        //            string tr = Console.ReadLine();
        //            sozlukVeriTabani.Add(eng, tr);
        //            Console.WriteLine("Değer ekleme işlemi başarılı.");
        //        }

        //        Console.WriteLine("Yeni değer eklemek istiyor musunuz ? (E/H) ");



        //    } while (Console.ReadLine().ToUpper() != "H");

        //    /*

        //    2 yöntem ile bunun içinde dönebiliriz
        //    1. yöntem key veririz keylerine döneriz keylerini bize koleksiyon olarak veriyor



        //    foreach (var item in sozlukVeriTabani.Keys)
        //    {
        //        Console.WriteLine("ENG : {0} = TR : {1}", item , sozlukVeriTabani[item]);
        //    }

        //     */

        //    /*

        //    2. yöntem

        //    direk sozlukVeriTabani içinde doneriz ama
        //    var yerine direk tipini yazmak veya foreach içinde tip dönüşümü yapmamız lazım
        //    DictionaryEntry kullandık burda sebebi datanın karsılıgını almak

        //    DictionaryEntry nerden geliyor onu anlatıyoruz burda
        //    bir verinin tipinin ne döndüğünü bilmiyorsanız eğer

        //    foreach (var item in sozlukVeriTabani)
        //    {
        //        Console.WriteLine(item.GetType().Name);
        //    }

        //    olarak tipini bulabilirsiniz

        //    bazı veriler kapalı geliyor bizde bunların tipini bulmak zorunda kalıyoruz
        //    var yazıyorken item gettype i kullanıyoruz




        //    foreach (var item in sozlukVeriTabani)
        //    {
        //        Console.WriteLine(item.GetType().Name);
        //    }

        //    */

        //    foreach (DictionaryEntry item in sozlukVeriTabani)
        //    {
        //        Console.WriteLine("ENG : {0} = TR : {1}", item.Key, item.Value);
        //    }

        //}

        #endregion




    }
}