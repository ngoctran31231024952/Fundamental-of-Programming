using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Baitap1();
        Baitap2();
        Baitap5();
        Baitap6();
        Baitap8();
        
    }
    static void Baitap1()
    {
        Console.WriteLine("Baitap1:");
        Console.Write("Enter a integer:");
        int songuyen = Convert.ToInt32(Console.ReadLine());
        if (songuyen % 2 == 0)
        {
            Console.WriteLine($"{songuyen} is an even number.");
        }
        else
        {
            Console.WriteLine($"{songuyen} is an odd number.");
        }
    }
    static void Baitap2()
    {
        Console.WriteLine("Baitap2:");
        Console.WriteLine("Enter three numbers in turn:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Max number is:{Math.Max(Math.Max(a, b), c)}");
    }
    static void Baitap5()
    {
        Console.WriteLine("Baitap5:");
        int i, sum, userInput;
        sum = 0;
        double avg;
        Console.WriteLine("Enter ten numbers in turn:");
        for (i = 0; i < 10; i++)
        {
            userInput = Convert.ToInt32(Console.ReadLine());
            sum = sum + userInput;
        }
        avg = sum / 10.0;
        Console.WriteLine($"Sum of ten numbers is: {sum}.");
        Console.WriteLine($"Average of ten numbers is: {avg}.");
    }
    static void Baitap6()
    {
        Console.WriteLine("Baitap6:");
        Console.Write("Enter an integer (From 2 to 9):");
        int userInput = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i<=10; i++)
        {
            Console.WriteLine($"{userInput}*{i}={userInput * i}");
        }

    }
    static void Baitap8()
    {
        Console.WriteLine("Baitap8:");
        double sum = 0.0;
        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i = n)
            {
                Console.Write($"1/{i}");
            }
            else
            {
                Console.Write($"1/{i}+");
                sum += 1.0 / i;
            }
        }
        Console.WriteLine($"={sum}");
    }
}