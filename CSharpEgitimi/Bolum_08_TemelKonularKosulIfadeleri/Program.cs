namespace Bolum_08_TemelKonularKosulIfadeleri
{
    internal class Program
    {

        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 65 Bilgilendirme

        //static void Main(string[] args)
        //{

        //}

        #endregion

        #region VİDEO 66 Karar Yapıları Nedir ?

        //static void Main(string[] args)
        //{

        //}

        #endregion

        #region VİDEO 67 Karar Yapıları - IF Kullanımı

        //static void Main(string[] args)
        //{

        /* VİDEO 67 Karar Yapıları - IF Kullanımı */


        //Console.WriteLine("Sayı 1 değerinizi giriniz : ");
        //string sStr1 = Console.ReadLine();

        //Console.WriteLine("Sayı 2 değerini giriniz : ");
        //string sStr2 = Console.ReadLine();

        //decimal sayi1 = Convert.ToDecimal(sStr1);
        //decimal sayi2 = Convert.ToDecimal(sStr2);
        //decimal toplam = sayi1 + sayi2;


        //bool toplamKontrol = toplam > 50; /* geçen bölüm if lere gelmeden buraya kadar yapabiliyorduk */

        //if (toplamKontrol) /* burası uzun kullanım gerek yok */
        //{
        //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyüktür.");
        //}

        /*
        toplamKontrol kısmını bool üzerine alıp öyle yazdık üst kısımda böyle yapmamıza gerek yok
        bool olarak bir degisken tanımlamak zorunda degılız
        */

        //if (toplam > 50) /* bool a gerek yok parantez içinde oldugundan if true yada false veriyor zaten */
        //{
        //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyüktür.");
        //    /*
        //    konsoldan girilen değer 50 den büyükse süslü parantez işlemine geçiyor
        //    konsoldan girilen değer 50 den küçükse if içindeki süslü parantez işlemlerini çalıştırmaz atlar
        //    altında bişey yoksa programı bitirir
        //    */
        //}

        //Console.ReadLine();

        //}

        #endregion

        #region VİDEO 68 Karar Yapıları - IF ve ELSE Kullanımı

        //static void Main(string[] args)
        //{

        //    /* Video 68 Karar Yapıları - IF ve ELSE Kullanımı */

        //    Console.WriteLine("Sayı 1 değerinizi giriniz : ");
        //    string sStr1 = Console.ReadLine();

        //    Console.WriteLine("Sayı 2 değerini giriniz : ");
        //    string sStr2 = Console.ReadLine();

        //    decimal sayi1 = Convert.ToDecimal(sStr1);
        //    decimal sayi2 = Convert.ToDecimal(sStr2);
        //    decimal toplam = sayi1 + sayi2;


        //    /*
        //    IF KISMINI İNCELEDİK
        //    IF ŞARTININ OLUMSUZ OLMASI DURUMUNDA ÇALIŞMASINI İSTEDİĞİMİZ EK İŞLEMLER VARSA
        //    BUNLARI NASIL BELİRLEYEBİLİRİZ BİRLİKTE BUNLARI İNCELEYELİM
        //    */

        //        /* IF TEN SONRA GELİYOR IF TE YAZILANLAR EGER DOGRU DEĞİLSE ELSE KULLANILIYOR */
        //    /*
        //    else
        //    {
        //         şart veya şartlar dogru değilse o zaman calısacak kodlar 
        //    }
        //    */

        //    if (toplam > 50)
        //    {
        //        /*
        //        mesela burada konsoldan girilen değer toplamı 100 se yani şart dogru ise
        //        true gelir toplamın sonucu breakpoint koyarak kontrol edebilirsin
        //        if gelir toplama bakar büyüktür yazdırır cıkar
        //        else hiç bakmaz
        //        altındaki kodları calısmaya geçer
        //        */
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyüktür.");

        //    }
        //    else
        //    {

        //        /*
        //        toplam 50 den büyük değilse o zaman else bakar
        //        kucuktür yazdırır
        //        altında herhangi bir kod varsa onları calıstırmaya geçer
        //        */
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den küçüktür.");

        //    }

        //    Console.ReadLine();
        //}

        #endregion

        #region VİDEO 69 Karar Yapıları - IF ve ELSE IF Kullanımı

        //static void Main(string[] args)
        //{

        //    /* Video 69 Karar Yapıları - IF ve ELSE IF Kullanımı */


        //    Console.WriteLine("Sayı 1 değerinizi giriniz : ");
        //    string sStr1 = Console.ReadLine();

        //    Console.WriteLine("Sayı 2 değerini giriniz : ");
        //    string sStr2 = Console.ReadLine();

        //    decimal sayi1 = Convert.ToDecimal(sStr1);
        //    decimal sayi2 = Convert.ToDecimal(sStr2);
        //    decimal toplam = sayi1 + sayi2;


        //    /*
        //     ONCEKİLERDE
        //     GİRİLEN DEĞERLERİN TOPLAMI 50 DEN BÜYÜKSE
        //     EKRANA BUYUK YAZ
        //     BUYUK DEĞİLSE KUCUK YAZ DEMİŞTİK

        //     PEKİ BİZİM İSTEĞİMİZ ŞÖYLE OLSA
        //     GİRİLEN DEĞERLERİN TOPLAMI
        //     100 DEN BUYUKSE 100 DEN BUYUK YAZALIM
        //     50 DEN BUYUKSE 50 DEN BUYUK YAZALIM
        //     50 DEN KUCUKSE 50 DEN KUCUK YAZALIM
        //     BURADA 3 ŞART VAR
        //     100 DEN BUYUKSE İF
        //     50 DEN BUYUKSE ELSE İF
        //     50 DEN KUCUKSE ELSE
        //     IF EGER BU DOGRUYSA DEĞİL Mİ ELSE IF YA BU DEMEMİZİ SAĞLIYOR
        //     IF ILE ELSE ARASINA ISTEDIGIMIZ KADAR ELSE IF İLE ARA KOD YAZABİLİRİZ
        //     EL SON ELSE İLE KODU BİTİRİRİZ
        //     ALTINA YAZILACAK BASKA KODLAR VARSA DEVAM EDEBİLİR
        //    */

        //    if (toplam >= 100)
        //    {
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 100'den büyük veya eşittir.");
        //        /*
        //        1.girilen değerler 50 den küçük olsun
        //        burada değer false gelirse
        //        bir altına iner 2.şartı test eder
        //        2.girilen değerler 100 den küçük 50 den büyük olsun
        //        burayı false okur bir aşağıya iner
        //        3.değer 100 den büyük olsun
        //        burası true gelir konsola yazdırır
        //        else if veya else ugramaz
        //        if blogunun dısından devam eder
        //        */
        //    }

        //    else if (toplam >= 50)
        //    {
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyük veya eşittir.");
        //        /*
        //        1.girilen değer 50 den küçük
        //        if false verdi buraya geldi burasıda false verdi
        //        başka else if varsa ona bakar yoksa uygulama else bakar
        //        2.girilen değerler 100 den küçük 50 den büyük olsun
        //        50 den büyük konsola yazdırır else gitmez
        //        if blogunun dısından devam eder
        //        */
        //    }

        //    else
        //    {
        //        Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den küçüktür.");
        //        /*
        //        1.girilen değer 50 den küçük
        //        buraya gelir konsola yazdırır
        //        if blogunun dısından devam eder
        //        */

        //    }

        //    /*
        //    NOT: if te 1.sayı 50 2.sayı 100 olsa algoritma yanlıs olur 50 den büyükse zaten 100 den büyük olur
        //    hiç diğer kısımlara bakmaz
        //    1.kodda dogru olanı aldım bitti gibi bakıyor
        //    if blogunun dısından devam eder
        //    uygulamayı yazarken kodsal hata aldıgımızda bir şekilde çözülür
        //    stackoverflow da yardım bulabiliriz.
        //    mantıksal hata yaparsak eğer o zaman mecbur kodu okuyup çözmen gerekiyor
        //    */

        //    Console.ReadLine();
        //}

        #endregion

        #region VİDEO 70 Karar Yapıları - Switch Case Kullanımı

        //static void Main(string[] args)
        //{
        //    /* 70 Karar yapıları -Switch kullanımı */

        //    /* 

        //     YAZIMI 

        //    switch ( ifade )
        //    {
        //        case kontrol1;  buradaki case leri if else gibi düşünebilirsin 
        //            çalışacak olan işlemler 
        //            break; ;  ile cıkış yapılır 

        //             altına baska case lerde koyabilirsin 

        //        case kontrol2;  buradaki case leri if else gibi düşünebilirsin 
        //             çalışacak olan işlemler 
        //            break; ;  ile cıkış yapılır 

        //            bütün kontrollerden geçtik ama herhangi birine takılmadık
        //         else kısmı burada

        //        default:
        //             calısacak olan işlemler 
        //            break;  ile cıkıs yapılır 
        //    }
        //    */

        //    /*
        //    kullanıcı ne girebilir ocak subat mart vs veya bunların dısında yanlıs bir cevap
        //    bunları switchcase ile kontrol edelim
        //    */
        //    Console.WriteLine("Hangi Ay : ");
        //    string kullanicidanGelen = Console.ReadLine();

        //    switch (kullanicidanGelen)
        //    {
        //        case "Ocak": /* alttaki notu oku */
        //        case "Nisan":
        //            Console.WriteLine("01");
        //            break; /* ile kodu kapattık */
        //        case "Şubat":
        //            Console.WriteLine("02");
        //            break;
        //        case "Mart":
        //            Console.WriteLine("03");
        //            break;
        //        /* bunlardan hiç biri değilse default kısmı else kısmı oluyor bunu yaz dedik */
        //        default:
        //            Console.WriteLine("Belirtirilen değerlerin dışında bir değer girişi yaptınız.");
        //            break; /* ile yine kodu kapattık */

        //    }

        //    /*
        //     switchcase de girilen bütün değerleri kayıt ediyor tek tek bakmıyor
        //     mesela if te böyle birşey yaparsak
        //     if ocak mı şubat mı mart mı diye tek tek hepsini okur
        //     switchcase de ocak şubat mart vs hepsini kayıt ediyor
        //     kullanıcı ocak yazdı diyelim
        //     diğerlerine bakmaz switch blogunun dısından devam eder
        //     kullanıcı subat yazdı diyelim ocaga bakmaz şubatta bakar blogun dısından devam eder
        //     yani kodu arama yapıyor varsa eğer ordan devam ediyor
        //     yoksa eğer default a gidiyor istenilen şeyi yapıyor
        //     blogun dısına cıkıyor

        //     peki ocak veya subatsa mart veya nisansa bu calıssın nasıl denir
        //     yani case imiz birden fazla olabilir mi aynı işlemi calıstırabilir mi evet yapabilir

        //     case in altına baska bir case yazabiliriz
        //     burada ocak veya nisan mi diyor veya var
        //    */

        //}
        #endregion

        #region VİDEO 71 Karar Yapıları - Alıştırma 1

        //static void Main(string[] args)
        //{

        //    /*
        //    kullanıcı adını ve şifreyi degiskene atayıp if içinde degisken adı ile işlem yapabilirsin
        //    veya
        //    degisken yerine direk orda da yazabilirsin ama degiskene ataman degistirmen için kolaylık saglar
        //    */

        //    string ka = "admin";
        //    string sifre = "123";

        //    Console.WriteLine("Kullanıcı adınızı giriniz : ");
        //    string girilenKullaniciAdi = Console.ReadLine();

        //    Console.WriteLine("Kullanıcı adınızı giriniz : ");
        //    string girilenSifre = Console.ReadLine();

        //    if (girilenKullaniciAdi == ka && girilenSifre == sifre)
        //    {
        //        Console.WriteLine("Hoşgeldiniz");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı giriş!!");
        //    }

        //    /*
        //     * 2 side calısır sadece degisken var veya yok farkları bu 
        //    if (girilenKullaniciAdi == "admin" && girilenSifre == "123")
        //    {
        //        Console.WriteLine("Hoşgeldiniz");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı giriş!!");
        //    }
        //    */

        //    Console.ReadLine();
        //}

        #endregion

        #region VİDEO 72 Karar Yapıları - Ödev 1

        //static void Main(string[] args)
        //{

        //    /*

        //    VİDEO 72 Karar Yapıları - Ödev 1

        //    sistem içerisine giriş yapılabilecek kullanıcı kodları
        //    ABC - 123 - 236 - CMK
        //    kullanıcı girişiniz başarılı

        //    sistem içerisine yasaklanmıs kullanıcı kodları
        //    HHH - BBB - MMM
        //    kullanıcı girişiniz kilitlenmiştir.

        //    bunların dısında ise

        //    hatalı kullanıcı kodu

        //    */

        //    Console.WriteLine("Kullanıcı adınızı giriniz : ");
        //    string kullaniciKodu = Console.ReadLine();
        //    kullaniciKodu = kullaniciKodu.ToUpper(); /* hepsi büyük harf */

        //    /*
        //    if (kullaniciKodu == "ABC")
        //    {
        //        Console.WriteLine("Kullanıcı girişiniz başarılı.");
        //    }
        //    else if (kullaniciKodu == "123")
        //    {
        //        Console.WriteLine("Kullanıcı girişiniz başarılı.");
        //    }
        //    else if (kullaniciKodu == "236")
        //    {
        //        Console.WriteLine("Kullanıcı girişiniz başarılı.");
        //    }
        //    else if (kullaniciKodu == "CMK")
        //    {
        //        Console.WriteLine("Kullanıcı girişiniz başarılı.");
        //    }
        //    else if (kullaniciKodu == "HHH")
        //    {
        //        Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir.");
        //    }
        //    else if (kullaniciKodu == "BBB")
        //    {
        //        Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir.");
        //    }
        //    else if (kullaniciKodu == "MMM")
        //    {
        //        Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı kullanıcı kodu !!!!! ");
        //    }

        //    Console.ReadLine();

        //    Console.Clear();
        //    */

        //    /*
        //    2.yol
        //     VEYA OPERATÖRÜNDE 1 TANESİ DOGRUYSA BLOGUN DISINDAN DEVAM EDER
        //    */


        //    if (kullaniciKodu == "ABC" || kullaniciKodu == "123" || kullaniciKodu == "CMK")
        //    {
        //        Console.WriteLine("Kullanıcı girişiniz başarılı.");
        //    }
        //    else if (kullaniciKodu == "HHH" || kullaniciKodu == "BBB" || kullaniciKodu == "MMM")
        //    {
        //        Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hatalı kullanıcı kodu !!!!!! ");
        //    }

        //    Console.ReadLine();


        //    /*
        //    NOT
        //    kontrol etmek için breakpoint koyup sıra sıra bakabilirsin
        //    mesela if in basına gri yere tıkla calıstır tek tek kontrol et true veya false dönüyor buna bakabilirsin
        //    BUYUK KUCUK DUYARLILIGI VARDIR BUNU DA ENGELLEME YAPABİLİRİZ
        //    HARFLERİN HEPSİ BUYUK YADA KUCUK YAZABİLİRİZ.
        //    BUNUN İÇİN İF TEN ONCE STRİNG İN ALTINA
        //    kullaniciKodu = kullaniciKodu.ToUpper();
        //    yazarsak içine gelen değeri büyük yapar
        //    kullaniciKodu = kullaniciKodu.ToLower();
        //    yazarsak içine gelen değerin küçük yapar
        //    */

        //}

        #endregion

        #region VİDEO 73 Karar Yapıları - Alıştırma 2

        //static void Main(string[] args)
        //{
        //    /* 

        //     VİDEO 73 Karar Yapıları - Alıştırma 2

        //     MENU
        //     1 - TOPLAMA
        //     2 - CIKARTMA
        //     3 - ÇARPMA
        //     4 - BÖLME
        //     SEÇİNİZ : _

        //     KURALLAR 
        //     1 2 3 4 DIŞINDA BİR DEĞER GİRERSE GİRMİŞ OLDUĞUNUZ DEĞER HATALI DİYELİM VE SONLANDIRALIM
        //     BURDA HENUZ YÖNLENDİRMELERİ GÖRMEDİĞİMİZ TEKRAR AYNI MENUYU KULLANICININ KARSISINA CIKARTMAYACAGIZ
        //     4. SECENEK İÇERİSİNDE 0 BÖLENİ OLAMAZ KONTROLÜ YAPILACAK
        //     UYGULAMA 1 KERE CALISACAK
        //     HER İŞLEMDE KULLANICIDAN 2 SAYI İSTENECEK HANGİSİ SECİLİRSE BUNLAR ONA GÖRE İŞLEME GİRECEK

        //    */

        //    #region Birinci Çözüm

        //    ///* birinci çözüm de if içinde işlemleri yaptık */

        //    //Console.WriteLine(" Hoşgeldiniz");
        //    //Console.WriteLine(" 1 - Toplama");
        //    //Console.WriteLine(" 2 - Çıkartma");
        //    //Console.WriteLine(" 3 - Çarpma");
        //    //Console.WriteLine(" 4 - Bölme");
        //    //Console.Write(" Seçiniz : ");

        //    //string secilenMenu = Console.ReadLine();

        //    //if (secilenMenu == "1")
        //    //{
        //    //    Console.WriteLine("Toplanmasını istediğiniz 2 sayı giriniz : ");
        //    //    Console.Write("1. sayı : ");
        //    //    decimal toplaSayi1 = Convert.ToDecimal(Console.ReadLine());
        //    //    Console.Write("2. sayı : ");
        //    //    decimal toplaSayi2 = Convert.ToDecimal(Console.ReadLine());
        //    //    Console.WriteLine("Toplama Sonucu " + (toplaSayi1 + toplaSayi2));

        //    //}
        //    //else if (secilenMenu == "2")
        //    //{
        //    //    Console.WriteLine("Çıkartılmasını istediğiniz 2 sayı giriniz : ");
        //    //    Console.Write("1. sayı : ");
        //    //    decimal cikartSayi1 = Convert.ToDecimal(Console.ReadLine());
        //    //    Console.Write("2. sayı : ");
        //    //    decimal cikartSayi2 = Convert.ToDecimal(Console.ReadLine());
        //    //    Console.WriteLine("Çıkartma Sonucu " + (cikartSayi1 - cikartSayi2));

        //    //}
        //    //else if (secilenMenu == "3")
        //    //{
        //    //    Console.WriteLine("Çarpılmasını istediğiniz 2 sayı giriniz : ");
        //    //    Console.Write("1. sayı : ");
        //    //    decimal carpSayi1 = Convert.ToDecimal(Console.ReadLine());
        //    //    Console.Write("2. sayı : ");
        //    //    decimal carpSayi2 = Convert.ToDecimal(Console.ReadLine());
        //    //    Console.WriteLine("Çarpma Sonucu " + (carpSayi1 * carpSayi2));

        //    //}
        //    //else if (secilenMenu == "4")
        //    //{
        //    //    Console.WriteLine("Bölünmesini istediğiniz 2 sayı giriniz : ");
        //    //    Console.Write("Bölünecek Sayı : ");
        //    //    decimal bolSayi1 = Convert.ToDecimal(Console.ReadLine());
        //    //    Console.Write("Bölen Sayı : ");
        //    //    decimal bolSayi2 = Convert.ToDecimal(Console.ReadLine());
        //    //    if (bolSayi2 == 0)
        //    //    {
        //    //        Console.WriteLine("Bölen sayı sıfır olamaz!");
        //    //        Console.WriteLine("Uygulama Sonu");
        //    //    }
        //    //    else
        //    //    {
        //    //        Console.WriteLine("Bölme Sonucu " + (bolSayi1 / bolSayi2));
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Menude olmayan bir seçenek girdiniz! ");
        //    //}

        //    //Console.ReadLine();

        //    #endregion

        //    #region İkinci Çözüm Hocanın Çözümü

        //    ///* 
        //    //ikinci çözüm de aslında bütün seceneklerde kullanıcıdan 2 tane deger istiyoruz
        //    //o zaman bunu bütün if içinde tekrar ktekrar yazmak yerine dısarıda degisken içine atalım
        //    //if içinde sadece hesap kısımlarını yapalım
        //    //*/

        //    //Console.WriteLine(" Menü");
        //    //Console.WriteLine(" 1 - Toplama");
        //    //Console.WriteLine(" 2 - Çıkartma");
        //    //Console.WriteLine(" 3 - Çarpma");
        //    //Console.WriteLine(" 4 - Bölme");
        //    //Console.Write(" Seçiniz : ");

        //    //string kullaniciSecim = Console.ReadLine();

        //    ///* buranın ayrı notu var notlarda yazdım */
        //    //double sayi1 = 0;
        //    //double sayi2 = 0;

        //    ///* burda kullanıcıdan aldıgımız degeri once string tipinde degiskene atayıp sonradan tür donusumu yapıyoruz */

        //    //if (kullaniciSecim == "1" || kullaniciSecim == "2" || kullaniciSecim == "3" || kullaniciSecim == "4")
        //    //{
        //    //    Console.Write("Birinci Sayıyı Giriniz : ");
        //    //    string s1 = Console.ReadLine();
        //    //    Console.Write("İkinci Sayıyı Giriniz : ");
        //    //    string s2 = Console.ReadLine();

        //    //    sayi1 = Convert.ToDouble(s1);
        //    //    sayi2 = Convert.ToDouble(s2);
        //    //}

        //    ///*
        //    //buradaki örnek ile birinci çözümdeki örnek aynı
        //    //Console.ReadLine geriye string tipinde deger dönüyor üstüne gelince görürsün zaten
        //    //kullanıcıdan deger isteyip direk hangi tipte degiskene atayacaksak ona cevirme yapıyoruz
        //    //ayrı ayrı yazmaktan kurtulmus oluyoruz
        //    //Console.Write("Birinci Sayıyı Giriniz : ");
        //    //decimal dSayi1 = Convert.ToDecimal(Console.ReadLine());
        //    //Console.Write("İkinci Sayıyı Giriniz : ");
        //    //decimal dSayi2 = Convert.ToDecimal(Console.ReadLine());
        //    //*/

        //    //if (kullaniciSecim == "1")
        //    //{
        //    //    double toplamaSonuc = sayi1 + sayi2;
        //    //    Console.Write("Toplama Sonucu : " + toplamaSonuc);

        //    //}
        //    //else if (kullaniciSecim == "2")
        //    //{
        //    //    double cikartmaSonuc = sayi1 - sayi2;
        //    //    Console.Write("Çıkartma Sonucu : " + cikartmaSonuc);

        //    //}
        //    //else if (kullaniciSecim == "3")
        //    //{
        //    //    double carpmaSonuc = sayi1 * sayi2;
        //    //    Console.Write("Çarpma Sonucu : " + carpmaSonuc);

        //    //}
        //    //else if (kullaniciSecim == "4")
        //    //{
        //    //    if (sayi2 == 0)
        //    //    {
        //    //        Console.WriteLine("Bölen sayı sıfır olamaz!");
        //    //        Console.WriteLine("Uygulama Sonu");
        //    //    }
        //    //    else
        //    //    {
        //    //        double bolmeSonuc = sayi1 / sayi2;
        //    //        Console.Write("Bölme Sonucu : " + bolmeSonuc);
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Menude olmayan bir seçenek girdiniz! ");
        //    //}

        //    //Console.ReadLine();

        //    #endregion

        //}

        #endregion

        #region VİDEO 74 Karar Yapıları - Ödev 2

        //static void Main(string[] args)
        //{

        //    /*

        //    VİDEO 73 Karar Yapıları - Ödev 2

        //    Not ortalama sistemine hoş geldiniz.
        //    İsim ve Soyisim : Mücahit Çetinkaya
        //    Not 1 : 50
        //    Not 2 : 40
        //    Not 3 : 60

        //    Ortalama 45 değerinden küçük ise : KALDINIZ.
        //    Ortalama 45 değerine eşit veya 70 değerinden küçük ise : Orta ile geçtiniz.
        //    Ortalama 70 değerine eşit veya 90 değerinden küçük ise : İyi ile geçtiniz.
        //    Ortalama 90 ile 100 arasında ise (100 dahil) : Başarılı tebrikler.
        //    Ortalama değeri 100 den büyük ise : Notlarınızı kontrol ediniz. 

        //    */

        //    Console.WriteLine("Not ortalama sistemine hoşgeldiniz...");

        //    Console.Write("Öğrenci ismini giriniz : ");
        //    string isim = Console.ReadLine();
        //    Console.Write("Öğrenci Soyismini giriniz : ");
        //    string soyIsim = Console.ReadLine();

        //    Console.Write("Birinci notu giriniz : ");
        //    decimal not1 = Convert.ToDecimal(Console.ReadLine());
        //    Console.Write("İkinci notu giriniz : ");
        //    decimal not2 = Convert.ToDecimal(Console.ReadLine());
        //    Console.Write("Üçüncü notu giriniz : ");
        //    decimal not3 = Convert.ToDecimal(Console.ReadLine());

        //    decimal toplam = (not1 + not2 + not3);
        //    decimal ortalama = toplam / 3;

        //    /*
        //     * kısa yol 
        //    decimal ortalama = (not1 + not2 + not3) / 3;
        //    */

        //    Console.WriteLine($"1. not {not1} 2. not {not2} 3. not {not3} not toplamı {toplam} ortalama {ortalama} ");

        //    if (ortalama < 45)
        //    {
        //        Console.WriteLine("Kaldınız.");
        //    }
        //    else if (ortalama >= 45 && ortalama < 70)
        //    {
        //        Console.WriteLine("Orta ile geçtiniz.");
        //    }
        //    else if (ortalama >= 70 && ortalama < 90)
        //    {
        //        Console.WriteLine("İyi ile geçtiniz.");
        //    }
        //    else if (ortalama >= 90 && ortalama <= 100)
        //    {
        //        Console.WriteLine("Başarılı.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Notlarınızı kontrol ediniz ortalamanız 100 den büyük.");
        //    }

        //    Console.WriteLine("Uygulama Sonu");
        //    Console.ReadLine();

        //}

        #endregion

        #region VİDEO 75 Karar Yapıları - Alıştırma 3 (Ödev gibi yapmaya çalışabilirsiniz)

        //static void Main(string[] args)
        //{

        //    /*

        //    VİDEO 75 Karar Yapıları - Alıştırma 3 (Ödev gibi yapmaya çalışabilirsiniz)

        //    switchcase çalısması

        //    SWİTCH KISA YOLU SW TAB TAB

        //    kullanıcı kodu : 

        //    kullanıcı kodu = AA - BB -- CC
        //    ADMİN YETKİSİNE SAHİPSİNİZ
        //    kullanıcı kodu = DD
        //    GÜÇLÜ KULLANICI YETKİSİNE SAHİPSİNİZ
        //    kullanıcı kodu = FF - EE - GG 
        //    STANDART KULLANICI YETKİSİNE SAHİPSİNİZ

        //    farklı bir giriş olursa : HATALI KULLANICI KODU

        //    */

        //    Console.Write("Lütfen kullanıcı kodunuzu giriniz : ");

        //    string kullaniciKodu = Console.ReadLine();

        //    switch (kullaniciKodu)
        //    {
        //        case "AA": /* AYNI KODU YAZINCA HATA VERDİ */
        //        case "BB":
        //        case "CC":
        //            Console.WriteLine("ADMİN YETKİSİNE SAHİPSİNİZ.");
        //            break;
        //        case "DD":
        //            Console.WriteLine("GÜÇLÜ KULLANICI YETKİSİNE SAHİPSİNİZ.");
        //            break;
        //        case "FF":
        //        case "EE":
        //        case "GG":
        //            Console.WriteLine("STANDART KULLANICI YETKİSİNE SAHİPSİNİZ.");
        //            break;
        //        default:
        //            Console.WriteLine("HATALI KULLANICI KODU.");
        //            break;
        //    }

        //    Console.ReadLine();

        //}

        #endregion

    }
}