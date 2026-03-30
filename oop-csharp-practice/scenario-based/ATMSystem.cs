using System;

interface IATMService {
    void Withdraw(int amount);
}

abstract class ATMBase {
    protected readonly int[] denominations;

    protected ATMBase(int[] denominations) {
        this.denominations = new int[denominations.Length];
        for(int i = 0; i < denominations.Length; i++) {
            this.denominations[i] = denominations[i];
        }
    }

    protected bool TryDispenceExactAmount(int amount, out int[] noteCount) {
        noteCount = new int[denominations.Length];
        int remainingAmount = amount;

        for(int i = 0; i < denominations.Length; i++) {
            noteCount[i] = remainingAmount / denominations[i];
            remainingAmount = remainingAmount % denominations[i];
        }

        return remainingAmount == 0;
    }
}

class SecureATM : ATMBase, IATMService {
    public SecureATM(int[] denominations) : base(denominations) {
    }

    public void Withdraw(int amount) {
        int[] noteCount;
        if (TryDispenceExactAmount(amount, out noteCount)) {
            displayResult("Dispensed Rs." + amount, amount, noteCount);
        } else {
            Console.WriteLine("Cannot dispense exact amount.");
        }
    }

    private void displayResult(string title, int amount, int[] noteCount) {
        Console.WriteLine();
        Console.WriteLine(title);

        int totalNotes = 0;
        for (int i = 0; i < denominations.Length; i++) {
            if (noteCount[i] > 0) {
                Console.WriteLine("Rs." + denominations[i] + " x " + noteCount[i]);
                totalNotes += noteCount[i];
            }
        }
        Console.WriteLine("Total notes: " + totalNotes);
    }
}

class ATMSystem {
    static void Main(string[] args) {
        Console.WriteLine("=== Simple ATM Dispenser ===");
        
        Console.WriteLine("1: Full notes including 500");
        Console.WriteLine("2: Without 500 note");
        Console.Write("Choose (1/2): ");
        int choice = int.Parse(Console.ReadLine());

        int[] denominationsA = {500, 200, 100, 50, 20, 10, 5, 2, 1};
        int[] denominationsB = {200, 100, 50, 20, 10, 5, 2, 1};
        int[] denominations = choice == 1 ? denominationsA : denominationsB;

        IATMService atm = new SecureATM(denominations);

        Console.Write("Enter amount like 1080: ");
        int amount = int.Parse(Console.ReadLine());
        atm.Withdraw(amount);
    }
}
