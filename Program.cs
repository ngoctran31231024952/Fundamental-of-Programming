internal class Program
{
    private static void Main(string[] args)
    {
        Baitap1();
        Baitap2();       
        
    }
        static void Baitap1()
    {
        Console.WriteLine("Baitap1:");
        Console.WriteLine("Enter degree in Celsius!");
        var userinput = Console.ReadLine();
        float Celsius = Convert.ToSingle(userinput);
        Console.WriteLine($"Degree in Fahrenheit:{Celsius * 1.8 + 32}");
        Console.WriteLine($"Degree in Kelvin:{Celsius + 273}");
    }
        static void Baitap2()
    {
        Console.WriteLine("Baitap2:");
        const double Pi = Math.PI;
        Console.Write("Enter sphere's radius:");
        float r = Convert.ToSingle(Console.ReadLine());
        double s = 4 * Pi * Math.Pow(r, 2);
        double v = 4 / 3 * Pi * Math.Pow(r, 3);
        Console.WriteLine($"Surface={s}");
        Console.WriteLine($"Volume={v}");
    }
}