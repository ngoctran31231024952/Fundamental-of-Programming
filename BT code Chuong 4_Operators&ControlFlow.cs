using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Baitap1();
        Baitap2();
        Baitap3();
        Baitap4();
        Baitap5();
        Baitap6();
        Baitap7();
        Baitap8();
        Baitap9();
        Baitap10();
        
    }
    static void Baitap1()
    {
        Console.WriteLine("Baitap1: Write a C# Sharp program to check whether a given number is even or odd.");
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
        Console.WriteLine("Baitap2: Write a C# Sharp program to find the largest of three numbers.");
        Console.WriteLine("Enter three numbers in turn:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Max number is:{Math.Max(Math.Max(a, b), c)}");
    }
    static void Baitap3()
    {
        Console.WriteLine("Baitap3: Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.");
        Console.Write("Enter the value for X coordinate: ");
        int co1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value for Y coordinate: ");
        int co2 = Convert.ToInt32(Console.ReadLine());
        if (co1 > 0 && co2 > 0)
        {
            Console.WriteLine($"The coordinate point ({co1},{co2}) lies in the First quandrant.");
        }
        else if (co1 < 0 && co2 > 0)
        {
            Console.WriteLine($"The coordinate point ({co1},{co2}) lies in the Second quandrant.");
        }
        else if (co1 < 0 && co2 < 0)
        {
            Console.WriteLine($"The coordinate point ({co1},{co2}) lies in the Third quandrant.");
        }
        else if (co1 > 0 && co2 < 0)
        {
            Console.WriteLine($"The coordinate point ({co1},{co2}) lies in the Fourth quandrant.");
        }
        else if (co1 == 0 && co2 == 0)
        {
            Console.WriteLine($"The coordinate point ({co1},{co2}) lies at the origin.");
        }
    }
    static void Baitap4()
    {
        Console.WriteLine("Baitap4: Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.");
        Console.Write("Enter side 1 of triangle: ");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter side 2 of triangle: ");
        int side2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter side 3 of triangle: ");
        int side3 = Convert.ToInt32(Console.ReadLine());
        if (side1+side2>side3 && side1+side3>side2 && side2+side3>side1 && side1>0 && side2>0 && side3 > 0)
        {
            Console.WriteLine("The above 3 sides can form a triangle.");
            if (side1==side2 && side2 == side3)
            {
                Console.WriteLine("This is an quilateral triangle.");
            }
            else if (side1==side2 || side1==side3 || side2 == side3)
            {
                Console.WriteLine("This is an isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is an scalene triangle.");
            }
        }
        else
        {
            Console.WriteLine("The above 3 sides can not form a triangle!");
        }
    }
    static void Baitap5()
    {
        Console.WriteLine("Baitap5: Write a program to read 10 numbers and find their average and sum.");
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
        Console.WriteLine("Baitap6: Write a program to display the multiplication table of a given integer.");
        Console.Write("Enter an integer (From 2 to 9):");
        int userInput = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i<=10; i++)
        {
            Console.WriteLine($"{userInput}*{i}={userInput * i}");
        }

    }
    static void Baitap7()
    {
        Console.WriteLine("Baitap7: Write a program to display a pattern like triangles with a number.");
        int k = 1;
        int j = 1;
        int s = 0;
        //Pattern 1:
        for (int i=1; i<=4; i++)
        {
            for(j=1; j<=k; j++)
            {
                Console.Write($"{j}");
            }
            k++;
            Console.Write("\n");
        }
        Console.Write("\n\n");
        //Pattern 2:
        k = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (j = 1; j <= k; j++)
            {
                s++;
                Console.Write($"{s}");
            }
            k++;
            Console.Write("\n");
        }
        Console.Write("\n\n");
        //Pattern 3:
        k = 1;
        s = 0;
        for (int i=1; i<=4; i++)
        {
            for (j = 1; j <= 4 - i; j++)
            {
                Console.Write(" ");
                if (j == 4 - i)
                {
                    for (int t = 1; t <= k; t++)
                    {
                        s++;
                        Console.Write($"{s} ");
                    }
                    k++;
                    Console.Write("\n");
                }
                
            }
            if (4 - i == 0)
            {
                for (int t = 1; t <= k; t++)
                {
                    s++;
                    Console.Write($"{s} ");
                }
                k++;
                Console.Write("\n");
            }
        }
        Console.Write("\n\n");

    }
    static void Baitap8()
    {
        Console.WriteLine("Baitap8: Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms");
        double sum = 0.0;
        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for ( int i=1; i<=n; i++)
        {
            if (i == n)
            {
                Console.Write($"1/{i}");
                sum = sum + 1.0 / i;
            }
            else
            {
                Console.Write($"1/{i} + ");
                sum = sum + 1.0 / i;
            }   
        }
        Console.WriteLine($" = {sum}");
    }
    static void Baitap9()
    {
        Console.WriteLine("Baitap9: Write a program to find the ‘perfect’ numbers within a given number range.");
        int sum = 0;
        Console.Write("Enter the starting range: ");
        int s = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the ending range: ");
        int e = Convert.ToInt32(Console.ReadLine());
        for (int i = s; i <= e; i++)
        {
            for (int j = 1; j<i; j++)
            {
                if (i % j == 0)
                {
                    sum = sum + j;
                }            
            }
            if (sum == i)
            {
                Console.WriteLine($"the ‘perfect’ numbers within ({s},{e}) range is:");
                Console.WriteLine($"{i}");
            }
            sum = 0;
        }
    }
    static void Baitap10()
    {
        Console.WriteLine("Baitap10: Write a program to determine whether a given number is prime or not.");
        int n = Convert.ToInt32(Console.ReadLine());
        bool chkprime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false; 
                }
            }
            return true; 
        }
        if (chkprime(n) == true)
        {
            Console.WriteLine($"{n} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{n} is not a prime number.");
        }

    }
}
