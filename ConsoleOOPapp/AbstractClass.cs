using System;

namespace ConsoleOOPapp
{
    public abstract class AbstractClass
    {
                                 public abstract int deger { get; set; }
                                 public abstract void data();
                         
                                 public static void emircan()
                                 {
                                     Console.WriteLine("emircan abstract");
                                 }
                         
                             }
                         
    class c:AbstractClass
    {
        public override int deger { get; set; }

        public override void data()
        {
            Console.WriteLine("class c");
        }
    }

    class d:AbstractClass
    {
        public override int deger { get; set; }

        public override void data()
        {
            Console.WriteLine("class d");
        }
    }
}