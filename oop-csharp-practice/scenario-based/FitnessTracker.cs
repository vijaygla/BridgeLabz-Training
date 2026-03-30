using System;

// interface for some method
interface ITrackable {
    void StartWorkout();
    void EndWorkout();
    int CalculateCalories();
}

// abstract base class
abstract class Workout : ITrackable {
    protected string workoutName;
    protected int duration;

    public Workout(string workoutName, int duration) {
        this.workoutName = workoutName;
        this.duration = duration;
    }

    public abstract int CalculateCalories();

    public virtual void StartWorkout() {
        Console.WriteLine(workoutName + " started");
    }

    public virtual void EndWorkout() {
        Console.WriteLine(workoutName + " ended");
    }
}

// cardio workout
class CardioWorkout : Workout {
    public CardioWorkout(int duration) : base("Cardio", duration) {

    }
    // override this calculateCalories method
    public override int CalculateCalories() {
        return duration * 8;
    }
}

class StrengthWorkout : Workout {
    public StrengthWorkout(int duration) : base("Bulking", duration) {

    }
    // override this calculatecCalories method
    public override int CalculateCalories() {
        return duration * 6;
    }
}

// user profile
class UserProfile {
    private string userName;

    public UserProfile(string userName) {
        this.userName = userName;
    }

    public void PerformWorkout(Workout workout) {
        Console.WriteLine("UserName: " + userName);

        workout.StartWorkout();
        int burnedCalories = workout.CalculateCalories();
        workout.EndWorkout();

        Console.WriteLine("Burned calories: " + burnedCalories);
    }
}

// main method
class FitnessTracker {
    static void Main(String[] args) {
        UserProfile userName1 = new UserProfile("vijay");
        UserProfile userName2 = new UserProfile("sagar");

        Workout cardio = new CardioWorkout(60);
        Workout strength = new StrengthWorkout(60);

        userName1.PerformWorkout(cardio);
        Console.Write("---------------------\n");
        userName2.PerformWorkout(strength);
    }
}
