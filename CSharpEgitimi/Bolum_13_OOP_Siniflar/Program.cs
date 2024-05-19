namespace Bolum_13_OOP_Siniflar
{
    internal class Program
    {

        //#region VİDEO 

        //static void Main(string[] args)
        //{

        //}

        //#endregion

        #region VİDEO 121 Bilgilendirme

        //static void Main(string[] args)
        //{

        //}

        #endregion

        #region VİDEO 122 Sınıf Tanımlama ve inceleme - 1

        //static void Main(string[] args)
        //{

        //    /*

        //    Bölüm 13 OOP Sınıflar VİDEO 122 Sınıf Tanımlama ve inceleme - 1

        //    */

        //    /*

        //    biz ne demiştik ilk derslere baslamadan once


        //    namespace Bolum_13_OOP_Siniflar
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
        //    Musteri122 class ını olusturduk 122. video dayız
        //    ekledıgımız yerde .cs dosyası olarak olustugunu görürsünüz

        //    böyle yapmayıp yani farklı bir class acmak yerine ama boylesi daha iyi tabiki
        //    kullandıgın yerdeki scop aralıgından cıkarak farklı bir class olusturabilirsin
        //    mesela bizim su anda kullandıgımız 
        //    class Program
        //    {

        //    }

        //    bunun scop un dan cıkarak baska bir class da yazabilirsin

        //    bir namespace birden fazla classı barındarabilir bu bir uzaydı bundan bahsetmiştik

        //    Musteri122 class ına bakın aynı namespace de ler

        //    bu sekildeki kullanımlar pek tavsiye edilmiyor kodun okunaklıgı acısından

        //    bizim class larımız namespace in altında durur en ust seviye class ları barındırır
        //    class lar metotları barındırır
        //    metotlar işleri yapar

        //    Musteri122 class ına gidip orda işlemler yapalım - 1. not
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
        //    M1 demek benim için Musteri122 demek oluyor
        //    M1. dedıgımızde nesnenın içindeki tanımlara ulasabilmemiz gerekiyor
        //    ama M1. dedıgımız de birşey cıkmıyor
        //    cıkmama sebebini ogrenmek için tekrar Musteri122 class ımıza gidelim
        //    neyi eksik yaptık ona bakalım

        //    2. not için Musteri122 e gidelim
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
        //    //Musteri122 M1 = new Musteri122();

        //    //// 2. not 
        //    //Musteri122 M1 = new Musteri122();
        //    //M1.Selam();

        //    //Musteri122.Selam();

        //    //// 3. not 
        //    Musteri122 M1 = new Musteri122();
        //    M1.TcKimlikNumarasi = "12345678910";
        //    M1.isim = "Mücahit";
        //    M1.soyIsim = "Çetikaya";
        //    M1.cinsiyet = 717770001;

        //}

        ///*

        //class Musteri122Programcs
        //{

        //}

        //*/

        #endregion














    }
}
