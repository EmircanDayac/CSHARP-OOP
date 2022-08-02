using System;

namespace ConsoleOOPapp
{
    class canlı
    {
        public virtual void ses()
        {
            Console.WriteLine("-------");
        }
    }

    class kopek:canlı
    {
        public override void ses()
        {
            Console.WriteLine("hav");
        }

    }

    partial class kedi:canlı
    {
        public override void ses()
        {
            Console.WriteLine("miyav");
        }
        
    }
}