using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class FirstClass
    {
        public string myField = String.Empty; //field

        public FirstClass() //instance constructor
        {
        }

        public void MyMethod(int parameter1, string parameter2)  //instance method
        {
            Console.WriteLine("First Parameter {0}, second parameter {1}",
                                                        parameter1, parameter2);
        }

        public int MyAutoImplementedProperty { get; set; } //autoimplemented property simple get set

        private int myPropertyVar; //property  

        public int MyProperty //can add logic in get and set
        {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
        }

        /*static void Main(string[] args)
        {
            FirstClass test = new FirstClass();
            Console.WriteLine(test.myField);
            Console.WriteLine(test.MyAutoImplementedProperty);
            test.MyAutoImplementedProperty = 5;
            Console.WriteLine(test.MyAutoImplementedProperty);
            test.MyProperty = 20;
            Console.WriteLine(test.MyProperty);
            Console.ReadKey();

        }*/
    }
}
