
//using System.Collections.Generic;

//namespace Bolum_22_Generic
//{
//    public class V178GenericRepository<T>
//    //public class V178GenericRepository<T,K,L,M,N>
//    //public class V178GenericRepository<T> where T : class
//    {

//        public V178GenericRepository()
//        {
//            // context : EF DBFirst
//        }

//        //public virtual IEnumerable<T> Getir() 
//        //{
//        //    return null;
//        //}

//        public virtual List<T> Getir()
//        {
//            return null;
//        }

//        public virtual void yeniKayitEkle(T data)
//        {

//        }

//    }
//}

///*
 
//3. not bitiş program.cs den geldik

//4. not baslangıc
 
// ilk hali


//namespace Bolum_22_Generic
//{
//    public class V178GenericRepository
//    {
//    }
//}

//sonraki hali


//namespace Bolum_22_Generic
//{
//    public class V178GenericRepository<T>
//    {
//    }
//}

//sen V178GenericRepository olarak bir T tipi alacaksın dedik

//bunun içinde bir yapıcı metot acalım ctor 

//namespace Bolum_22_Generic
//{
//    public class V178GenericRepository<T>
//    {

//        public V178GenericRepository()
//        {
//            // context : EF DBFirst
//        }

//    }
//}

//benım V178GenericRepository class ım bir yapıcı metotla içeri de context dedıgım EF (entityframework) yaklasımın da mesela DBFirst olsun 

//DBFirst in context ini ornekleyecek yani ben bu nesneyi ornekledıgım de yapıcı metot database ile bir baglantı kuracak 
//kurmus oldugu baglantı da haberleşir halde bekleyecek

//farklı bir metot yazıp bunu ınceleyelim

//vırtual metot kullanalım 
//geriye IEnumrable ınterface inden generic olarak data donen <T> t don bana
//bu metodun adı da Getir olsun

//son durum

//using System.Collections.Generic;

//namespace Bolum_22_Generic
//{
//    public class V178GenericRepository<T>
//    {

//        public V178GenericRepository()
//        {
//            // context : EF DBFirst
//        }

//        public virtual IEnumerable<T> Getir() 
//        {
//            return null;
//        }

//    }
//}

//ekledıgımız metot 

//        public virtual IEnumerable<T> Getir() 
//        {
//            return null;
//        }

//bu metodu ınceleyelim amac generic metot kullanımını anlatmak
//generic class ın nasıl kullanıldıgını gosterebilmek


//V178GenericRepository adında bir class olusturdum ve dedım ki sen orneklendıgın de T tipini sor 
//senı ornekleyen kişi bu T tipi uzerınde işlem yapabilsin 

//getir adına bir metot var metot ınterface donuyor genel olarak list generic olarak da isimlendirilir
//interface in de generic ini gorun diye boyle kullandık 

//getir metodu parametre almıyor 
//geriye ne getiriyor T tipinde bir liste getiriyor 

//IEnumerable yerine List de yazılabilir 

//son durum

//        public virtual List<T> Getir()
//        {
//            return null;
//        }


//bir list generic geriye dondurecek ama dondurecegı generic ifadenin ne oldugunu daha soylemedık 

//list generic int de olabilir List<int> boyle yazılır List<string> de olabilir List<Musteri> de döndürebilir

//buradaki amac ne 

//Gelen T tipini database üzerinde sorgulamak ve elde etmiş oldugum kayıtları generic koleksiyon olarak bir üst katmana dönmek

//birlikte genericrepository i ornekleyelim 

//4. not bitiş program.cs e gidelim

//7. not bitiş program.cs den geldik

//8. not baslangıc

//yeni kayıt eklemek için 
//yeni bir metot yazalım
//public olsun
//virtual bazı ozel sebebleri var sonra anlatacagız bunu
//geriye bisey donmesin void
//T tipi deger alacak parametresi T data

//public virtual void yeniKayitEkle(T data)
//{

//}

//bize gelen T tipi içerisindeki bilgiyi T tipinin işaret etmiş oldugu tabloya ekliyoruz

//8. not bitiş program.cs e gidelim

//9. not bitiş program.cs den geldik

//10. not baslangıc

//generic ler birden fazla ifade alabilirler

//<T,K,L,M,N> VS VS VS GİBİ nesne orneklenırken de bu kadar generic ifadenin karsılıgını
//bizi cagıran programcıya sorabiliriz fakat gercek hayatta bu en fazla 2 dir

//genelde tek tip uzerınde işlemlerimizi yaparız

//diger bir kural where sartı ile T tipinin tipini belirleyebiliriz

//mesela

//T:class dedigimiz de T tipimiz bir class olmak zorunda kalır 

//int mesela class degildir struct olarak gecer T:class dedıgın de int veremezsin

//            V178GenericRepository<int> repoMusteri = new V178GenericRepository<int>();

// 10. not bitiş program.cs e gidelim
 
//*/