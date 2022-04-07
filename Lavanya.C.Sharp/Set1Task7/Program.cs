
using System.Collections.Generic;

List<int> playerOne = new List<int> { 1, 5, 10, 25, 50 };
List<int> playerTwo = new List<int> { 1, 5, 10, 25, 50 };
Random random = new Random();

double playerOneTotal = 0;
double playerTwoTotal = 0;

for (int i = playerOne.Count; i >0; i--)
{ 
    int playerOneIndex = random.Next(i);
    int playerOneCoin = playerOne[playerOneIndex];
    int playerTwoIndex = random.Next(i);
    int playerTwoCoin = playerTwo[playerTwoIndex];
    playerOne.RemoveAt(playerOneIndex);
    playerTwo.RemoveAt(playerTwoIndex);

    Console.WriteLine($"PlayerOne presents coin {playerOneCoin}.");
    Console.WriteLine($"PlayerTwo presents coin {playerTwoCoin}.");

    if (playerOneCoin > playerTwoCoin)
    {
        playerOneTotal += 1;
    }
    else if (playerTwoCoin > playerOneCoin)
    {
        playerTwoTotal += 1;
    }
    else 
    {
        playerOneTotal += 0.5;
        playerTwoTotal += 0.5;
    }
}

if (playerOneTotal > playerTwoTotal)
{
    Console.WriteLine($"PlayerOne won with {playerOneTotal} points.");
}
else if (playerTwoTotal > playerOneTotal)
{
    Console.WriteLine($"PlayerTwo won with {playerTwoTotal} points.");
}
else
{
    Console.WriteLine($"Game is tied with {playerOneTotal} points for both PlayerOne and playerTwo");
}