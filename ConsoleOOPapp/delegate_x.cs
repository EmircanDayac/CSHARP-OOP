using System;

namespace ConsoleOOPapp.Properties
{
    delegate void dikdörtgen(double a, double b);
    public class x {
    
        
        static public void alan(double x,double y)
        {
            Console.WriteLine("alan"+ x*y);
        }

        static public void cevre(double n, double m)
        {
            Console.WriteLine("cevre"+2*(n+m));
        }

        public void cagrı()
        {
            dikdörtgen _dikdörtgen = new dikdörtgen(alan);
            _dikdörtgen += cevre;
            _dikdörtgen(2, 3);
        }
    }
    
   
    
}