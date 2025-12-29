// program to create console app snake and ladder

using System;

class SnakeLadder {
    static Random r = new Random();

    static void Main(string[] args) {
        Console.Write("Enter no. of players: ");
        int numberOfPlayer = int.Parse(Console.ReadLine());

        int[] positions = new int[numberOfPlayer];
        bool gameOver = false;

        while (!gameOver) {
            for (int i = 0; i < numberOfPlayer; i++) {
                Console.Write("Player " + (i + 1) + " turn (press Enter): ");
                Console.ReadLine();

                int diceValue = RollDice();
                Console.WriteLine("Dice value = " + diceValue);

                if (positions[i] + diceValue <= 100)
                    positions[i] += diceValue;

                if (positions[i] == 100) {
                    Console.WriteLine("Result:>>> Player " + (i + 1) + " Winner");
                    gameOver = true;
                    break;
                }

                positions[i] = snakeMoveMethod(positions[i]);
                positions[i] = ladderMoveMethod(positions[i]);

                Console.WriteLine("Player " + (i + 1) + " score = " + positions[i]);
                Console.WriteLine();
            }
        }
    }

    public static int RollDice() {
        return r.Next(1, 7);
    }

    public static int snakeMoveMethod(int position) {
        switch (position) {
            case 99: return 6;
            case 97: return 84;
            case 95: return 71;
            case 76: return 28;
            case 38: return 7;
            default: return position;
        }
    }

    public static int ladderMoveMethod(int position) {
        switch (position) {
            case 11: return 56;
            case 17: return 43;
            case 31: return 51;
            case 68: return 87;
            case 75: return 95;
            default: return position;
        }
    }
}
