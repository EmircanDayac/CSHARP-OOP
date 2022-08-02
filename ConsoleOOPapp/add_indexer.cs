namespace ConsoleOOPapp.Properties
{
    class indexer
    {
        private int[] a = new int[5];


        public int this[int index]
        {
            get
            {
                return a[index];
            }
            set
            {
                a[index] = index * 2 + 1;
            }
        }
    }
}