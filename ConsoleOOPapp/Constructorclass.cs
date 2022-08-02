using System;

namespace ConsoleOOPapp
{
    public class Constructorclass
    {
        public string ad;
        public string soyad;
        
        public Constructorclass(string _ad,string _soyad)
        {
            ad = _ad;
            soyad = _soyad;
        }

        public void yazdır()
        {
            Console.WriteLine("ad :{0} , soyad :{1}",ad,soyad);
        }
    }
}