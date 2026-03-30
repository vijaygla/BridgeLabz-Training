using System;

// Interface
interface IMealPlan
{
    string GetMeal();
}

// Implementations
class VegetarianMeal : IMealPlan
{
    public string GetMeal() => "Vegetarian Meal";
}

class VeganMeal : IMealPlan
{
    public string GetMeal() => "Vegan Meal";
}

// Generic meal generator
class Meal<T> where T : IMealPlan, new()
{
    public void Generate()
    {
        T meal = new T();
        Console.WriteLine(meal.GetMeal());
    }
}

class Program
{
    static void Main()
    {
        Meal<VegetarianMeal> meal = new Meal<VegetarianMeal>();
        meal.Generate();
    }
}
