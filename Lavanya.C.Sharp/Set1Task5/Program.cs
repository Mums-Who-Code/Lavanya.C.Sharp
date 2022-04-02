
DateTime currentDateTime = DateTime.Now;
Console.WriteLine($"Current date and time is {currentDateTime}");
Random random = new Random();
int randomNumber = random.Next(1,100);
DateTime newDateTime = currentDateTime.AddDays(randomNumber);
Console.WriteLine($"Updated date and time is {newDateTime} after adding {randomNumber} days to {currentDateTime}");


