internal class Program
{
    private static void Main(string[] args)
    {
        int x = 5, y = 1, z = 10;
        int m = max(x, y, z);
        m = max(1);
        Console.WriteLine(m);
        m = max(1, 2);
        Console.WriteLine(m);
        Console.Write("Enter number you want to calculate the factorial:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        long f = factorial_recursion(userInput);
        Console.WriteLine($"{userInput}!={f}");
    }
    static int max(int a, params int[]args) //Bai 1
    {
        if (args.Length == 0)
            return a;
        int m = args[0];
        foreach (int i in args) // i la gia tri cua phan tu trong mang.
        {
            if (i > m)
                m = i;
        }
        return Math.Max(a,m);
    }
    static long factorial (int n) //Bai 4
    {
        long f = 1;
        for (int i = 1; i <= n; i++)
            f *= i;
        return f;
    }
    static long factorial_recursion(int n) //Bai 4
    {
        if (n == 0) return 1;
        return n * factorial_recursion(n - 1);
    }
    static bool checkprime (int n) //Bai 5
    {
        for (int i=2; i<=n; i++)
        {
            if(n%i==0)
                return false;
            return true;
        }
    }
    static void printPrimeNumberUnderN(int n) //Bai 6
    {
        for (int i=1; i<=n; i++)
        {
            if (checkprime(i) == true)
                if
                else
                            Console.WriteLine($"Prime numbers under {n} is {i}");
        }
    }
    static void printFirstNprimeNumber(int n) //Bai 6
    {

    }

}