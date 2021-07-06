using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanArrayList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";

            Dosen dosen1 = new Dosen();
            dosen1.Nik = "6666";
            dosen1.NamaDosen = "Joni";

            Dosen dosen2 = new Dosen();
            dosen2.Nik = "9999";
            dosen2.NamaDosen = "Cahyo";

            ArrayList list = new ArrayList();

            list.Add(mhs1);
            list.Add(mhs2);
            list.Add(dosen1);
            list.Add(dosen2);

            Console.WriteLine("id   Nama   Status");
            Console.WriteLine("==================");

            foreach (var item in list)
            {
                if (item is Mahasiswa)
                {
                    Mahasiswa mhs = (Mahasiswa)item;
                    Console.WriteLine("{0}, {1}, {2}", mhs.Nim, mhs.NamaMahasiswa, mhs.GetType().Name);
                }
                else
                {
                    Dosen dsn = (Dosen)item;
                    Console.WriteLine("{0}, {1}, {2}", dsn.Nik, dsn.NamaDosen, dsn.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
