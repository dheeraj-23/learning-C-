public class DictionaryMethods
{
    public static void Methods()
    {
        Dictionary<string, int> carSpeed = new Dictionary<string, int>()
        {
            {"Audi Q8", 250},
            {"Land Rover Discovery", 200 },
            {"Nissan GTR", 340 },
            {"Lamborghini Huracan", 280 }
        };

        // clear method will remove everything from dictionary
        carSpeed.Clear();

        // add will add new key value pair in dictionary
        carSpeed.Add("Porsche 911", 260);
        carSpeed.Add("Porsche 911 convertable", 260);

        // Remove method will remove key value by taking key
        //carSpeed.Remove("Porsche 911");

        // ContainsKey will check for the key and return boolean
        bool carSpeedContains = carSpeed.ContainsKey("Porsche 911");
        Console.WriteLine(carSpeedContains);

        // ContainsValue will check for the value and return boolean
        bool carSpeedContainsValue = carSpeed.ContainsValue(260);
        Console.WriteLine(carSpeedContainsValue);

        // TryGetValue 
        if (carSpeed.TryGetValue("Porsche 911 convertable", out int speedOfCar)){
            Console.WriteLine($"Yes, this car can go upto {speedOfCar}kmph");
        }

        // 
        ICollection<string> keys = carSpeed.Keys;
        ICollection<int> values = carSpeed.Values;

        Console.WriteLine($"keys are --- "+ string.Join(", ", keys));
        Console.WriteLine($"values are --- "+ string.Join(", ", values));

   
        // KeyValuePair
        foreach (KeyValuePair<string, int> kVP in carSpeed) {
            Console.WriteLine(kVP.Key + " : " + kVP.Value );
        }


        // Indexer
        int indexOfKey = carSpeed["Porsche 911"]; // throws error when key is not present in the dictionary
        Console.WriteLine(indexOfKey);


        // Count propert
        int countOfDictionary = carSpeed.Count;
        Console.WriteLine(countOfDictionary);

        List<int> myList = new List<int>() { 1,2,3,4,5,6,7,8,9};
        int lengthOfList = myList.Count;
        Console.WriteLine("Lengthhhhhh --- "+lengthOfList);
        for (int i = 0; i < lengthOfList; i++) {
            Console.WriteLine($"Inside for loop - index is: {i}");
        }

    }
}