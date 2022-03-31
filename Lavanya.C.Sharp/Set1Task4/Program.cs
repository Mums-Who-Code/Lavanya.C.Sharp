
int a = 15;
int b = 10;
decimal c;

c = a+b;
Print(ref a, ref b, c, "Sum");

c = a-b;
Print(ref a, ref b, c,"Difference");

c = a*b;
Print(ref a, ref b, c, "Product");

c = a/b;
Print(ref a, ref b, c, "Quotient");

c = a%b;
Print(ref a, ref b, c, "Remainder");

void Print(ref int a , ref int b, decimal c, string operation)
{
    Console.WriteLine($"{operation} of {a} and {b} is {c}");
    Console.WriteLine("a is " + ++a);
    Console.WriteLine("b is " + --b);
}
