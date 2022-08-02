using System;

namespace ConsoleOOPapp
{
   static class Extensions
   {
      public static void karakteruzunlugu(this string text)
      {
         Console.WriteLine("karakter uzunluğu"+" "+text.Length);
      }

      public static void intten_karaktere(this int text_2)
      {
        var d =  text_2.ToString();
        Console.WriteLine(d+"int karaktere çevrildi");
         
      }
   }
}