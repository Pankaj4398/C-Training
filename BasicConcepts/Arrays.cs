using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts
{
    class Arrays
    {
        int[] a = new int[] {1, 2, 7, 8, 4};
        int[] b = { 1, 2, 3, 4, 5 };

        int[,] arr2d1 = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

        
        int[,] arr2d2 = {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                };

        public void general()
        {
            //Array Declaration using var
            var c = new int[5] { 10, 20, 30, 40, 50 };


            foreach(var j in b)
            {
                Console.WriteLine(j);
            }
            
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Array.Reverse(c);
            int k = 0;
            while(k < c.Length)
            {
                Console.WriteLine(c[k]);
            }
            //The Array class implements the IEnumerable interface, so you can LINQ extension methods
            //System.Linq Namespace
            Console.WriteLine(c.Max() + " " + c.Min() + " " + c.Average());
            
            Array.Sort(a);
        }
    }
}
