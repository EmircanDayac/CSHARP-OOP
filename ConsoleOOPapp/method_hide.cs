using System;
using System.Runtime.InteropServices;

namespace ConsoleOOPapp
{
    class U:P
    {
       new  public void write()
        {
            base.write();
            Console.WriteLine("method gizle u");
        }
    }

    class P
    {
       

        public  void write()
        {
            Console.WriteLine("method gizle p");
       
        }
    }



}