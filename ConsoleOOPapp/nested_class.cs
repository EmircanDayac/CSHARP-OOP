using System;

namespace ConsoleOOPapp
{
   public class damar
    {
        public static string hangidamar = "atardamar";
        public string hangidamar2 = "toplardamar";

        public class kan
        {
            public int kandakioksijenyüzdesi;

            private damar _damar = new damar();
            public void damarbelirle()
            {
                Console.WriteLine(hangidamar);
                Console.WriteLine(_damar.hangidamar2);
            }
        }
        
    }
    
}