using System;

class MeanHeight {
    static void Main(String[] args) {
        // as given total 11 footbal player
        double[] heights =  new double[11];
        double sum = 0;

        for(int i=0; i<11; i++) {
            Console.Write("Enter " + (i + 1) + " player height : ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
        }

        double mean = sum / 11;
        Console.WriteLine("Mean : " + mean);
    }
}
