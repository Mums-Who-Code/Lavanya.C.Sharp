
using System.Collections.Generic;

Random random = new Random();
int playerOne = 0;
int playerTwo = 0;
double playerOneTotal = 0;
double playerTwoTotal = 0;

for (int i = 0; i < 5; i++)
{
    playerOne = random.Next(1, 100);
    playerTwo = random.Next(1, 100);

    Console.WriteLine($"PlayerOne presents coin {playerOne}.");
    Console.WriteLine($"PlayerTwo presents coin {playerTwo}.");

    if (playerOne > playerTwo)
    {
        playerOneTotal += 1;

        Console.WriteLine($"PlayerOne wins round {i + 1}");
    }
    else if (playerOne < playerTwo)
    {
        playerTwoTotal += 1;

        Console.WriteLine($"PlayerTwo wins round {i + 1}");
    }
    else
    {
        playerOneTotal += 0.5;
        playerTwoTotal += 0.5;

        Console.WriteLine($"Game is tied in round {i + 1}");
    }
}

if (playerOneTotal > playerTwoTotal)
{
    Console.WriteLine($"PlayerOne won with {playerOneTotal} points at the end of the game.");
}
else if (playerTwoTotal > playerOneTotal)
{
    Console.WriteLine($"PlayerTwo won with {playerTwoTotal} points at the end of the game.");
}
else
{
    Console.WriteLine($"Game is tied with {playerOneTotal} points for both PlayerOne and playerTwo at the end.");
}