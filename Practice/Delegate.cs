namespace Practice
{
    public delegate void Calculator(int a, int b);


   public static class Delecate
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Multi(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
    //public delegate int AddDelegate(int x, int y);
    //public delegate string SayDelegate(string s);

    //class Parent
    //{
    //    public int AddNums(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public static string SayHello(string name)
    //    {
    //        return "Hello " + name;
    //    }
    //}

    //class Program 
    //{
    //    static void Mains(string[] args)
    //    {
    //        Parent p = new Parent();
    //        AddDelegate ad = new AddDelegate(p.AddNums);
    //        int num = ad.Invoke(100, 50);
    //        Console.WriteLine(num);


    //        SayDelegate sd = new SayDelegate(Parent.SayHello);
    //        string str = sd.Invoke("Sharath");
    //        Console.WriteLine(str);

    //    }

    //}



}
