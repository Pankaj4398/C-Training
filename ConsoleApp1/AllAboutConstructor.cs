using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class AllAboutConstructor
    {
        public int val;
        public static int id = 0;
        public AllAboutConstructor() //default or parameterless cons provided by compiler (if not defined one) except static class
        {
            id++;
            Console.WriteLine("Default Cons" + "\n" + "Id value : " + id);
        }

        public AllAboutConstructor(int val) //parameterized cons
        {
            this.val = val;
            Console.WriteLine("Param Cons");
        }

        public AllAboutConstructor(AllAboutConstructor obj) //copy cons
        {
            this.val=obj.val;
            Console.WriteLine("Copy Cons");
        }

        static AllAboutConstructor()//static cons must be parameterless (only called once) and default cons is provided with static cons if class conatains only static cons
        {
            id++;
            Console.WriteLine("Static Cons" + "\n" + "Id value : " + id);
        }

        //static method

        public static void Display()
        {
            id++;
            Console.WriteLine("In Static Method Id value : " + id);
        }
    }
}   
