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





    }
}