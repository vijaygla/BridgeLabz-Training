using System;

class TableSixToNine {
    static void Main(String[] args) {
        Console.Write("Enter any nunber: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int[] result = new int[4];

        // intilise the idx from the zero
        int idx = 0;
        for (int i = 6; i <= 9; i++) {
            result[idx] = num * i;
            Console.WriteLine(num + " * " + i + " = " + result[idx]);
            idx++;
        }
    }
}
