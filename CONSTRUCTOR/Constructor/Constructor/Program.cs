using System;
namespace Constructor
{
    public class Constructor_Static
    {
        //static data member   
        private static int nim = 071;
        public static int Id
        {
            get
            {
                return nim;
            }
        }
        public static void print()
        {
            Console.WriteLine("Contoh Constructor");
            Console.WriteLine("==================");
            Console.WriteLine("Jauza Audy Safitri = " + nim);
        }
        public static void Main(string[] args)
        {
            //Print Value nim 
            Constructor_Static.print();
        }
    }
}