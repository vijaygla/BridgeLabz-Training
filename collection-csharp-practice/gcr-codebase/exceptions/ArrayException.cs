using System;

class ArrayException
{
    static void Main()
    {
        try
        {
            int[] arr = {10, 20, 30};
            Console.Write("Enter index : ");
            int index = Convert.ToInt32(Console.ReadLine());

            // Access array element
            Console.WriteLine("Value at index " + index + " : " + arr[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialised");
        }
    }
}
