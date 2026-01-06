using System;

// Base class (Abstraction + Encapsulation)
class Bird
{
    protected string name;
    protected string species;
    protected int age;

    public Bird(string name, string species, int age)
    {
        this.name = name;
        this.species = species;
        this.age = age;
    }

    // Correct Display method
    public virtual void Display()
    {
        Console.WriteLine("Name    : " + name);
        Console.WriteLine("Species : " + species);
        Console.WriteLine("Age     : " + age);
    }
}

interface IFlyable
{
    void Fly();
}

interface ISwimable
{
    void Swim();
}

class Eagle : Bird, IFlyable
{
    bool isFly;
    bool isSwim;

    public Eagle(string name, string species, int age, bool isFly, bool isSwim)
        : base(name, species, age)
    {
        this.isFly = isFly;
        this.isSwim = isSwim;
    }

    public void Fly()
    {
        Console.WriteLine(name + " can fly");
    }
}

class Penguin : Bird, ISwimable
{
    bool isFly;
    bool isSwim;

    public Penguin(string name, string species, int age, bool isFly, bool isSwim)
        : base(name, species, age)
    {
        this.isFly = isFly;
        this.isSwim = isSwim;
    }

    public void Swim()
    {
        Console.WriteLine(name + " can swim");
    }
}

class Seagull : Bird, IFlyable, ISwimable
{
    bool isFly;
    bool isSwim;

    public Seagull(string name, string species, int age, bool isFly, bool isSwim)
        : base(name, species, age)
    {
        this.isFly = isFly;
        this.isSwim = isSwim;
    }

    public void Fly()
    {
        Console.WriteLine(name + " can fly");
    }

    public void Swim()
    {
        Console.WriteLine(name + " can swim");
    }
}

class BirdBase
{
    static void Main(string[] args)
    {
        Bird[] arr = new Bird[3];

        arr[0] = new Eagle("Rocky", "Eagle", 5, true, false);
        arr[1] = new Penguin("Pingo", "Penguin", 3, false, true);
        arr[2] = new Seagull("Sky", "Seagull", 4, true, true);

        foreach (Bird b in arr)
        {
            b.Display();

            if (b is IFlyable) {
                ((IFlyable)b).Fly();
            }
            if (b is ISwimable) {
                ((ISwimable)b).Swim();
            }
            Console.WriteLine("-----------------");
        }
    }
}
