using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiwa = "Erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiwa = "Wely";

            Dosen dosen = new Dosen();
            dosen.Nik = "6666";
            dosen.NamaDosen = "Thariq";

            List<Mahasiswa> list = new List<Mahasiswa>();

            list.Add(mhs1);
            list.Add(mhs2);

            //Mahasiswa mhs = list[1];
            //Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiwa);

            Console.WriteLine("NIM  NAMA");
            Console.WriteLine("=========");

            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiwa);

            }

            Console.ReadKey();
        }

    }
}
