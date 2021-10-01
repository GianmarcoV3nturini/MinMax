using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vettore = new int[5] { 4, 6, -3, 5, 7 };

            int min = vettore[0];

            for(int i=0; i>5;i++)
            {
                if (vettore[i] < min)
                    min = vettore[i];
            }

            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
