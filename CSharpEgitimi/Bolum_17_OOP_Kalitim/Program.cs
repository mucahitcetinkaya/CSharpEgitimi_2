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


    }
}
