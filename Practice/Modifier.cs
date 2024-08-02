namespace modifier_example
{

    // Public 
    public class PublicModifier
    {
        public string Name { get; set; }

        public void GiveMeATea()
        {
            Console.WriteLine("Here is your tea!");
        }
    }

    // Private
    public class PrivateModifier
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }


    // Protected
    public class ProtectedModifierParent
    {
        protected void PrintHello()
        {
            Console.WriteLine("Hellloooooooooooo!!");
        }
    }

    public class ProtectedModifierChild : ProtectedModifierParent
    {
        public void Hii()
        {
            Console.WriteLine("Hii!");
            PrintHello();
        }
    }

    // Internal

    internal class Car
    {
        internal void Drive() 
        {
            Console.WriteLine("Driving the car");
        }
    }
}
