using System.ComponentModel.DataAnnotations;

internal class Program
    // Gạch dưới màu đỏ là bị lỗi.
    // Gạch dưới màu xanh là chưa được dùng tới hoặc có cảnh báo.
    // Màu xanh lá cây là lớp.
    // Màu vàng là phương thức (function) - thực hiện các tác vụ cụ thể.
    // Màu xanh dương là tên các para/argument.
{
    private static void Main(string[] args)
    {
        //Declare array
        int[] a;
        //Initialization
        a = new int[5];
        //Combine both & assign values
        int[] b = new int[5] { 1, 2, 3, 4, 5 };
        //Change the value at index 0
        b[0] = 10;
        // Enter the values of an array from keyboard
        int[] ArrayFromKeyboard = new int[3];
        for (int i=0; i<ArrayFromKeyboard.Length; i++)
        {
            Console.Write("Enter a number:");
            bool CorrectNumber = int.TryParse(Console.ReadLine(), out ArrayFromKeyboard[i]);
            if (!CorrectNumber)
            {
                Console.WriteLine("Please enter a number!");
                i--;
            }
        }
        //LinearSearch
        static int LinearSearch(int[]a, int KeyNumber)
        {
            for (int i=0; i < a.Length; i++)
            {
                if (a[i] == KeyNumber)
                {
                    Console.WriteLine($"The search number is at {i}th");
                    return i; 
                }
            }
            return -1;
        }
        // BinarySearchIterative
        static int BinarySearchIterative(int[]a, int KeyNumber)
        {
            int min = 0;
            int max = a.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (a[mid] == KeyNumber)
                {
                    Console.WriteLine($"The search number is at {mid}th");
                    return mid;
                }
                else if (a[mid] > KeyNumber)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        // BubbleSort
        static void BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i=0; i<n-1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        // InsertionSort
        static void InsertionSort(int[] a)
            //So sanh tai moi index cua mang:
            //Moi so nhu vay so sanh voi cac so lien truoc no (voi TH so do nho hon so lien truoc no, neu thoa thi so sanh voi nhung so truoc no theo thu tu tu gan den xa, vi cac so dang truoc no da duoc sap xep)
        { 
            for (int i=1; i<a.Length; i++)
            {
                int j = i;
                while (j>=0 && a[j] < a[j - 1])
                {
                    int temp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                    j = j - 1;
                }
            }

        }
        // SelectionSort
        static void SelectionSort(int[] a)
            //Tim so nho nhat (bang cach lan luot so sanh chung voi 1 so lam moc ban dau)
            //Tai moi mang (cac mang nay la cac mang moi xuat hien trong qua trinh sap xep, do da bo qua cac so nho nhat da duoc tim thay)
        {
            for (int i=0; i<a.Length-1; i++)
            {
                for (int j = i; j<a.Length-1; j++)
                {
                    if (a[j + 1] < a[i])
                    {
                        int temp2 = a[i];
                        a[i] = a[j + 1];
                        a[j + 1] = temp2;

                    }
                }
            }

        }
    }
}
