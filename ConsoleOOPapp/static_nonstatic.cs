using System;

namespace ConsoleOOPapp
{
    public class static_nonstatic
    {
       static public int id { get; set; }
    }

    class a
    {
        static public void Yazdır()
        {
            Console.WriteLine("nesneden bağımsız");
        }
    }



}