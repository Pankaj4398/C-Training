using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts
{
    public class Operators
    {
        private int a;
        private int b;
        private string c = string.Empty;

        public Operators()
        {
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public string C
        {
            get { return c; }
            set
            {
                c = value;
            }
        }

        public void ArithmeticOperations(int a, int b)
        {
            Console.WriteLine(+a);
            Console.WriteLine(-b);
        }
    }
}
