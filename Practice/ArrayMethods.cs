public class ArrayMethods
{
    public static void Methods()
    {
        //ForEach Method
        int[] numbers1 = { 1, 2, 3, 4, 5 };
        Array.ForEach(numbers1, n => Console.WriteLine(n));


        //Reverse Method
        int[] numbers2 = { 1, 2, 3, 4, 5 };
        Array.Reverse(numbers2);
        // numbers is now { 5, 4, 3, 2, 1 }


        // Sort Method
        int[] numbers3 = { 3, 1, 4, 1, 5, 9, 2 };
        Array.Sort(numbers3);
        // numbers is now { 1, 1, 2, 3, 4, 5, 9 }


        // Clear Method
        int[] number4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Array.Clear(number4, 1,3);
        foreach (int i in number4)
        {
            Console.WriteLine($"checking count {i}");
        }
        Console.WriteLine("ber4.Count()  "+number4.Count());


        // Exists Method
        int[] number5 = { 1,2,3,5,7,9 };
        bool hasEven = Array.Exists(number5, num => num % 2 == 0);
        Console.WriteLine(hasEven); // true


        // Find
        int[] number6 = { 1, 2, 3, 4, 5, 6 };
        int firstEven = Array.Find(number6, num => num % 2 == 0);
        Console.WriteLine(firstEven); // 2


        // FindAll
        int[] number7 = { 1, 2, 3, 4, 5 };
        int[] evenNumbers = Array.FindAll(number7, n => n % 2 == 0);
        // evenNumbers is { 2, 4 }
        Console.WriteLine(evenNumbers.Count()); // 2

        foreach (int i in evenNumbers) {

            Console.WriteLine($"Findall elements - {i}");
        }


        // IndexOf and LastIndexOf
        int[] number8 = { 1, 3, 2, 4, 1, 3, 2, 5, 7 };
        int firstIndex = Array.IndexOf(number8, 3); // will return index of first occurrence
        int lastindex = Array.LastIndexOf(number8, 3); // will return index of last occurrence
        Console.WriteLine(firstIndex);
        Console.WriteLine(lastindex);


        // BinarySearch Method
        int[] numbers = { 1, 3, 5, 7, 9 };
        int binarySearchIndex = Array.BinarySearch(numbers, 7);
        Console.WriteLine(binarySearchIndex); // index is 3
    }
}