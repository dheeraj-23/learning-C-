namespace Practice
{
    public class Generic
    {
        public static void displayElements<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
