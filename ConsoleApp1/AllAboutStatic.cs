using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    static class AllAboutStatic //All members should be static
    {
        private static int resultStorage = 0; //static field

        //public static var Type = "Arithmetic";//var can't be used to static members
        public static string Type = "Arithmetic"; //static field

        public static int ResultStore //static property
        {
            get { return resultStorage; }
            set { resultStorage = value; }
        }

        public static int Sum(int num1, int num2) //static method
        {
            return num1 + num2;
        }

        static AllAboutStatic() { //static constructor without using access modifiers
            Console.WriteLine("Static Constructor Called");
        }

    }

    public class NonStaticClass 
    {
        //A non-static class can contain one parameterless static constructor.Parameterized static constructors are not allowed.
        public NonStaticClass() 
        {
            Console.WriteLine("Instance Constructor gets Called");
        }

        static NonStaticClass() //A static constructor can only access static members. implicitly provided if static variables present in class or else we ned to define it explicitly
        {
            Console.WriteLine("Static Constructor gets Called");
        }
    }

    /*
     Special Notes :
        Static members are stored in a special area in the memory called High-Frequency Heap.
        Static members of non-static classes are shared across all the instances of the class.
        So, the changes done by one instance will be reflected in all the other instances.
     */
}
