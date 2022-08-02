using System;

namespace ConsoleOOPapp
{
    //operatorlerin aşırı yüklenmesi olayı aslında nesnelerin operatör işlemi yapmasını sağlayan bir durumdur.
    
 

    class _overloading_oprator
    {

        public int topla { get; set; }
        public static _overloading_oprator operator +(_overloading_oprator sag, _overloading_oprator sol)
        {
            return new _overloading_oprator { topla = sag.topla + sol.topla };
        }
    }

    class false_or_true
    {
        public int X { get; set; }
        public static bool operator false(false_or_true value)
        {
            throw new System.NotImplementedException();

        }

        public static bool operator true(false_or_true value)
        {
            if (value.X>10)
            {
                Console.WriteLine("true döndü");
                return true;
            }
            else
            {
                return false;
            }

            
        }

       
    }
}