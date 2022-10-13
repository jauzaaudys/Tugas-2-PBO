using System;
namespace Destructor
{
    class Murid
    {
        public Murid()
        {
            Console.WriteLine("Contoh Program Destructor");
            Console.WriteLine("=========================");
        }
        // Destructor
        ~Murid()
        {
            Console.WriteLine("Jauza Audy Safitri");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Jalankan();
            GC.Collect();

        }
        public static void Jalankan()
        {
            // Membuat Instance Class
            Murid murid = new Murid();
        }
    }
}