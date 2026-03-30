using System;

class ArrayIndexOutOfRange
{
    static void Main()
    {
        try
        {
            int[] arr = { 1, 2, 3 };
            int value = arr[5]; // invalid index
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Array IndexOutOfRangeException caught");
            Console.WriteLine(e.Message);
        }
    }
}
