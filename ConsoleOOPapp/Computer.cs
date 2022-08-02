using System;

namespace ConsoleOOPapp
{
    public class Computer : ProductInfos
    {
        public string CPU { get; set; }
        public string RAM { get; set; }

        public void yazdır()
        {
            Console.WriteLine(CPU+" "+" "+RAM+" "+Price);
        }
        
    }
}