public class LoopsAndConditionalStatements
{
    public static void LoopAndIfElse()
    {
        int day = 3;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Another day");
                break;
        }


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("For count " + i);
        }


        int[] fruits = { 1, 2, 2 };

        foreach (int fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("Hi I am Dheeraj");
    }
}