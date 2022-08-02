namespace ConsoleOOPapp
{
    class impli
    {
        public int sayi;
        public static implicit operator int(impli a)
        {
            return a.sayi;
        }
        
     
    }


    class expi
    {
        private bool a = false;

        public static explicit operator bool(expi c)
        {
            return  c.a;
        }
    }
}