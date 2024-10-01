using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        //Create a random integer values array, then create functions that:
        //1.to calculate the average value of array elements.
        //2.to test if an array contains a specific value.
        //3.to find the index of an array element.
        //4.to remove a specific element from an array.
        //5.to find the maximum and minimum value of an array.
        //6.to reverse an array of integer values.
        //7.to find duplicate values in an array of values.
        //8.to remove duplicate elements from an array.
        //Create a C# program that
        //- requests 10 integers from the user and orders them by implementing the bubble sort
        //algorithm.
        //- Request a sentence from the user, then ask to enter a word. Search if the word
        //appears in the phrase using the linear search algorithm.

        Random rnd = new Random();
        int[] RandomArray = new int[5];
        Console.Write("Your Random Array: ");
        for (int i = 0; i < RandomArray.Length; i++)
        {
            RandomArray[i] = rnd.Next(1, 10);
            Console.Write($"{RandomArray[i]} ");
        }
        Console.Write("\n");
        float avg = AvgArray(RandomArray); //Bai 1
        Console.WriteLine($"The average value of array element: {avg}");

        Console.Write("Enter specific value: "); //Bai 2
        int SpecificValue;
        bool a = int.TryParse(Console.ReadLine(), out SpecificValue);
        while (true)
        {
            if (!a)
            {
                Console.WriteLine("Enter a number, please!");
            }
            else
            {
                break;
            }
        }
        int IndexSpecificValue = ContainValue(SpecificValue, RandomArray);
        Console.WriteLine($"This specific value is at {IndexSpecificValue}th");
        Console.Write("Enter the value element you wanna know its index in RandomArray: "); //Bai 3
        int ValueElement = int.Parse(Console.ReadLine());
        int IndexElement = FindIndex(ValueElement, RandomArray);
        Console.WriteLine($"Your value element at {IndexElement}th.");

        Console.Write("Enter index of element you wanna remove: "); //Bai 4
        int IndexRemove = int.Parse(Console.ReadLine());
        int[] RandomArrayAf = Remove(IndexRemove, RandomArray);
        Console.Write("Your array after remove Specific element: ");
        for (int i = 0; i < RandomArrayAf.Length; i++)
        {
            Console.Write($"{RandomArrayAf[i]} ");
        }
        Console.Write("\n");

        int[] Min_MaxArr = Min_Max(RandomArrayAf); //Bai 5
        Console.WriteLine($"Min in RandomArray is {Min_MaxArr[0]} and Max is {Min_MaxArr[1]}.");

        int[] ArrAfReverse = ReverseArray(RandomArrayAf); //Bai 6
        Console.Write("Random Array after Reverse: ");
        for (int i = 0; i < ArrAfReverse.Length; i++)
        {
            Console.Write($"{ArrAfReverse[i]} ");
        }
        Console.Write("\n");

        Console.Write("Duplicate values in Random Array: "); //Bai 7
        Console.WriteLine("Enter an array of 10 integers!");
        int[] UserArray = new int[10];
        for (int i = 0; i < UserArray.Length; i++)
        {
            UserArray[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Your Array is: ");
        for (int i = 0; i < UserArray.Length; i++)
        {
            Console.Write($"{UserArray[i]} ");
        }
        Console.Write('\n');
        Console.Write("Duplicate values in UserArray: ");
        FindDuplicate(UserArray);
        Console.Write("\n");

        int[] ArrayAfRm = ArrayAfRmDup(UserArray); //Bai 8
        Console.Write("User Array After remove DupVal: ");
        for (int i = 0; i < ArrayAfRm.Length; i++)
        {
            Console.Write($"{ArrayAfRm[i]} ");
        }
        Console.Write("\n");
        Console.WriteLine("Enter an array of 10 integers!");
        int[] UserArray2 = new int[10];
        for (int i = 0; i < UserArray2.Length; i++)
        {
            UserArray2[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Your Array is: ");
        for (int i = 0; i < UserArray2.Length; i++)
        {
            Console.Write($"{UserArray2[i]} ");
        }
        Console.Write('\n');

        int[] ArrAfBbSort = BubbleSort(UserArray2); //Bai 9
        Console.Write("Array after BubbleSort: ");
        for (int i = 0; i < ArrAfBbSort.Length; i++)
        {
            Console.Write($"{ArrAfBbSort[i]} ");
        }
        Console.Write('\n');

        Console.Write("Enter a sentence: "); //Bai 10
        string s = Console.ReadLine();
        Console.Write("Enter the word you wanna search in sentence: ");
        string w = Console.ReadLine();
        int LinearSearch = SearchWord(s, w);
        Console.WriteLine($"SearchWord is the {LinearSearch}th Word.");
    }
    static float AvgArray(int[] RandomArray) //Bai 1
    {
        int sum = 0;
        for (int i = 0; i < RandomArray.Length; i++)
        {
            sum += RandomArray[i];
        }
        float avg = sum / RandomArray.Length;
        return avg;
    }
    static int ContainValue(int SpecificValue, int[] RandomArray) //Bai 2
    {
        for (int i = 0; i < RandomArray.Length; i++)
        {
            if (RandomArray[i] == SpecificValue)
            {
                return i;
                break;
            }
        }
        return -1;
    }
    static int FindIndex(int ValueElement, int[] RandomArray) //Bai 3
    {
        for (int i = 0; i < RandomArray.Length; i++)
        {
            if (ValueElement == RandomArray[i])
            {
                return i;
                break;
            }
        }
        return -1;
    }
    static int[] Remove (int IndexRemove, int[] RandomArray) //Bai 4 
    {
        for (int i = IndexRemove; i<RandomArray.Length-1; i++)
        {
            RandomArray[i] = RandomArray[i + 1];
        }
        int[] RandomArrayAf = new int [RandomArray.Length - 1];
        for (int i=0; i<RandomArrayAf.Length; i++)
        {
            RandomArrayAf[i] = RandomArray[i];
        }
        return RandomArrayAf;
    }
    static int[] Min_Max (int[] RandomArray) //Bai 5
    {
        int Min = RandomArray[0];
        int Max = RandomArray[0];
        for (int i=0; i < RandomArray.Length; i++)
        {
            if (RandomArray[i] < Min)
            {
                Min = RandomArray[i];
            }
            if (RandomArray[i] > Max)
            {
                Max = RandomArray[i];
            }
        }
        int[] Result = { Min, Max };
        return Result;
    }
    static int[] ReverseArray (int[] RandomArray) //Bai 6
    {
        Array.Reverse(RandomArray);
        return RandomArray;
    }
    static void FindDuplicate(int[] UserArray) //Bai 7
    {
        int[]UserArrayCopy = new int[UserArray.Length];
        Array.Copy(UserArray, 0, UserArrayCopy, 0, UserArray.Length);
        int n = UserArrayCopy.Length; //BubbleSort UserArray.
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (UserArrayCopy[j] > UserArrayCopy[j + 1])
                {
                    int temp = UserArrayCopy[j];
                    UserArrayCopy[j] = UserArrayCopy[j + 1];
                    UserArrayCopy[j + 1] = temp;
                }
            }
        }
        bool HaveDupVal = false;
        for (int i = 1; i< UserArrayCopy.Length; i++)
        {
            if (UserArrayCopy[i] == UserArrayCopy[i - 1])
            {
                HaveDupVal = true;
                Console.Write($"{UserArrayCopy[i-1]} ");
                for(int j=i+1; j < UserArrayCopy.Length; j++)
                {
                    if (UserArrayCopy[j] == UserArrayCopy[j - 1])
                    {
                        i++;
                    }
                    else
                    {
                        break;  
                    }
                }
            }
        }
        if (HaveDupVal == false)
        {
           Console.WriteLine("Does not have any values.");
        }
    }
    static int[] ArrayAfRmDup(int[]UserArray) //Bai 8
    {
        bool HaveDupVal = false;
        int count = 0;
        int k = -1;
        int[] UserArrayCopy = new int[UserArray.Length];
        Array.Copy(UserArray,0,UserArrayCopy,0,UserArray.Length);
        int n = UserArrayCopy.Length; //BubbleSort UserArray.
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (UserArrayCopy[j] > UserArrayCopy[j + 1])
                {
                    int temp = UserArrayCopy[j];
                    UserArrayCopy[j] = UserArrayCopy[j + 1];
                    UserArrayCopy[j + 1] = temp;
                }
            }
        }
        for (int i = 1; i < UserArrayCopy.Length; i++) //Đếm các gía trị duplicate.
        {
            if (UserArrayCopy[i] == UserArrayCopy[i - 1])
            {
                HaveDupVal = true;
                count++;
                for (int j = i + 1; j < UserArrayCopy.Length; j++)
                {
                    if (UserArrayCopy[j] == UserArrayCopy[j - 1])
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        int[] ArrOfDup = new int[count];
        for (int i = 1; i < UserArrayCopy.Length; i++) //Gán giá trị cho mảng giá trị duplicate.
        {
            if (UserArrayCopy[i] == UserArrayCopy[i - 1])
            {
                k++;
                ArrOfDup[k] = UserArrayCopy[i];
                for (int j = i + 1; j < UserArrayCopy.Length; j++)
                {
                    if (UserArrayCopy[j] == UserArrayCopy[j - 1])
                    {
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        if (HaveDupVal == false)
        {
            Console.WriteLine("Do not have duplicate values to remove.");
            return null;
        }
        else
        {
            int count2 = 0;
            for (int i = 0; i < n; i++) //Đếm số "elements có dupval sẽ bị xóa."
            {
                for (int j = 0; j < ArrOfDup.Length; j++)
                {
                    if (UserArray[i] == ArrOfDup[j])
                    {
                        count2++;
                    }
                }
            }
            int[] ArrayAfRm = new int[n-count2];
            for (int i=0; i<n; i++) //Xóa các elements có dupval.
            {
                for(int j=0; j < ArrOfDup.Length; j++)
                {
                    if (UserArray[i] == ArrOfDup[j])
                    {
                        ArrayAfRm = Remove(i, UserArray);
                        UserArray = ArrayAfRm;
                        i--;
                        n--;
                    }
                }  
            }
            for (int i = 0; i < UserArray.Length; i++)
            {
                Console.Write($"{UserArray[i]} ");
            }
            return UserArray;
        }
    }
    static int[] BubbleSort(int[] UserArray2) //Bai 9
    {
        int temp;
        int n = UserArray2.Length;
        for(int i=0; i<n-1; i++)
        {
            for (int j = 1; j < n - i; j++)
            {
                if (UserArray2[j] < UserArray2[j - 1])
                {
                    temp = UserArray2[j];
                    UserArray2[j] = UserArray2[j - 1];
                    UserArray2[j - 1] = temp;
                }
            }
        }
        return UserArray2;
    }
    static int SearchWord(string s,string w) //Bai 10
    {
        w=w.Trim();
        w=w.ToLower();
        s=s.Trim();
        s=s.ToLower();
        s = " " + s + " ";
        int k = 1;
        int i = 1;
        int n = w.Length;
        for(i=0; i < s.Length; i++)
        {
            
            if (s[i] == w[0])
            {
                for(int j=i+1; j<i+n; j++)
                {
                    if (s[j] == w[k])
                    {
                        k++;
                    }
                    else
                    {
                        k = 1;
                    }
                    if (k == n && s[i - 1] == ' ' && s[j + 1] == ' ') ;
                    {
                        s=s.Trim() ;
                        int count = 0;
                        if (!string.IsNullOrEmpty(s))
                        {
                            count++;
                        }
                        int m=0;
                        while(m < i)
                        {
                            if (s[m]==' ' && s[m+1]!=' ')
                            {
                                count++;
                            }
                        }
                        return count++;
                    }
                }
            }
        }
        return 0;
    }
}

//int[] RandomArrayCopy = new int[RandomArray.Length];
//Array.Copy(RandomArray, 0, RandomArrayCopy, 0, RandomArray.Length);

//        Avg(RandomArray); //Bai1
//        PerfectValue(RandomArray);//Baitulamthem
//        Console.Write("Enter specific number you wanna search in Array: ");
//        int SearchNumber = Convert.ToInt32(Console.ReadLine());
//        BinarySearch(RandomArray, SearchNumber); //Bai2
//        Console.Write("Enter the Element Value you wanna find its index: ");
//        int ElementValue = Convert.ToInt32(Console.ReadLine());
//    }
//    static float Avg(int[] a) //Bai1
//    {
//        int sum = 0;
//        for (int i=0; i <a.Length; i++)
//        {
//            sum = sum + a[i];
//        }
//        float Average = sum / a.Length;
//        Console.WriteLine($"The Average of Array is {Average}");
//        return Average;
//    }
//    static void PerfectValue(int[] a) //Baitulamthem
//    {
//        int sum = 0;
//        bool HavePerfectNumber=false;
//        for (int i=0; i<a.Length; i++)
//        {
//            for(int j = 2; j <= a[i]/2; j++)
//            {
//                if (a[i] % j == 0)
//                {
//                    sum = sum + j;
//                }
//                if (j == a[i] / 2)
//                {
//                    if (sum == a[i])
//                    {
//                        Console.WriteLine($"Perfect Values: {a[i]} at {i}th  ");
//                        HavePerfectNumber = true;
//                    }
//                }

//            }
//        }
//        if (HavePerfectNumber==false)
//        {
//            Console.WriteLine("Your Array does not have Perfect Number!");
//        }
//    }
//    static void BinarySearch(int[] a, int SearchNumber)//Bai2
//    {
//        int min = 0;
//        int max = a.Length - 1;
//        while (min <= max)
//        {
//            int mid = (min + max) / 2;
//            if (a[mid] == SearchNumber)
//            {
//                Console.WriteLine($"Your searching number is at {mid}th");
//                break;
//            }
//            else if (a[mid] > SearchNumber)
//            {
//                max = mid - 1;
//            }
//            else
//            {
//                min = mid + 1;
//            }
//            if (min == max && a[mid] > SearchNumber || a[mid] < SearchNumber)
//            {
//                Console.WriteLine("Array does not have your searching number!");
//            }
//        }
//    }   
//}
