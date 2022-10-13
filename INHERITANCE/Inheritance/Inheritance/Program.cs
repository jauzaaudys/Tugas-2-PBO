using System;
namespace Inheritance
{
    // Parent class
    class Shape
    {
       
        public void setLebar(int w)
        {
            lebar = w;
        }
        public void setTinggi(int h)
        {
            tinggi = h;
        }
        protected int lebar;
        protected int tinggi;
    }

    // Child class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (lebar * tinggi);
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setLebar(8);
            Rect.setTinggi(6);

            // Print the area of the object.
            Console.WriteLine("MENGHITUNG LUAS PERSEGI PANJANG");
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.WriteLine("Total Luas Persegi Panjang: {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}