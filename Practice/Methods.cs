//namespace method
//{
//    public class Person
//    {
//        public string Name { get; set; }
//        private string FirstName;
//        public Person(string LastName)
//        {
//            FirstName = LastName;
//        }
//        public void Introduction()
//        {
//            Console.WriteLine($"Hello, I'm {FirstName}");
//        }
//    }

//    public class Child
//    {
//        public Person dummy;
//        public Child()
//        {
//            dummy = new Person("Deepan");
//            dummy.Introduction();
//        }
//    }
//    public class Person2
//    {
//        static void Main(string[] args)
//        {
//            Child child = new Child();
//        }
//    }
//}


namespace MethodsExample
{
    public class Person
    {
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
    }

    static class Animal
    {
        public static void PrintGreeting()
        {
            Console.WriteLine("Hello from a static method.");
        }
    }
}