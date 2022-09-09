namespace OOPs{ 
    public class MyClass
    {
        /*any access modifier*/ static void Main(string[] args)
        {
            Console.WriteLine("-----FIRST CLASS-----");
            FirstClass test = new FirstClass();
            Console.WriteLine(test.myField);
            Console.WriteLine(test.MyAutoImplementedProperty);
            test.MyAutoImplementedProperty = 5;
            Console.WriteLine(test.MyAutoImplementedProperty);
            test.MyProperty = 20;
            Console.WriteLine(test.MyProperty);


            Console.WriteLine("-----ALL ABOUT CONSTRUCTOR-----");
            AllAboutConstructor.Display();
            AllAboutConstructor test4 = new AllAboutConstructor();
            AllAboutConstructor obj = new AllAboutConstructor(10);
            AllAboutConstructor obj2 = obj;
            Console.WriteLine("Reference of obj and obj2 is same : " + (obj == obj2) + " their value is same : " + (obj.val == obj2.val));
            AllAboutConstructor obj3 = new AllAboutConstructor(obj);
            Console.WriteLine("Reference of obj and obj3 is same : " + (obj == obj3) + " their value is same : " + (obj.val == obj3.val)); ;

            Console.WriteLine("-----ALL ABOUT STATIC-----");
            /*The static constructor is called only once whenever the static method is used or creating an instance for the first time.*/
            var result = AllAboutStatic.Sum(10, 25); // calling static method
            Console.WriteLine(result);
            Console.WriteLine(result.GetType());
            Console.WriteLine(result.ToString());

            AllAboutStatic.ResultStore= 50;
            Console.WriteLine(AllAboutStatic.ResultStore);


            var calcType = AllAboutStatic.Type; // accessing static variable
            AllAboutStatic.Type = "Scientific"; // assign value to static variable
            Console.WriteLine(calcType);


            NonStaticClass test2 = new NonStaticClass();
            NonStaticClass test3 = new NonStaticClass();

            Console.WriteLine("-----ALL ABOUT INHERITANCE-----");
            Inheritance inhert = new Inheritance(10,20,30,40);
            


            Console.ReadKey();
        }
    }
}