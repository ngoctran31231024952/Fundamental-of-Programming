internal class Program
{
    private static void Main(string[] args)
    {
        int Thua = 0;
        int Thang = 0;
        int Choi = 0;
        int SoTienConLai;
        do
        {
            Random rnd = new Random();
            int comp_num = rnd.Next(1, 100);
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Your number:");
                int man_num = int.Parse("0" + Console.ReadLine());
                if (man_num == comp_num)
                {
                    Console.WriteLine("Bravo! You are genious");
                    Console.WriteLine("You win!");
                    Thang = Thang + 1;
                    break;
                }
                else
                if (i == 4)
                {
                    if (man_num < comp_num)
                    {
                        Console.WriteLine("Your guessing number is less than computer number");
                        Console.WriteLine("You lose!");
                        Thua = Thua + 1;
                    }
                    else
                    {
                        Console.WriteLine("Your guessing number is greater than computer number");
                        Console.WriteLine("You lose!");
                        Thua = Thua + 1;
                    }
                }
                else
                if (man_num < comp_num)
                    Console.WriteLine("Your guessing number is less than computer number");
                else
                    Console.WriteLine("Your guessing number is greater than computer number");
            }
            Console.WriteLine("Do you want to continue? <Y/N>");
            String res = "" + Console.ReadLine();
            if (res.ToUpper().Equals("N"))
            {
                Console.WriteLine("Bye! See you again");
                Choi = Choi + 1;
                break;
            }
            else
                Choi= Choi + 1;
        }
        while (true);
        Console.WriteLine($"So lan da choi:{Choi}");
        Console.WriteLine($"So tien con lai: {1000 - Choi * 50}");
        Console.WriteLine($"So lan thang/thua: {Thang}/{Thua}");

    }
}