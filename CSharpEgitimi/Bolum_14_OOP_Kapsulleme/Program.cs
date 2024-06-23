using System;

namespace Bolum_14_OOP_Kapsulleme
{
    internal class Program
    {

        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 127 Bilgilendirme

        //static void Main(string[] args)
        //{

        //}

        #endregion

        #region VİDEO 128 Verileri Kapsülleme - 1

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 14 OOP Kapsülleme VİDEO 128 Verileri Kapsülleme - 1

        //    */

        //    /*

        //    1. not baslangıc
        //    yeni proje actık set a startup dedik not actık vs
        //    yeni bir class acalım

        //    Musteri128.cs adında bir class olusturduk

        //    Musteri128 class ına gidelim ordan devam edelim

        //    1. not bitiş
        //    2. not bitiş

        //    3. not baslangıc

        //    Musteri128 M1 = new Musteri128();
        //    M1.id = 1;
        //    M1.isim = "Mücahit";
        //    M1.soyIsim = "Çetinkaya";

        //    Musteri128 i new leyelim
        //    Musteri128 M1 = new Musteri128();
        //    M1. dediğimiz de class içinde yazdıklarımız burda gözükür
        //    id isim soyIsim
        //    yardımcı alanda yanlarında field olarak adlandırıldıgını görürsün
        //    field bir kavramdır bu class ın alanıdır.

        //    alanları dolduralım

        //    biz burda bir class tanımlayıp class içindeki alanlara degerler atamıs olduk

        //    kapsulleme bu işin neresınde veya ne zaman ihtiyac duyarız

        //    Kapsulleme Nedir ? 

        //    Musteri128 in içindeki alanları özelleştirebilmek için 
        //    aslında biz kapsullemeyi kullanırız
        //    mesela ben sunu istiyorum
        //    id alanını class ı cagıran hiç kimse 
        //    içerisine deger atayamasın sadece deger okuyabilsin
        //    veya
        //    içerisine deger atayabilsin ama deger okuyamasın
        //    veya
        //    deger ataması yapılsın ama degerin ilk 4 hanesi okunsun
        //    burda callcenter örnegi vermiştik
        //    veya
        //    field deger ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin.
        //    bu ne demek 
        //    benim müsteri class ın içine tanımlamıs oldugum field ıma 
        //    bir deger ataması yaptıgım da o deger ilgili field e geldiğinde 
        //    benim arkada calısmasını istediğim belli baslı işlemlerim var 
        //    veri dogru mu veri bende var mı 
        //    eger bunlar saglanıyorsa class ın içindeki field bu degeri kabul etsin
        //    ama saglanmıyorsa class ın içerisine ben bu field i deger olarak alamayayım
        //    yada tam tersi de söz konusu olabilir

        //    ben database e gittim veriyi aldım 
        //    ama almıs oldugum veri bir referans degeri içeriyor
        //    mesela 1578 diyor
        //    yani baska bir tablonun id sini gösteriyor
        //    benim 1578 degerini kullanıcıya göstermem bir sey ifade etmeyecek
        //    benim 1578 in karsılıgını bulup ona göstermem gerek
        //    işte bu noktada data yı database den çekip 
        //    kullanıcıya gösterirken belli metotlardan geçmesini istediğimiz de de 
        //    kapsullemeyi kullanabiliriz


        //    yani özet olarak class ın içerisindeki alanın deger alma ve deger okuma
        //    alanlarına mudahale ettıgımız noktalara biz kapsulleme diyoruz

        //    kapsulleme dedıgımız noktada karsımıza bir kac kavram daha cıkıyor
        //    bizim bildiklerimiz 
        //    class
        //    field
        //    şimdi buna ek olarak
        //    class ın içerisinde property dedıgımız özellikleri tanımlayacagız 
        //    ve tanımlamıs oldugumuz prop ların içinde de 
        //    get ve set bloklarını inceleyeceğiz

        //    Musteri128 e gidelim

        //    3. not bitiş
        //    4. not bitiş

        //    5. not baslangıc

        //    M1.eMailAdres = "mucahit@hotmail.com";

        //    yazdıgım email adrese deger ataması yaptık 
        //    ilk olarak 
        //    field deger ataması yapılamasın ama deger okunabilsin

        //    Musteri128 e gidelim

        //    5. not bitiş 
        //    6. not bitiş

        //    7. not baslangıc

        //    M1.eMailAdres = "mucahit@hotmail.com";
        //    class ın içerisinde belirtmiş oldugum alan private 
        //    dış dunyaya kapalı dış dunya neresi o class ın dısındaki her yer
        //    private yaptıgım için hata veriyor

        //    peki ben buraya deger ataması yapamıyorum 
        //    deger ataması yapabilecegim bir mekanızma gerekiyor

        //    Musteri128 e gidelim

        //    7. not bitiş
        //    8. not bitiş

        //    9. not baslangıc

        //    field olarak
        //    M1.eMailAdres = "mucahit@hotmail.com";
        //    property olarak
        //    M1.EMailAdres = "mucahit@hotmail.com";

        //    herhangi bir hata almıyoruz

        //    M1.eMailAdres gözükmüyor cunku private olarak işaretledik
        //    M1.EMailAdres var tooltype yanında cıkan kutuya bakarsan 
        //    orda get set bloklarını string dönus tipini görürsün
        //    ikonu da farklı ingiliz anahtarı
        //    field olanlar kutu ikonuna sahip

        //    Musteri128 e bir breakpoint koyalım debug edelim
        //    M1 null gecmedık henuz F10 ile devam edelim
        //    M1 i geçince nesne olustu
        //    içinde 
        //    EMailAdres prop olan
        //    eMailAdres field olan 
        //    id field
        //    isim field
        //    soyIsim field
        //    var
        //    field olan eMailAdres private ama burda gözüküyor cunku ram uzerınden bakıyoruz buna
        //    yanında bir kilit işareti var bunun sebebi private olması
        //    devam ettirip kodu bitirelim hepsini atayalım degerlerin
        //    id isim soyisim field olanlar emailadres prob olan hepsi deger aldı

        //    emailadres field olan deger almadı
        //    ben prob olarak bunu tanımladım get set dedim ama içine herhangi bir özelleştirme yapmadım atama yapmadım bunu bilerek yapmadım

        //    birazdan value denilen farklı bir kavramdan bahsedeceğim
        //    bunu anlamak için bunu böyle yaptım

        //    deger benim property me geldi ama arka tarafta sistem
        //    o degeri saklayacak farklı bir field bulamadıgı için
        //    .net in compylite i gitti arka tarafta benim su anda göremediğim bir field actı
        //    ve onu onun içine attı
        //    benim burda degeri yönlendirmem gerekiyor
        //    yönlendirme tarafında ben burda set işlemi yaptım
        //    data set ettim sistem herhangi bir set edilecek bir yer bulamadıgı için
        //    arka tarafta kendi bir field olusturdu
        //    ve o field a set etti 
        //    şimdi gelin bana gelen data yı bir görelim
        //    ve görmüş oldugumuz data yı içeride private olarak sakladıgımız 
        //    field ın uzerıne atayalım

        //    Musteri128 e gidelim

        //    9. not bitiş

        //    10. not bitiş

        //    11. not başlangıç

        //    M1.EMailAdres = "mucahit@hotmail.com";
        //    e breakpoint koyalım

        //    daha önce içeride herhangi bir get set blogu yazmadıgımız için
        //    kendisi arkada bizim görmediğimiz bir field olusturdu
        //    olusturdugu field a bu degeri atadı
        //    ben bunu istemiyorum
        //    benim içeride private olarak saklamıs oldugum degere atamasını istiyorum

        //    f11 ile devam edelim
        //    uyarı cıkıyor normal
        //    set bloguna geliyoruz

        //    Musteri128 e gönderecek

        //    11. not bitiş
        //    12. not bitiş

        //    13. not baslangıc

        //    Musteri128 den f10 ile geldik degeri atadı
        //    M1 in içinde 
        //    EMailAdres ve eMailAdres ikinde de mail adresımız oldu
        //    birisi property birisi field
        //    degeri cekersekte bu seferde get bölümü calısacak

        //    deger cekmek mesela ekrana yazdırmakta olabilir

        //    13. not 

        //    Console.WriteLine(M1.EMailAdres);

        //    yazıp calıstırınca get bloguna gidecek

        //    13. not bitiş

        //    15. not baslangıc

        //    ekrana yazdırdı

        //    M1.EMailAdres dedigimiz de datayı getir diyoruz
        //    datayı tasıyan field property degil

        //    encapsulation budur arkadaslar
        //    class ın içerisindeki field a
        //    giden datanın gitme ve o dataya ulasma bölümlerini
        //    detaylandırdıgımız kısma encapsulation kapsulleme diyoruz
        //    büyük projelerde kullanılır


        //    */


        //    Musteri128 M1 = new Musteri128();
        //    M1.id = 1;
        //    M1.isim = "Mücahit";
        //    M1.soyIsim = "Çetinkaya";


        //    M1.EMailAdres = "mucahit@hotmail.com";

        //    Console.WriteLine(M1.EMailAdres);

        //}

        #endregion

        #region VİDEO 129 Verileri Kapsülleme - 2 

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 14 OOP Kapsulleme V129 Verileri Kapsülleme - 2

        //    */

        //    /*

        //    1. not baslangıc

        //    field lara baktık
        //    property olusturup get set bloklarına baktık
        //    value a baktık
        //    private field a aktarmaya baktık

        //    yeni bir musteri class ı acalım ordan devam edelim

        //    Fielda deger ataması yapılamasın ama deger okunabilsin
        //    bu işlemi yapacagız

        //    Musteri129 a gecelim

        //    1. not bitiş

        //    2. not bitiş

        //    3. not baslangıc

        //    Musteri129 u newleyerek alanlarını dolduralım degerlerını atayalım

        //    id diger derste publicti sorun yoktu su anda private olarak yazdık
        //    hemen hata verdi burda onu tanımıyor görmüyor çünkü

        //    tekrar class a gidelim ve bir prop yazalım public olarak

        //    3. not bitiş

        //    4. not bitiş

        //    5. not baslangıc

        //    Console.WriteLine("Musteri id degeri : " + M1.idProp.ToString());

        //    ToString metotu int decimal boolean vs string in dısında kalan herhangi bir tipi string e cevirebiliyoruz

        //    ToString e virtual metotlarda derinlemesine gireceğiz
        //    sanal metot kullanımda anlatacagız
        //    kendısı bize object nesnesinden geliyor

        //    Musteri129 M1 = new Musteri129();
        //    e breakpoint koyalım debug yapalım

        //    ilk amacımız sistemi incelemek sonra da set kısmını kaldıracagız

        //    Musteri129 un üzerinde orneklenmesı olmadı null yazıyor
        //    f11 e basınca orneklerken class ın icerisine girecek
        //    yapıcı metot a gidecek

        //    Musteri129 a gidelim F11 ile

        //    5. not bitiş

        //    6. not bitiş

        //    7. not baslangıc

        //    bu işlemler daha nesne orneklendıgınde oldu
        //    gecinde ornekleme kısmını private olarak saklanan field da diger prob da 
        //    atanan id degerını aldıgını göruyoruz

        //    console kısmına geldık ekrana yazdıracagız

        //    Musteri129 un içinde get set kısmına bir breakpoint koyalım
        //    f11 ile devam edince tekrar get kısmına dusecek kod

        //    7. not bitiş
        //    8. not bitiş

        //    9. not baslangıc

        //    get kısmından buraya dustu kod
        //    kod u yazdırdı ekrana

        //    M1.IdProp = 10 ; dedigimiz de set kısmına duser kod deger ataması da yapabiliriz

        //    buraya breakpoint koyalım
        //    yukarıdaki seklemelerden Debug kısmından 
        //    Delete All BreakPoints dersenız bütün breakpointleri kaldırır

        //    Musteri129 un içinde get set kısmına breakpoint koyalım

        //    calıstırınca kodu get kısmına dustu kod 
        //    f10 ile devam edince ekrana yazdıralım
        //    normalde prop ve field alanları aynı ama biz prop kısmına deger ataması yaptık
        //    burdan f11 ile devam edince set kısmına dusecek kod
        //    set ile deger degıstırmesı yapmıs olduk
        //    ama ben bunun olmamasını istiyorum
        //    bu mekanızma calısmasın

        //    Musteri129 a gidelim

        //    9. not bitiş
        //    10. not bitiş

        //    11. not baslangıc

        //    set kısmını private yaptık hata veriyor
        //    hatada set kısmına ulasılamaz diyor
        //    private set yazıyor

        //    istediğimiz sartı saglamıs olduk

        //    deger ataması yapamıyor okuma yapabiliyoruz


        //    */

        //    Musteri129 M1 = new Musteri129();
        //    //M1.id = 1;
        //    //M1.isim = "Mücahit";
        //    //M1.soyIsim = "Çetinkaya";

        //    Console.WriteLine("Musteri id degeri : " + M1.idProp.ToString());
        //    //M1.idProp = 10;

        //}

        #endregion

        #region VİDEO 130 Verileri Kapsülleme - 3 Ara Ödev

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 14 OOP Kapsulleme V130 Verileri Kapsülleme - 3 Ara Ödev

        //    */

        //    /*

        //    Kapsülleme - Ara Ödev GET SET

        //    Musteri sınıfının içerisine _tcKimliknumarasi adında bir private
        //    field tanımı yapalım ve
        //    aşağıdaki kurallara göre kapsülleme işlemlerini gerçekleştirelim.

        //    Set

        //    Girilen değer 11 hane olmalıdır.
        //    Girilen değer içerisindeki tüm değerler sayısal değer olmak zorundadır.

        //    Get

        //    Öncelikle değer okunamaz şekilde ayarlansın
        //    İlk 3 hanesini gösterelim.




        //    kodu yanlıs anlayıp böyle bir uygulama yaptım


        //    bu uygulamada kullanıcı 11 adet sayı girecek
        //    her sayıyı dizi olarak eklemek istiyorum
        //    sonra içlerinde dönüp bakacagım her biri int mi yani harf
        //    veya simge var mı diye yada 10 tane mi 12 tane mi girildi diye
        //    sorun varsa olan sorunu yazacak sorun yoksa ekrana ilk 3 hanesini yazdıracak

        //    const int expectedCount = 11;
        //    int[] numbers = new int[expectedCount];
        //    bool validInput = true;

        //    Console.WriteLine($"Lütfen {expectedCount} adet sayı giriniz:");

        //    for (int i = 0; i < expectedCount; i++)
        //    {
        //        Console.Write($"Sayı {i + 1}: ");
        //        string input = Console.ReadLine();

        //        if (!int.TryParse(input, out numbers[i]))
        //        {
        //            Console.WriteLine("Hata: Geçersiz bir sayı girdiniz.");
        //            validInput = false;
        //            break;
        //        }
        //    }

        //    if (validInput)
        //    {
        //        Console.WriteLine("Girdiğiniz sayıların ilk 3 hanesi:");
        //        for (int i = 0; i < Math.Min(3, numbers.Length); i++)
        //        {
        //            Console.WriteLine(numbers[i]);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Lütfen sadece geçerli tam sayılar girin.");
        //    }


        //    chatgpt nin yaptıgı

        //    static void Main(string[] args)
        //    {

        //        try
        //        {
        //            Musteri130 M1 = new Musteri130();

        //            M1.TcKimlikNumarasi = "12345678901";

        //            Console.WriteLine("Müşterinin TC Kimlik Numarası: " + M1.TcKimlikNumarasi);

        //        }
        //        catch (ArgumentException ex)
        //        {

        //            Console.WriteLine(ex.Message);
        //        }
        //    }


        //    */

        //    Musteri130 M1 = new Musteri130();
        //    M1.TcKimlikNumarasi = "12345678910";






        //}

        #endregion

        #region VİDEO 131 Verileri Kapsülleme - 4

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 14 OOP Kapsulleme V131 Verileri Kapsülleme - 4

        //    */

        //    /*
            
        //    1. not baslangıc
            
            
        //    field deger ataması ve okumasını
        //    metotlar yarmıdıyla yapmayı deneyecegız

        //    Musteri içerisinde olan isim ve soyisim field lerıne deger atadıgımızda 
        //    ilgili isim ve soyisime ait bir email adresini olusturup
        //    sistemde atayıp bunu 
        //    cagıran kişiye geri gönderecegız
        //    burda get ve set bloklarında işlemlerimiz devam edecek
        //    sadece degeri alıp göstermeyecegız bir cok işlem yapacagız
            
        //    içeride private olan saklanan bir field ın
        //    public olarak ayarlanan property vaastasıyla
        //    get ve set bloklarını kullanarak modifiye edildiğini görebildiniz.

            
        //    Kapsülleme Nedir ? 

        //    içeride saklamıs oldugumuz private bir field in 
        //    önüne koymus oldugumuz bir property sayesinde 
        //    get ve set bloklarını kullanarak
        //    deger ataması yapabiliriz
        //    deger de cekebiliriz

        //    su anda tamammen ögrenmemıs olabilirsiniz ama tekrar yapmak gerekiyor

        //    mesela 1 tane sporcu düşünün kickbox ögrenmek isteyen birisi
        //    yumruk atmasını ögrenirken defalarca aynı kum torbasına yumruk atar
        //    defalarca aynı hareketi yapar 
        //    sebeb refreskleri alıssın yumrugu atarken
        //    nası dönecek nası vuracak hangi pozisyonda duracak
        //    karsı taraftan gelecek darbeye karsı nası kapanacak
        //    bunu ögrenmek için yuzlerce kere o kum torbasına defalarca vurur

        //    zeki olmak tek basına iş yapmaz calıskan da olmak gerekir
        //    calıskan olursanız zekileri de gecersiniz

        //    şimdi son maddemize gecelim

        //    Field deger ataması ve okuma işlemleri yapılsın ama 
        //    bu iki işlemde bizim belirlediğimiz bir süreçten geçsin
        //    veri daha sonra gösterilsin

        //    ben ne yapacagım

        //    isim ve soyisim verilerini atama yapacagım
        //    arka tarafta email adresi olusturacak
        //    sonra emailadresini get ettiğimde 
        //    mucahitcetinkaya@outlook.com
        //    gibi bir deger döndürecek

        //    set ettiğimde hiç bir sey yapamayacagım
        //    set im private olacak

        //    ben set işlemini 
        //    isim ve soyisim atarken 
        //    soy isim kısmının set blogunda yapacagım

        //    burda önce isim sonra soy isim olacak gibi degiskenlere girmiyorum
        //    amacımız konuyu ögrenmek su anda 

        //    kişi önce isim ve soyisim girecek

        //    soyismin setinde email adresi olusturacak
        //    emailadresi property sinden get ettiğimde 
        //    emailadresıne ulasabilecegım
        //    seti private bıracakacım
        //    emailadresine set edemeyecegım

        //    Musteri131 e gidelim

        //    1. not bitiş
        //    2. not bitiş

        //    3. not başlangıç

        //    Musteri131 den geldik new leme yapalım

        //    calıstırınca konsolda 
        //    mucahitcetinkaya@outlook.com yazdıgını görürsün

        //    3. not bitiş

             
        //    */


        //    Musteri131 M1 = new Musteri131();

        //    M1.isim = "mucahit";
        //    M1.SoyIsım = "cetinkaya";
        //    Console.WriteLine(M1.EMailAdres);


        //}

        #endregion


    }
}