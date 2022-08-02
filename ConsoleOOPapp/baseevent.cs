using System;

namespace ConsoleOOPapp
{
   
        class A:B
        {
            public void yaz()
            {
                base.yaz();
                Console.WriteLine("A CLASSI");
            }
        }

        class B 
        {
            public void yaz()
            {
                Console.WriteLine("base class yazdırma");
            }
        }
    }
