using System;

// Interface for controlling appliances
public interface IControllable {
    void TurnOn();
    void TurnOff();
}

// abstract base class for the emplement all the controllable intrface method
public abstract class Appliance : IControllable {
    protected string name;

    public Appliance(string name) {
        this.name = name;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
}


// light appliance 
class Light : Appliance {
    public Light(string name) : base(name) {}

    public override void TurnOn() {
        Console.WriteLine("Light is On");
    }

    public override void TurnOff() {
        Console.WriteLine("Light is Off");
    }
}

// fan appliance
class Fan : Appliance {
    public Fan(string name) : base(name) {}

    public override void TurnOn() {
        Console.WriteLine("Fan is On");
    }

    public override void TurnOff() {
        Console.WriteLine("Fan is Off");
    }
}

// ac appliance
class AC : Appliance {
    public AC(string name) : base(name) {}

    public override void TurnOn() {
        Console.WriteLine("AC is On");
    }

    public override void TurnOff() {
        Console.WriteLine("AC is Off");
    }
}

// main class contain main method
class HomeAutomationSystem {
    static void Main(String[] args) {
        Appliance[] appliances = {
            new Light("Living Room"), 
            new Fan("Bed Room"), 
            new AC("Office")
        };

        Console.WriteLine("=== Turning ON all application===");
        foreach(Appliance a in appliances) {
            a.TurnOn(); // polymorphism
        }

        Console.WriteLine("=== Turning OFF all application===");
        foreach(Appliance a in appliances) {
            a.TurnOff(); // polymorphism
        }
    }
}
