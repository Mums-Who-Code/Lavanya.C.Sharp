
Random random = new Random();
int [] players = new int [5];
for (int i = 0; i < 5; i++) 
{
    players[i] = random.Next(1, 7);
}

if (ContainsDuplicates(players, players[0]))
{
    Console.WriteLine($"First Player rolled {players[0]} and moved to the next level");
}
else 
{
    Console.WriteLine($"First Player rolled {players[0]} and did not move to the next level");
}
if (ContainsDuplicates(players, players[1]))
{
    Console.WriteLine($"Second Player rolled {players[1]} and moved to the next level");
}
else 
{
    Console.WriteLine($"Second Player rolled {players[1]} and did not move to the next level");
}
if (ContainsDuplicates(players, players[2]))
{
    Console.WriteLine($"Third Player rolled {players[2]} and moved to the next level");
}
else 
{
    Console.WriteLine($"Third Player rolled {players[2]} and did not move to the next level");
}
if (ContainsDuplicates(players, players[3]))
{
    Console.WriteLine($"Fourth Player rolled {players[3]} and moved to the next level");
}
else
{
    Console.WriteLine($"Fourth Player rolled {players[3]} did not move to the next level");
}
if (ContainsDuplicates(players, players[4]))
{
    Console.WriteLine($"Fifth Player rolled {players[4]} and moved to the next level");
}
else 
{
    Console.WriteLine($"Fifth Player rolled {players[4]} and did not move to the next level");
}

static bool ContainsDuplicates(int[] playerList,int number)
{
    int count = 0;
    for(int i=0;i< playerList.Length;i++)
    {
        if (playerList[i] == number)
        {
            count++;
        }
    }
    if (count > 1)
    {
        return true;
    }
    return false;
}