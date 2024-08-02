public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog: Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat: Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}


public class Cattle : Animal
{
    public sealed override void MakeSound()
    {
        Console.WriteLine("Moooowwww!");
    }
}

public class Ox : Cattle
{
    //public override void MakeSound() // example to show we cannot override method with are sealed being derieved from base class
    //{
    //    Console.WriteLine("Moowwwwwww! shh shh");
    //}
}