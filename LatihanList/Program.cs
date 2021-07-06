using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNilai = new List<int>();

            listNilai.Add(70);
            listNilai.Add(100);
            listNilai.Add(85);

            int nilaiElement1 = listNilai[1];

            Console.WriteLine(nilaiElement1);
            Console.WriteLine();

            foreach (int nilai in listNilai)
            {
                Console.WriteLine(nilai);
            }

            Console.ReadKey();
        }
    }
}
