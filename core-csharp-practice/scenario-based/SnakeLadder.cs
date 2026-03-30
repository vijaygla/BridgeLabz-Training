// // program to create console app snake and ladder

// using System;

// class SnakeLadder {
//     static Random r = new Random();

//     static void Main(string[] args) {
//         Console.Write("Enter no. of players: ");
//         int numberOfPlayer = int.Parse(Console.ReadLine());

//         int[] positions = new int[numberOfPlayer];
//         bool gameOver = false;

//         while (!gameOver) {
//             for (int i = 0; i < numberOfPlayer; i++) {
//                 Console.Write("Player " + (i + 1) + " turn (press Enter): ");
//                 Console.ReadLine();

//                 int diceValue = RollDice();
//                 Console.WriteLine("Dice value = " + diceValue);

//                 if (positions[i] + diceValue <= 100)
//                     positions[i] += diceValue;

//                 if (positions[i] == 100) {
//                     Console.WriteLine("Result:>>> Player " + (i + 1) + " Winner");
//                     gameOver = true;
//                     break;
//                 }

//                 positions[i] = snakeMoveMethod(positions[i]);
//                 positions[i] = ladderMoveMethod(positions[i]);

//                 Console.WriteLine("Player " + (i + 1) + " score = " + positions[i]);
//                 Console.WriteLine();
//             }
//         }
//     }

//     public static int RollDice() {
//         return r.Next(1, 7);
//     }

//     public static int snakeMoveMethod(int position) {
//         switch (position) {
//             case 99: return 6;
//             case 97: return 84;
//             case 95: return 71;
//             case 76: return 28;
//             case 38: return 7;
//             default: return position;
//         }
//     }

//     public static int ladderMoveMethod(int position) {
//         switch (position) {
//             case 11: return 56;
//             case 17: return 43;
//             case 31: return 51;
//             case 68: return 87;
//             case 75: return 95;
//             default: return position;
//         }
//     }
// }

using System;

class SnakeLadder
{
    private const int BOARD_SIZE = 100;

    private readonly int[] snakeStart = { 99, 97, 95, 76, 38 };
    private readonly int[] snakeEnd   = { 6, 84, 71, 28, 7 };

    private readonly int[] ladderStart = { 11, 17, 31, 68, 75 };
    private readonly int[] ladderEnd   = { 56, 43, 51, 87, 95 };

    private Random r = new Random();

    static void Main(string[] args)
    {
        SnakeLadder game = new SnakeLadder();
        game.StartGame();
    }

    private void StartGame()
    {
        Console.Write("Enter no. of players: ");
        int numberOfPlayer = int.Parse(Console.ReadLine());

        int[] positions = new int[numberOfPlayer];
        bool gameOver = false;

        while (!gameOver)
        {
            for (int i = 0; i < numberOfPlayer; i++)
            {
                Console.Write("Player " + (i + 1) + " turn (press Enter): ");
                Console.ReadLine();

                int diceValue = RollDice();
                Console.WriteLine("Dice value = " + diceValue);

                if (positions[i] + diceValue <= BOARD_SIZE)
                    positions[i] += diceValue;

                if (positions[i] == BOARD_SIZE)
                {
                    Console.WriteLine("Result:>>> Player " + (i + 1) + " Winner");
                    return;
                }

                positions[i] = CheckSnake(positions[i]);
                positions[i] = CheckLadder(positions[i]);

                Console.WriteLine("Player " + (i + 1) + " score = " + positions[i]);
                Console.WriteLine();
            }
        }
    }

    private int RollDice()
    {
        return r.Next(1, 7);
    }

    private int CheckSnake(int position)
    {
        for (int i = 0; i < snakeStart.Length; i++)
        {
            if (position == snakeStart[i])
                return snakeEnd[i];
        }
        return position;
    }

    int CheckLadder(int position)
    {
        for (int i = 0; i < ladderStart.Length; i++)
        {
            if (position == ladderStart[i])
                return ladderEnd[i];
        }
        return position;
    }
}
