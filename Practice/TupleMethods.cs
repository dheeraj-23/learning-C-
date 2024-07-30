public class TupleMethods
{
    public static void Methods()
    {
        // Creating reference Tuple
        var person = Tuple.Create("John", 30, true, false);
        Console.WriteLine(person);
        // or creating ValueTuple
        (string Name, int Age) person1 = ("Dheeraj", 25);
        Console.WriteLine(person1);

        // Accessing Tuple Elements
        Console.WriteLine(person.Item1 + " age is " + person1.Item2 + " and is a developer " + person.Item3 + " he is working from home " + person.Item4);

        // Deconstructing a Tuple
        var (item1, item2, item3, item4) = person;
        Console.WriteLine(item1 + item2 + item3 + item4);

        // Comparing Tuples
        var person2 = Tuple.Create("Dheeraj", 25); // type - reference tuple
        bool areEqual = person1.Equals(person2);
        Console.WriteLine(areEqual); // false because types are different valueTuple !== Tuple


        // Using Tuple as a Method Return
        (string, int) GetPerson()
        {
            return ("John", 30);
        }

        var result = GetPerson();
        Console.WriteLine($"{result.Item1} is {result.Item2} years old");
    }
}