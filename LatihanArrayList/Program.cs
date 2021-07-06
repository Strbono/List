using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrBilangan = new ArrayList();
            
            // menambahkan elemen arraylist
            arrBilangan.Add(12); //boxing
            arrBilangan.Add(14);
            arrBilangan.Add(17);

            int bil = (int)arrBilangan[2];
            Console.WriteLine(bil);
            Console.WriteLine();

            foreach (int bilangan in arrBilangan)
            {
                Console.WriteLine(bilangan);
            }

            Console.ReadKey();
        }
    }
}
