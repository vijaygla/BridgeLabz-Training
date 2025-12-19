using System;

class FeeDiscount
{
    static void Main()
    {
        double fee = 125000;
        double dPercent = 10;

        double discount = (fee * dPercent) / 100;
        double finalFee = fee - discount;

        Console.WriteLine(
            "The discount amount is INR "
                + discount
                + " and final discounted fee is INR "
                + finalFee
        );
    }
}
