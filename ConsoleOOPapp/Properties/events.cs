using System;

namespace ConsoleOOPapp.Properties
{
    public class events
    {

        delegate void test();

        private static event test x
        {
            add
            {
                Console.WriteLine("evente func eklendi ");   
            }
            remove
            {
                Console.WriteLine("eventen func silindi");
            }
        }
       

   

        static public void deneme()
        {
            Console.WriteLine("deneme");
        }     
        
 
    }
    
    
}
