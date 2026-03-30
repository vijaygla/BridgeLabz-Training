using System;

// base product
abstract class Product
{
    public double Price {get; set; }
}

// categries
class BookCategory : Product { }
class ClothingCategory : Product { }

// Generic discount utility
class DiscountService
{
    public static void ApplyDiscout<T>(T product, double percentage) where T : Product
    {
        product.Price -= product.Price * percentage / 100;
    }
}

class Program
{
    static void Main()
    {
        BookCategory book = new BookCategory {Price = 500};
        Console.WriteLine($"Price before discout : {book.Price}");
        DiscountService.ApplyDiscout(book, 10);
        Console.WriteLine($"Price after discount : {book.Price}");
    }
}
