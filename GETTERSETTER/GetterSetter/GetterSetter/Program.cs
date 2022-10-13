using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class Boneka
    {
        //ini adalah field
        private string nama;
        private string warna;
        private int jumlahTangan = 2;
        private int jumlahKaki = 2;

        //ini adalah method getter
        public string LihatNama()
        {
            return nama;
        }

        //ini adalah method setter
        public void GantiNama(string namaBaru)
        {
            nama = namaBaru;
        }

        //ini adalah method getter
        public string LihatWarna()
        {
            return warna;
        }

        //ini adalah method setter
        public void GantiWarna(string warnaBaru)
        {
            warna = warnaBaru;
        }

        //ini adalah method getter
        public int LihatJumlahTangan()
        {
            return jumlahTangan;
        }

        //ini adalah method getter
        public int LihatJumlahKaki()
        {
            return jumlahKaki;
        }

        public void JalankanBoneka()
        {
            Console.WriteLine("Boneka {0} sedang berjalan ...", nama);
        }
    }
}

namespace GetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek boneka bernama myBoneka
            Boneka myBoneka = new Boneka();

            myBoneka.GantiNama("Unyil");
            myBoneka.GantiWarna("Pink");

            Console.WriteLine("Boneka Saya bernama {0} ", myBoneka.LihatNama());
            Console.WriteLine("Boneka Saya berwarna {0} ", myBoneka.LihatWarna());
            Console.WriteLine("Boneka Saya memiliki {0} kaki dan {1} tangan", myBoneka.LihatJumlahKaki(), myBoneka.LihatJumlahTangan());

            //Suruh boneka berjalan
            myBoneka.JalankanBoneka();
        }
    }
}