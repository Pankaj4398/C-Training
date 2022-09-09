using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Inheritance
    {
        private int x;
        protected int y;
        internal int z;
        protected internal int w;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Z { get { return z; } set { z = value; } }
        public int W { get { return w; } set { w = value; } }
        public Inheritance(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Inheritance()
        {
        }

        public void Display()
        {
            Console.WriteLine(x + " " + y + " " + z + " " + w); 
        }
    }
}
