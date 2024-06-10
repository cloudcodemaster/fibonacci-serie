Console.Write("Enter the number of terms: ");
ulong terms = ulong.Parse(Console.ReadLine());
Console.ReadKey();

// Call the method to print the Fibonacci series
PrintFibonacciSeries(terms);


    static void PrintFibonacciSeries(ulong terms)
{
    ulong firstNumber = 0, secondNumber = 1, nextNumber;

    Console.WriteLine("Fibonacci Series:");

    for (ulong i = 1; i <= terms; i++)
    {
        Console.Write(firstNumber + " ");
        nextNumber = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }
}
