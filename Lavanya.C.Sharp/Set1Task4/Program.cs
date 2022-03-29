
int a = 15;
int b = 10;
decimal c;

c = a+b;
Console.WriteLine($"Sum of {a} and {b} is {c}");
Print(++a, --b);

c = a-b;
Console.WriteLine($"Difference of {a} and {b} is {c}");
Print(++a, --b);

c = a*b;
Console.WriteLine($"Product of {a} and {b} is {c}");
Print(++a, --b);

c = a/b;
Console.WriteLine($"Quotient of {a} and {b} is {c}");
Print(++a, --b);

c = a%b;
Console.WriteLine($"Remainder of {a} and {b} is {c}");
Print(++a, --b);

void Print(int a , int b)
{
    Console.WriteLine("a is " + a);
    Console.WriteLine("b is " + b);
}
