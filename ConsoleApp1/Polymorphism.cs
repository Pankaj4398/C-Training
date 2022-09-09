using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    abstract class Base
    {
        public abstract void read();
    }

    class Derieved : Base
    {
        public override void read()
        {
            throw new NotImplementedException();
        }
    }

    class Polymorphism
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig(); 
            Animal myDog = new Dog(); 

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();


            Base b = new Derieved();
            try
            {
                b.read();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /* 
         * If we don't add virtual and override keyword then the base class method overrides the derived class method, when they share the same name.
         * However, C# provides an option to override the base class method, 
         * by adding the virtual keyword to the method inside the base class, and by using the override keyword for each derived class methods*/


        //Dynamic polymorphism is implemented by abstract classes and virtual functions.
    }
}
