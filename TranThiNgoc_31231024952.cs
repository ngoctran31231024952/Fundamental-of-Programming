internal class TranThiNgoc_31231024952
{
    private static void Mainx(string[] args)
    {
        //1.Phát sinh một mảng có N số nguyên ngẫu nhiên, với N nhập từ bàn phím.
        //2.In ra mảng này.
        //3.Nhập một số X, tìm xem số X có tồn tại trong mảng hay không.Nếu có trả về vị trí xuất hiện
        //sau cùng của X, không có thì trả về -1.
        //4.In ra các phần tử trong mảng là số nguyên tố.
        //5.Kiểm tra 1 mảng đã được sắp xếp chưa. Nếu có thì trả về true, còn không trả về false.
        //6.Sắp xếp các phần tử mảng theo thứ tự giảm dần(không dung hàm do C# cung cấp sẵn)
        //7.Viết một hàm phát sinh ngẫu nhiên một ma trận chữ nhật NxM, với N,M nhập từ bàn phím.
        //8.In ma trận đã nhập.
        //9.Nhập vào 1 giá trị chỉ cột, hãy tính tổng các phần tử thuộc cột đó.
        //10.Viết một menu cho phép lựa chọn các hàm và thực thi.
        int[] Arr = new int[5];
        Arr = UserArray(Arr);
        Console.Write("Your Array is: "); //Bài 2
        for (int i = 0; i < Arr.Length; i++)
        {
            Console.Write($"{Arr[i]} ");
        }
        Console.WriteLine();

        Console.WriteLine("Enter number X to check if it exists in Array: "); //Bài 3
        int X=int.Parse(Console.ReadLine());
        int IndexX=CheckX(Arr, X);
        Console.WriteLine($"Index of X in Arr is at {IndexX}th.");

        Console.Write("Prime numbers in Array: "); //Bai 4
        PrimeNumber(Arr); 

        bool Sort=checkSort(Arr); //Bài 5
        if (Sort)
        {
            Console.WriteLine("Mảng đã được sắp xếp.");
        }
        else
        {
            Console.WriteLine("Mảng chưa được sắp xếp.");
        }
    }
    static int[] UserArray(int[] Arr) //Bài 1
    {
        Arr = new int[5];
        Console.Write("Enter your array: ");
        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = int.Parse(Console.ReadLine());
        }
        return Arr;
    }
    static void Print(int[] Arr) //Bai 2
    {
        Arr= new int[5];
        Arr = UserArray(Arr);
        Console.Write("Your Array is: "); 
        for (int i = 0; i < Arr.Length; i++)
        {
            Console.Write($"{Arr[i]} ");
        }
    }
    static int CheckX(int[] Arr, int numberX) //Bài 3
    {
        int strtIndex=Array.IndexOf(Arr, numberX);
        if (strtIndex != -1)
        {
            while (strtIndex<Arr.Length) 
            {
                strtIndex = Array.IndexOf(Arr, numberX, strtIndex + 1);
            }
            return strtIndex;
        }
        return -1;
    }
    static void PrimeNumber(int[] Arr) //Bài 4
    {
        bool HavePrime = false;
        for(int i=0; i<Arr.Length; i++)
        {
            int j;
            for(j=2; j < Arr[i]/2;j++)
            {    
                if (Arr[i] % j == 0)
                {
                    break;
                }
                if (j == Arr[i] / 2 - 1 && Arr[i]%j!=0)
                {
                    HavePrime = true;
                    Console.Write($"{Arr[i]} ");
                }
            }
        }
        if( !HavePrime ) 
        {
            Console.WriteLine("No any numbers.");
        }
    }
    static bool checkSort(int[] Arr) //Bài 5
    {
        int[]ArrCopy= new int[Arr.Length];
        Array.Copy(Arr, 0, ArrCopy, 0, Arr.Length);
        Array.Sort(ArrCopy);
        for(int i=0; i<Arr.Length; i++)
        {
            if (Arr[i] != ArrCopy[i])
            {
                return false;
                break;
            }
        }
        Array.Reverse(ArrCopy);
        for (int i = 0; i < Arr.Length; i++)
        {
            if (Arr[i] != ArrCopy[i])
            {
                return false;
                break;
            }
        }
        return false;
    }
    static int[] BubbleSort(int[] Arr) //Bai 6
    {
        int temp;
        int n = Arr.Length;
        for(int i=0; i<n-1; i++)
        {
            for(int j=1; j<n-i; j++)
            {
                if (Arr[j] < Arr[j - 1])
                {
                    temp = Arr[j];
                    Arr[j] = Arr[j - 1];
                    Arr[j - 1] = temp;
                }
            }
        }
        return Arr;
    }
    static int[,] Hcn(int[,] arr) //Bai 7
    {
        Console.Write("Nhap ma tran hcn n*m");
        int n=int.Parse(Console.ReadLine());
        int m=int.Parse(Console.ReadLine());
        arr = new int[n, m];
        
        return arr;
    }

    
}