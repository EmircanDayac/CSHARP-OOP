using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using ConsoleOOPapp.Properties;


class deneme
{
  public void naber()
  {
    Console.WriteLine("naber global");
  }
}
namespace ConsoleOOPapp
{
  
  
  //public heryerden ulaşılabilir 
  //private sadece tanımlanan classta ulaşılabilir 
  //internal aynı proogram içinden ulaşılabilir başka programdan ulaşılamaz
  internal class Program
  {
   
    private const float pi = 3.14f;
    public static void Main(string[] args)
    {
      //class çağırma
      Hayvanlar hayvan = new Hayvanlar();
      hayvan.ad = "köpek";
      hayvan.Türü = "Golden";
      hayvan.yas = 10;
      
      hayvan.special();

      //constructor class
      Constructorclass sınıf = new Constructorclass("emircan", "dayac");
      sınıf.yazdır();

      //enum kullanımı
      EnumUse ennms = new EnumUse();
      if (ennms.school.Equals(schools.birinci))
      {
        Console.WriteLine("enums kullanımı");
      }
      else if(Enum.Parse(typeof(schools),"1") == "ikinci")
      {
        Console.WriteLine("naberknk");
      }

      //encapsullation
      Property ozel = new Property();
      ozel._Property = "emircan2";
      var ozelProperty = ozel._Property;
      Console.WriteLine(ozelProperty);
      
      
      //Kalıtım İşlemi
      Computer Bilgisayar = new Computer();
      Bilgisayar.CPU = "i7";
      Bilgisayar.RAM = "8GB";
      Bilgisayar.Price = 17000;
      Bilgisayar.yazdır();

      //base kullanmı
      A _baseevent = new A();
      _baseevent.yaz();

      //this kullanımı
      this_use _thisUse = new this_use(2);
      Console.WriteLine(_thisUse.x+" "+"this method use constructor");
      
      //readonly ile const arasındaki fark oluşturuduğumuz class ta const tanımladığımız ilk anda değeri vermekte
      //zorunluyuz ancak eğer readonly etiketini kullanırsak class'ı constructor hale getirip class fonksiyonu için readonly ile belirlenmiş değişkenin içine yazabiliriz
      //ayırca consta nesneyi tanımlamaya gerek duymazken readonly ile tanımladıysak başta nesneyi tanımlamamız lazım.


      //değer tipler ve referans tipler değer tipler referans tiplerden daha hızlı çalışır ve heap olan tiplerde kodlama hatasınıa
      //sonuç verebilir değer tipler int float double struct heap tipler class, object ,array ,string ,interface,delegate

      //Protected kendisinden kalıtılmış classlara sadece izin verir
      //Protected İnternal kendisinden kalıtılmış classlara sadece izin verir aynı projede olması zorunlu değildir

      //method da static kullanımı nesneden bağımsız olmasını sağlar 
      //static örnek 
      Console.WriteLine("static olayı"+static_nonstatic.id);
  
      //metod gizleme 
      U _u = new U();
      _u.write();

      //yıkıcı class
      Destructor_x _destructor = new Destructor_x();
      
      //method genişletme
      string cafer = "mert";
      cafer.karakteruzunlugu();

      int p = 14;
      p.intten_karaktere();
      
    //operator overloading 
    _overloading_oprator ç = new _overloading_oprator { topla = 10 };
    _overloading_oprator ö = new _overloading_oprator { topla = 20 };
    _overloading_oprator g = ö + ç;
    Console.WriteLine(g.topla+"hesaplandı");

    //bool overloading 
    false_or_true x = new false_or_true { X = 20};

    if (x)
    {
      Console.WriteLine("truela");
    }
    //method override 
    kedi siyam = new kedi();
    siyam.ses();
    kopek golden = new kopek();
    golden.ses();
    
    
    //polymorphism çok biçimlilik
    //iki tür polymorphism türü vardır 
    //1 static(complime time) yani overloadinglerdir yani aşırı yükleme
    //2 dynamic(run time) overide virtual metot ezme olayları 
    //aynı isimdeki methodu farklı farklı sonuçlar verecek şekilde çalıştırmasıdır polymorphism
    hayvan hayvanlar = new hayvan();
    hayvanlar.temizle();
    kedı kedı = new kedı();
    kedı.temizle();
    hayvan sıyam = new kedı();
    sıyam.temizle();

    Toyota _toyota = new Toyota();
    _toyota.Yakit();

    Toyota _toyota_benzinli = new ToyotaBenzinli();
    _toyota_benzinli.Yakit();
  //sealed hiçbir classın prop ya da sonra gelecek methodun kendisinden sonra kullanılamayacağını belirtir
  
  
 //partial - parçalı iki classı birleştirir methodlarda ise iki methodu birleştirir ama biryerde methodu tanımlaman
 //diğer yerde methodu uygulama yapmanı ister
 
 personel kisi1 = new personel();
 kisi1.maaş = 1000;
 kisi1.isim = "sami";
 kisi1.soyisim = "öztemel";
 
 
 //dispose kaynakları serbest bırakmamızı sağlar bu sayade
 //garbage collector  iş yükü yüklemez referans edilmeyen tiplerin silinmesini sağlarız 
 //dispose bu yüzden kullanırız
 SqlConnection _sql = new SqlConnection();
 _sql.Dispose();
 
 //struct ile class arasındaki fark class lar heap tiplidir structlar ise stack tiplidir yani stack ve heap 
 //stack de büyük veriler taşınmaz 16byte lık data kullanılır üstü hesap tutulmalı veriler net ise struct ile verileri tutmalıyız
 //struct da constractor olmaz struct Destructor da struct da değer veremezsin 
 //teorik 
 
 
 //abstract class 'ta nesne alınmaz ama referans alabiliriz abstract class base diğerlerine base class olunca 
 //abstract classta olan bütün her method vb şeyler diğer classlarda da olmak zorunda abstract class içinden methoda ulaşmak istiyorsak eğer static olarak tanımlayıp nesneden 
 //ayrıştırmalıyız
 AbstractClass emir = new c();
 emir.data();
 AbstractClass.emircan();
 
 //İnterface içinde ki her şey publictir erişim tanımlanamaz abstract class ta olduğu gibi implement zorunluluğu vardır 
// deneme2(); bütün interface olmuş methodları çağırabiliriz abstract class gibi şablondur //interface de kendi içinde method oluşturamasınız ama sadece soyuttur 
      IDunya emirle = new ı();
      emirle.data();
      IDunya my = new MyClass();
      my.data();
 
 //abstract class ile interface ile arasında ki fark
//abstract class ta constract ve destruct oluşturabiliriz
//interface te constract ve destruct oluşturamayız
// intrface te   birden fazla ınterface alabilir bir class 
// interface te her şey public erişimlidir 
// abstract class ta //kendi içinde method oluşturablirsiniz sadece soyut değildir  erişim belirleyicisi kulannabiliriz bir class sadece bir abstracttan türer diğer abstract classlardan birden fazla base alamaz 


//implicit explicit casting 
      impli _impli = new impli();
      _impli.sayi = 12;

      int farklı_sayı = _impli;

      expi _expi = new expi();
      bool ne;
      ne = (bool)_expi;

      Console.WriteLine(farklı_sayı+"impli");
      //iç içe sınıflar 

      damar.kan _new = new damar.kan();
      _new.damarbelirle();
      
      //Anonim-İsimsiz Tipler oluşturma
      var deneme = new { b = 12, c="emircan",d= new
      {
        emircan = "emircan"
      }};
      Console.WriteLine(deneme.d.emircan);
      
      
      //Non-Generic Koleksiyonlar
      
      // arraylist,srtedlist,bitarray,hashtable,stack,Queue

// boxing unboxing işleme value type dan ref type a çevrim olursa bu boxing value --->ref tersi unboxingdir 
      // normal sıralamaya göre yapar 
      SortedList sorted = new SortedList()
      {
         { "osman", 12 },
          { "cafer", 20 },
          { "emircan", 30 }
      };
      Console.WriteLine(sorted.Count);
      Console.WriteLine(sorted.ContainsKey("osman"));
      for (int i = 0; i < sorted.Count; i++)
      {
        Console.WriteLine(sorted.GetKey(i));
      }
//kendi hashine göre sıralar her birinin hashi vardır 
//bir key sorted da string ile başladıysa öyle devam etme zorunluluğu vardır ama hashtableda öyle bir sorun yoktur key istediği zaman string istediği zaman farklı bir tür olabilir 
      Hashtable hashtable = new Hashtable()
      {
        {"cafer",12},
        {12,"mert"}
        
      };
      // stack last in first out 
      //son giren ilk çıkar
      Stack stack = new Stack();
      stack.Push(12);
      stack.Push(124);

      stack.Push(20);

      stack.Push(30);
      for (int i = 0; i < 4; i++)
      {
        Console.WriteLine(stack.Pop());
      }
//ilk giren ilk çıkar 
      Queue queue = new Queue();
      queue.Enqueue(12);
      //bit array de var 


      int[] array = new[] { 10, 20, 30, 40 ,-40};
      //İterasyon Kavramı ve Yield Anahtar Kelimesi
      // yield  fonksiyonunuzun yalnızca bir kez okumanız gereken çok fazla elemanlı bir değer kümesi döndüreceğini bildiğinizde kullanışlı olacaktır.
      // IEnumerable interface'i implement edildiğinde içerisindeki her bir eleman sayılabilir duruma gelir.
      itere _itere = new itere();
      foreach (var VARIABLE in _itere.metot1(array))
      {
        Console.WriteLine(VARIABLE);
      }
    //indexer
    indexer _indexer = new indexer();
    _indexer[0] = 12;
    Console.WriteLine(_indexer[0]);
    //Generic yapılar classlar interfaceler methodlar 
    
    generic<int,string> _generic = new generic<int,string>();
    _generic.a = 12;
    _generic.n = "emircan";
    _generic.metot("string dönen generic");
    //zorunlu class;
    zorunlu<caferle> _zorunlu = new zorunlu<caferle>();
    _zorunlu.class_goster();
    //delegate temsilci fonksiyonumuzu daha iyi yönetmemizi sağlar  
    x _x = new x();
    _x.cagrı();
    //events belirli şartlar sağlandığında gerçekleşen olaylar ziniciridir 
   

    // attiribute takım çalışmasında gelennel olarak kullanılan bir şey dir örnek verecek olursak 
    
    
    //instance örneği 
    InstanceX.getInstance().func();
   
    // int[,,] cokboyutludizi =
      // {
      //   { { 2, 3, 4 }, { 3, 4, 5 }, { 3, 45, 6 } }, { { 4, 5,6 }, { 2, 3,7 }, { 5, 6,1 } },
      //   { { 1, 2,7 }, { 45, 12,1 }, { 12, 3 ,4} }
      // };
      // Console.WriteLine(cokboyutludizi[0,2,1]);

      // int[,,,] dort =
      // {
      //   { { 10, 2, 3, 4 }, { 6, 7, 8, 9 }, { 10, 20, 30, 40 }, { 10, 20, 30, 40 } },
      //   { { 10, 20, 30, 40 }, { 10, 20, 30, 40 }, { 10, 20, 30, 40 }, { 10, 20, 30, 40 } },
      //   { { 10, 20, 30, 40 }, { 10, 20, 30, 40 }, { 10, 20, 30, 40 }, { 10, 20, 30, 40 } },
      //   { { 10, 20, 30, 40 }, { 10, 20, 30, 40 }, { 10, 20, 30, 40 }, { 10, 20, 30, 40 } }
      // };
      //
  
      var a = "emircan";
      object z = "cafer";
      dynamic d = "emir";
      
      //Unboxing İşlemi
      string n = (string)z;
      Console.WriteLine(n);

      // string p = d;
      // Console.WriteLine(p);

      int[] diziler = new int[3]{2,3,4};
      //<int>'den sonra ( ) bunun içine diziyi yazabiliriz
      List<int> numbers = new List<int>(){10,20,30,40,50};
      // numbers.Add(90);
      // numbers.Remove(30);
      // numbers.RemoveAt(2);
      // Console.WriteLine(numbers.Count);
      // numbers.Contains(20);
      // Console.WriteLine(numbers.BinarySearch(10));
      // foreach (var VARIABLE in numbers)
      // {
      //   Console.WriteLine(VARIABLE);
      // }
      //
      // Console.WriteLine(pi);
      // Console.WriteLine(topla(12,10,20,30));
      // Console.WriteLine(topla(" emircan"));
      
      //ref out kullanımı ref kullnamak için başka değişken değeri olması şart ama out da değişken değeri olması şart değil
      int t = 12;
      Console.WriteLine(t);
      degistir(ref t);
      Console.WriteLine(t);
      ConsoleOOPapp.a.Yazdır();
      myclass2 _myclass2 = new myclass2();
      _myclass2.naber();
    }

   

    static public void deneme2(IDunya dunya)
    {
      dunya.data();
    }

    static void degistir(ref int l)
    {
       l = 30;
    }


  
   

   

    //overloading örneği 
    static int topla(params  int[] sayılar)
    {
      var topla = 0;
      foreach (var VARIABLE in sayılar)
      {
        topla += VARIABLE;
      }

      return topla;
    }


    static int topla(int a, int b)
    {
      return a + b;
    }

    static string topla(string name)
    {
      return name;
    }

   
 
  }

  
  //global kullanımı 


  class deneme
  {
    
  }

  class myclass2:global::deneme
  {
    
  }

}


