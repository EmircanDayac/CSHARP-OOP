using System;

namespace ConsoleOOPapp
{
    public class Destructor_x
    {
        public Destructor_x()
        {
          
            Console.WriteLine("oluştu");

        }

        ~Destructor_x()
        {
            Console.WriteLine(
                "silindi");
        }


   
    }
}