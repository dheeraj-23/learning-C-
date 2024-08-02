namespace Polymorphism
{
    public class LoadParent
    {
        public void Show() // overloadable
        {
            Console.WriteLine("Parent's show method is called");
        }

        public virtual void Test() // overridable
        {
            Console.WriteLine("Parent's test method is called");
        }
    }

    public class LoadChild : LoadParent
    {
        public void Show(int i) // overloading
        {
            Console.WriteLine("Child's show method is called");
        }

        public override void Test() // overriding
        {
            Console.WriteLine("Child's test method is called");
        }

    }
}
