using System;

namespace ConsoleOOPapp
{
    
    class generic<T,X>
    {
        public T a;

        public X n;

        public X metot(X m)
        {
            return m;
        }
        
    }

    class zorunlu<P> where P:class
    {
        public void class_goster()
        {
            caferle _caferle = new caferle();
            _caferle.metot1();
                
        }
    }

    class  caferle
    {
        public void metot1()
        {
            Console.WriteLine("caferler");
        }
    }

}
