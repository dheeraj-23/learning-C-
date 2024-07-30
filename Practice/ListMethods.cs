public class ListMethods
{
    public static void Methods()
    {
        // Add
        List<int> myList1 = new List<int>() { 1, 4, 6 ,9, 5 ,10, 2 };
        myList1.Add(100);
        foreach (int i in myList1)
        {
            Console.WriteLine($"this is array elements - {i}");
        }

        // AddRange
        List<int> myList2 = new List<int>() { 1, 2, 3, 4 };
        myList2.AddRange(new int[] { 11, 4, 13 });

        foreach (int i in myList2)
        {
            Console.WriteLine($"checking the range - {i}");
        }

        // Clear
        List<string> myStrList = new List<string>() { "str1", "str2", "str3" };
        myStrList.Clear();
        myStrList.Add("str10");
        Console.WriteLine($"myStrList.Count === {myStrList.Count}"); // Count

        // Contains
        bool checkingOccurance = myStrList.Contains("str10");
        Console.WriteLine(checkingOccurance);

        // IndexOf of first occurance
        int indexOf = myList2.IndexOf(4);
        Console.WriteLine($"Index of the element -- {indexOf}");

        // LastIndexOf
        int lastIndexOf = myList2.LastIndexOf(4);
        Console.WriteLine($"Last Index of the element -- {lastIndexOf}");

        // Insert
        myStrList.Insert(0, "str100");
        foreach(string i in myStrList)
        {
            Console.WriteLine($"string list after inserting -- {i}");
        }

        // Removes the first occurrence of a specific element
        bool removeElement = myStrList.Remove("str100");
            Console.WriteLine($"First occurence item removed! {removeElement}");
  
        // Removes the element at the specified index
        myStrList.RemoveAt(0);
        Console.WriteLine($"After using RemoveAt, length of myStrList is - {myStrList.Count}");

        // Sort
        myList1.Sort();
        int myList1Count = myList1.Count();
        Console.WriteLine(myList1Count);
        foreach(int i in myList1)
        {
            Console.WriteLine($"my list 1 sorted elements are - {i}");
        }

        int[] myList1Array = myList1.ToArray();
        foreach(int i in myList1Array)
        {
            Console.WriteLine($"My List 1 array elements are - {i}");
        }


        Console.WriteLine($"count of myList2 is - {myList2.Count}");
        myList2.ForEach(n => Console.WriteLine($"using ForEach in list -- {n}"));

    }
}