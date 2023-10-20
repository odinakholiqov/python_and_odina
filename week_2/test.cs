class Program
{
    static void Main(string[] args)
    {
        int counter = 0;

        // Passing by reference.
        // The value of counter in Main is changed.
        Console.WriteLine(greet("Alice", ref counter));
        Console.WriteLine("Counter is {0}", counter);
        Console.WriteLine(greet("Bob", ref counter));
        Console.WriteLine("Counter is {0}", counter);
        // Output:
        // Hi, Alice!
        // Counter is 1
        // Hi, Bob!
        // Counter is 2
    }

    static string greet(string name, ref int counter)
    {
        string greeting = "Hi, " + name + "!";
        counter++;
        return greeting;
    }
}


void SquareRef(ref int a)
{
    a *= a;
}

int a = 4;
SquareRef(ref a);
Console.WriteLine(a);


