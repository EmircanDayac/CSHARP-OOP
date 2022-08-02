using System;

namespace ConsoleOOPapp
{
    public class Hayvanlar
    {
        public string ad;
        public string Türü;
        public int yas;



        public void special()
        {
            Console.WriteLine("adı:{0} türü:{1} yası:{2}",ad,Türü,yas);
        }
    }
}