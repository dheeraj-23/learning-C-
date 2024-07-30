public class DataTypes
{
    public static void PrimitiveAndNonprimitive()
    {
        int myNumber = 10; //represents whole number without decimal
        Console.WriteLine(myNumber);

        if (myNumber == 10)
        {
            Console.WriteLine("If condition satisfied");
        }
        else if (myNumber == 20)
        {
            Console.WriteLine("Else If condition satisfied");
        }
        else
        {
            Console.WriteLine("It's in else condition now");
        }

        float myFloat = 244.123456789F; //represents single-precision floating point number, can store fraction number with upto 7 digits of precision.
        Console.WriteLine(myFloat);

        double myDouble = 12.123451234512345;
        Console.WriteLine(myDouble);

        decimal myDecimal = 123456789123456789.123456789123M;
        Console.WriteLine(myDecimal);

        char myChar = 'A';
        Console.WriteLine(myChar);

        string myString = "Hello, World!";
        myString = "Hello, Bangalore";
        Console.WriteLine(myString);

        Boolean myBoolean = true;
        Console.WriteLine(myBoolean);

        byte myByte = 255; // 8-bit (0-255)
        Console.WriteLine(myByte);

        sbyte mySByte = 127; // 8-bit (-128-127)
        Console.WriteLine(mySByte);

        short myShort = 32767; // (-32,768 to 32,767).
        Console.WriteLine(myShort);

        ushort myUShort = 65535; // (0-65535)
        Console.WriteLine(myUShort);

        long myLong = 9223372036854775807; // 19 digits 64-bit integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807).
        Console.WriteLine(myLong);

        ulong myULong = 18446744073709551615; // 20 digits 64-bit unsigned integer (0 to 18,446,744,073,709,551,615).
        Console.WriteLine(myULong);

        object myObject = "Hello, World!"; // The base type from which all other types in C# inherit. It can store any type of value.
        Console.WriteLine(myObject);

        dynamic myDynamic = 1; // Represents a type that bypasses compile-time type checking. It resolves type at runtime.
        Console.WriteLine(myDynamic);
        myDynamic = "Now I'm a string";
        Console.WriteLine(myDynamic);


        // Like unknown, Represents a type that is inferred at compile-time based on the assigned value. It must be initialized at the time of declaration.
        var myVar = "Hello, World!"; 
        Console.WriteLine(myVar);



        // Non-Primitive Types

        int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };

        int[] MySecondArray = myIntArray;

        foreach (int i in MySecondArray)
        {
            Console.WriteLine("array number is: " + $"{i} and length of array is {myIntArray.Length}");
        }


        List<int> myList = new List<int>() { 19, 18, 17, 16, 15 };
        foreach (int i in myList)
        {
            Console.WriteLine("List number is: " + $"{i} and length of lsit is {myList.Count}");
        }

        Dictionary<string, int> myDict = new Dictionary<string, int>()
        {
            {"num1", 25},
            {"num2", 30},
            {"num3", 39},
            {"num4", 40}
        };

        foreach (KeyValuePair<string, int> kvp in myDict)
        {
            Console.WriteLine($"the key is: {kvp.Key}, value is: {kvp.Value}");
        }

        (string, int) myTuple = ("secret number", 1999);


        Console.WriteLine("tupleeeeeee" + myTuple);


    }
}