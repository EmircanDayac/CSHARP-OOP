using System;

namespace ConsoleOOPapp
{
    class hayvan 
    {
        public void asıyap()
        {
            Console.WriteLine("ası yapıldı");
        }
        public virtual void temizle()
        {
            Console.WriteLine("temizleme base class");
        }
    }

    class kedı:hayvan
    
    {
        public override  void temizle()
        {
            Console.WriteLine("temizleme devide class");
        }
    }


    class Toyota
    {
      public virtual  void Yakit()
        {
            Console.WriteLine("Toyota uygun motor yakıtlarını kullanır");
        }

        public  void Motor()
        {
            Console.WriteLine("toyota kendine uygun motorlarıkullanır");
        }
    }


    class ToyotaBenzinli:Toyota
    {
       
       public  override  void  Yakit()
        {
            Console.WriteLine("benzin'e özel benzin Kullanılıyor");
        }
        
        public void Yakit(double maximumtüketim)
        {
            if (maximumtüketim<6.8)
            {
                Console.WriteLine("benzinli toyota maşallah");
            }
            else
            {
                Console.WriteLine("benzinli toyota size göre değil");
            }
        }



        public void Motor()
        {
            Console.WriteLine("1.4 motor kullanılır benzinde");
        }
    }

    class ToyotaDizel:Toyota
    {
        public override void Yakit()
        {
            Console.WriteLine("eurodizel yakıt kullanırlar");
        }

        public void Motor()
        {
            Console.WriteLine("1.6 dizel motor vardır");
        }
        
        public void Yakit(string renk)
        {
            if (renk.Equals("mavi") || renk.Equals("kırmızı")||renk.Equals("beyaz"))
            {
                Console.WriteLine("istediğiniz renkte araç var");
            }
            else
            {
                Console.WriteLine("istediğiniz renkte araç yok ");
            }
        }

        
    }

    class ToyotaElektrikli:Toyota
    {
        public void Yakit()
        {
            Console.WriteLine("yakıt elektriktir");
        }

        public void Motor()
        {
            Console.WriteLine("motor elektrik motorudur");
        }
    }


  
    
    

 
    
}