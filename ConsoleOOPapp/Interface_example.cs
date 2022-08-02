using System;

namespace ConsoleOOPapp
{
    interface IDunya
    {
        void data();
    }


    class MyClass:IDunya
    {
        public void data()
        {
            Console.WriteLine("my class sınıfı");

        }
    }
    class ı : IDunya
    {
        public void data()
        {
            Console.WriteLine("ı class");
        }
    }
    

}
