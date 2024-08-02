using Practice;
using PracticeLINQ;

delegate void Calculator(int a, int b);

class ProgramOverridng
{
    static void Main(string[] args)
    {
        //// Instance Methods
        //Person person = new Person();
        //person.Name = "Dheeraj";
        //person.SayHello();

        //// Static Methods
        //Animal.PrintGreeting();

        //// Abstract Methods
        //Rectange r = new Rectange(12.67, 56.78);
        //Circle c = new Circle(45.67);
        //Cone cn = new Cone(34.98, 12.98);
        //Console.WriteLine("Area of rectangle: " + r.getArea());  
        //Console.WriteLine("Area of circle: " + c.getArea());  
        //Console.WriteLine("Area of cone: " + cn.getArea());

        //// Virtual Methods
        //Dog dog = new Dog();
        //dog.MakeSound();
        //Cat cat = new Cat();
        //cat.MakeSound();
        //Cattle cow = new Cattle();
        //cow.MakeSound();
        //Ox ox = new Ox();
        //ox.MakeSound();

        //// Polymorphism
        //LoadChild c = new LoadChild();
        //c.Show();
        //c.Test();
        //c.Show(10);

        // encapsulation
        //Encapsulation emp = new Encapsulation();
        //emp.EmpExp = -10;
        //emp.GetExperience();


        //// Public Access Modifier
        //PublicModifier con = new PublicModifier();
        //con.Name = "Dheeraj";
        //con.GiveMeATea();

        //// Private Access Modifier
        //PrivateModifier privateInit = new PrivateModifier();
        //privateInit.SetName("John");
        ////privateInit.name = "Test"; // not accessable
        //var name = privateInit.GetName();
        //Console.WriteLine(name);

        //// Protected 
        //ProtectedModifierChild greet = new ProtectedModifierChild();
        //greet.Hii();

        // Delegate - A Delegate is dependent on function and connot be created without function
        // 1st way
        //Calculator calc = new Calculator(Delecate.Add);
        //calc += Delecate.Multi;
        //calc(20, 30);

        // 2nd way - Anonymous method
        //Calculator CalcAdd = delegate(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //};
        //CalcAdd(20, 30);


        ////Events - An event is dependent on delegate and cannot be created without delegate
        //Notifier notifier = new Notifier();
        //notifier.Notify += Notifier.DisplayMessage;
        //notifier.SendNotification("Event Handling in C#");


        //// Generic
        //int[] intArray = { 1, 2, 3, 4, 5 };
        //double[] doubleArray = { 1.2, 3.4, 6.5, 4.6, 9.9 };
        //string[] stringArray = { "qwe", "fds", "rew", "pub", "sub" };
        //Generic.displayElements(intArray);
        //Generic.displayElements(doubleArray);
        //Generic.displayElements(stringArray);



        //// Lambda
        //List<Person> people = new List<Person>
        //{
        //    new Person {Name = "John", Age = 25},
        //    new Person {Name = "Rony", Age = 18},
        //    new Person {Name = "Max", Age = 20},
        //    new Person {Name = "Jean", Age = 30},
        //    new Person {Name = "Edan", Age = 10}
        //};
        //var sortByAge = people.OrderBy(p => p.Age);
        //foreach (var person in sortByAge) 
        //{
        //    Console.Write(person.Name + " : " + person.Age);
        //    Console.WriteLine();
        //}


        //// LINQ
        //LINQ linq = new LINQ();
        ////linq.QuerySyntax();
        //linq.JoinQuery();

        Console.ReadLine();
    }
}