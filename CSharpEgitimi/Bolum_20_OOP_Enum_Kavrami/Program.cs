
namespace Bolum_20_OOP_Enum_Kavrami
{
    internal class Program
    {
        //#region VİDEO

        //static void Main(string[] args)
        //{


        //}

        //#endregion

        #region VİDEO 166 Bilgilendirme

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 20 OOP Enum Kavrami V166 Bilgilendirme


        //    */

        //    /*

        //    1. not baslangıc

        //    uygulamalarımızı yazarken bize avantaj saglayacak
        //    onceki ve sonraki yazılımcıya da avantaj saglayacak dua ettirecek bir konudan bahsedeceğiz enum lar 

        //    okuma kolaylıgı acısından karsısına cıkacaktır ilgili kod satırını daha kolay yorumlayabilecektir

        //    enum lara neden ihtiyac duyarız
        //    enum nedir
        //    ne gibi avantaj saglar
        //    yazdıgımız uygulamaya avantaj saglar mı 
        //    olmasada bu iş olur mu 
        //    olması ne kazandırır

        //    */

        //}

        #endregion

        #region VİDEO 167 Enum Nedir

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 20 OOP Enum Kavrami V167 Enum Nedir


        //    */

        //    /*

        //    1. not baslangıc

        //    eski kodumuz da olabilir baska birinden de kod almıs olabiliriz

        //    katmanlı mimari uygulanmıyorsa if else blokları gelecektir

        //    ogrenci nesnesini bolum 19 dan ogrenci nesnesinden aldık hoca burada anlatmadı eski kod veya baskasından kod aldıgımız için kendı yazmıs anlatmak için boyle olusturmus akıllı adam

        //    Ogrenci nesnesi olusturalım

        //    1. not bitiş

        //    2. not bitiş ogrenciden geldik

        //    3. not baslangıc

        //    ogrenci nesnesini bolum 19 dan ogrenci nesnesinden aldık hoca burada anlatmadı

        //    V167Ogrenci O1 = new V167Ogrenci();
        //    O1.id = 1;
        //    int ogrenciKayitSonuc = O1.yeniKayit(O1);

        //    new ledik ve prop ve metot larını kullandık

        //    if else lerini yazalım

        //    ogrenci tipinden bir deger aktarımı yapılmıs ogrenciyi sisteme kayıt yapıyorum 
        //    kayıt etmeye calısırken ilgili metot bana bir sekılde bir metot donuyor 
        //    donmus oldugu deger ogrenciKayitSonuc degeri 
        //    bana burdan bir int deger dondu bu degeri benım yönlendirmem lazım 
        //    kayıt oldu mu
        //    parametresi dogru mu 
        //    runtime da hata mı aldım
        //    bütün soruların cevabında 71777700x ile donen bir deger var 0 a dogru kayıt 1 de parametresi dogru yanlıs vs gibi

        //    bunların acıklamasını kim biliyor kim yazdıysa o biliyor 
        //    uygulamayı kodlarken biz biliyoduk 
        //    ama şimdi hangisi ne bilmiyoruz 

        //    bunu anlamak için yenikayıtmetot içine gidip yazdıgımız veya yazılmıs kod bloklarını tek tek yenıden debug ederek uzerlerınden gecip hata kodlarının acıklamasını hatırlayacagız veya ogrenecegız
        //    işte bu karmasadan bizi kurtaran bir yapıdır enum 

        //    nesne yonelımlı kod yazma veya yazarken içerisindeki bütün degerleri dogru yerlerde kullanabilme eger firmanızın bir kuralı olduysa hiç bir kodu devir almaktan korkmayın 
        //    ama herkesın kafasına göre kod yazmıs oldugu yerlerde ise giden arkadası biraz yorunki karsınıza boyle bişey cıktıgında onları olması gereken yapıya cok kolay cevirebilirsiniz

        //    şimdı böyle bir karısık yapıyı daha okunaklı nasıl yaparız bunu birlikte ogrenelim

        //    */

        //    V167Ogrenci O1 = new V167Ogrenci();
        //    O1.id = 1;
        //    int ogrenciKayitSonuc = O1.yeniKayit(O1);

        //    if (ogrenciKayitSonuc == 717777000)
        //    {

        //    }
        //    else if (ogrenciKayitSonuc == 717777001)
        //    {

        //    }
        //    else if (ogrenciKayitSonuc == 717777002)
        //    {

        //    }
        //    else if (ogrenciKayitSonuc == 717777003)
        //    {

        //    }
        //    else if (ogrenciKayitSonuc == 717777004)
        //    {

        //    }
        //    else
        //    {

        //    }

        //}

        #endregion

        #region VİDEO 168 Enum inceleme - 1

        //static void Main(string[] args)
        //{

        //    /*

        //        Bolum 20 OOP Enum Kavrami V168 Enum inceleme - 1


        //    */

        //    /*

        //    1. not baslangıc

        //    amacımız ne amacımız enum nedir ogrenmek ama sade temiz bir kod yazabilmek dolayısıyla bir kurgumuzun olması lazım
        //    biz musteri kayıt edelim onda biraz daha iç sürecler var 
        //    musteri adında class acalım olusturmus oldugum class ımı da içeride bir arraylist i database gibi kullanıp
        //    onun içerisine aktarmaya calısacagım hem generic konusunu da bir on yatırım yapmıs oluruz 

        //    Musteri class ı olusturup oraya gidelim

        //    1. not bitiş

        //    2. not bitiş musteriden geldik

        //    3. not baslangıc

        //    sanalDatabase class ını acalım

        //    3.not bitiş
            
        //    4.not bitiş sanaldatabase den geldik

        //    5. not baslangıc

        //    musteri nesnesini new leyelim ve deger ataması yapalım.

        //    V168Musteri M1 = new V168Musteri();
        //    M1.id = 1;
        //    M1.musteriNumara = "MSN001";
        //    M1.isim = "Mücahit";
        //    M1.soyisim = "Çetinkaya";
        //    M1.emailAdres = "mucahitcetinkaya@outlook.com";

        //    new ledik ve deger ataması yaptık 
        //    şimdi de bunu db e ekleyelim

        //    V168SanalDatabase SB = new V168SanalDatabase();

        //    SB. diyince metot gelmiyor private olan bir arraylist var arkada 
        //                SB.musteriYeniKayit(M1);
        //    dedigimiz de erişebiliyoruz direk arraylist e erişemiyoruz 

        //    bu bana bir int deger donecegını söylüyor tooltype inde de yazıyor 

        //    bu geri donen degeri bir degıskene alalım

        //    int musteriKayitSonu = SB.musteriYeniKayit(M1);

        //    kontrol yazalım

        //    if (musteriKayitSonu == 717770001)
        //    {

        //    }

        //    bunu okunabilir bir sekle getirelim

        //    class olusturalım MusteriReturnValue

        //    5. not bitiş

        //    6. not bitiş V168MusteriReturnValue den geldik

        //    7. not baslangıc

        //    int musteriKayitSonu = SB.musteriYeniKayit(M1);

        //    buradaki int karsılıgını enum olarak almak istiyorum

        //    bunun için sanaldatabase e gitmemiz lazım

        //    7. not bitiş

        //    8. not bitiş sanaldatabase den geldik

        //    int musteriKayitSonu = SB.musteriYeniKayit(M1); ken artık int donmuyor hata veriyor donus tipini degistirdik

        //    V168MusteriReturnValue musteriKayitSonu = SB.musteriYeniKayit(M1);

        //    if sartını da guncelleyelim

        //    if (musteriKayitSonu == V168MusteriReturnValue.kayitBasarili)
        //    {

        //    }

        //    boyle yazarak okuma olarak kolaylık saglar
            
        //    ordaki kodun ne oldugunu anlamak için tekrar debug yapmak gerekmiyor
        //    build edelim debug yapalım enum ın davranısı uzerıne konusalım
        //    enum lar ile işimiz bitmedi ama temel mantıgı bu 

        //    uygulamada musterıye sundugu herhangi extra herhangi bir özellik yok 
        //    uygulamanın hızını etkileyecek bir özelliği yok 
        //    uygulamanın development süresini etkileyecek özellikleri bulunmaktadır

        //    sonraki video da debug edelim

        //    */

        //    V168Musteri M1 = new V168Musteri();
        //    M1.id = 1;
        //    M1.musteriNumara = "MSN001";
        //    M1.isim = "Mücahit";
        //    M1.soyisim = "Çetinkaya";
        //    M1.emailAdres = "mucahitcetinkaya@outlook.com";

        //    V168SanalDatabase SB = new V168SanalDatabase();
        //    //int musteriKayitSonu = SB.musteriYeniKayit(M1);
        //    V168MusteriReturnValue musteriKayitSonu = SB.musteriYeniKayit(M1);

        //    //if (musteriKayitSonu == 717770001)
        //    //{

        //    //}

        //    if (musteriKayitSonu == V168MusteriReturnValue.kayitBasarili)
        //    {

        //    }


        //}

        #endregion


    }
}
