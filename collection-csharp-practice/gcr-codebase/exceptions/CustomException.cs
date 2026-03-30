using System;
using System.IO;

// custom exception class
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class CustomException
{
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be 18 or above");
        }
    }
    // main method
    static void Main(String[] args)
    {
        try
        {
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            ValidateAge(age);
            Console.WriteLine("Access granted");
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
