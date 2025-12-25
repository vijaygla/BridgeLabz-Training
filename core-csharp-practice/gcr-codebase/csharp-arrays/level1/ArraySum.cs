using System;

class ArraySum {
    static void Main(String[] args) {
        Console.Write("Enter any number: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;

        for(int i=0; i<arr.Length; i++) {
            Console.Write("Enter element of arr: ");
            arr[i] = int.Parse(Console.ReadLine());

            sum += arr[i];
        }
        Console.WriteLine("Sum of all element of an array : " + sum);
    }
}
