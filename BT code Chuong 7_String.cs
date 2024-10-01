using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Data.SqlTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        //string s = "neu troi mua thi" + "toi di choi";
        //string s1= @"""con khong thi
        //    toi di hoc""";
        //Console.WriteLine($"{s}, {s1}");

        //to input a string and print it.
        //to find the length of a string without using a library function.
        //to separate individual characters from a string.
        //to print individual characters of the string in reverse order.
        //to count the total number of words in a string.
        //to compare two strings without using a string library functions.
        //to count the number of alphabets, digits and special characters in a string.
        //to count the number of vowels or consonants in a string.
        //to check whether a given substring is present in the given string.
        //to search for the position of a substring within a string.
        //to check whether a character is an alphabet and not and if so, check for the case.
        //to find the number of times a substring appears in a given string.
        //to insert a substring before the first occurrence of a string.

        Console.Write("Enter string s: ");
        string s = Console.ReadLine();
        s = PrintString(s);
        Console.WriteLine($"{s}");

        int NoS = StringLength(s);
        Console.WriteLine($"The length of String:{NoS}");

        string IndividualChar = Bai3(s);
        Console.WriteLine($"{IndividualChar}");

        string IndChrReverseOrder = Bai4(s);
        Console.WriteLine($"{IndChrReverseOrder}");

        int Count = CountWord(s);
        Console.WriteLine($"No Words: {Count}");

        Console.Write("Enter string s2 to compare to s: "); //Luu y bai ni nha
        string s2 = Console.ReadLine();
        bool[] Compare = CompareString(s, s2);
        if (Compare[0] == true && Compare[1] == true)
        {
            Console.WriteLine("The Length of both strings are equal and they are same.");
        }
        else if (Compare[0] && !Compare[1])
        {
            Console.WriteLine("The length of both strings are equal but they are not same.");
        }
        else
        {
            Console.WriteLine("The Length of both strings are not equal.");
        }

        int[] Result = A_D_SC(s);
        Console.WriteLine($"No Alphabets: {Result[0]}");
        Console.WriteLine($"No Digits: {Result[1]}");
        Console.WriteLine($"No Special Characters: {Result[2]}");

        int[] NoV_C = Vowel_Consonant(s);
        Console.WriteLine($"No Vowels: {NoV_C[0]}");
        Console.WriteLine($"No Cosonants: {NoV_C[1]}");
        Console.Write("Enter the substring to search in string s: ");

        string s3 = Console.ReadLine();
        bool chk = ChkSubstring̣(s, s3);
        if (chk == true)
        {
            Console.WriteLine("The substring exits in the string.");
        }
        else
        {
            Console.WriteLine("The substring does not exits in the string.");
        }

        int Pos = SearchPosition(s, s3);
        Console.WriteLine($"The substring is at {Pos}th in string s.");

        Console.WriteLine("Enter the character to check: ");
        Char c = (Char)Console.Read();
        ChkAlphabet(c);

        Console.Write("Enter the substring you wanna search No times it appears in string s: ");
        string s4 = Console.ReadLine();
        int CountTimes = NoTimes(s, s4);
        Console.WriteLine($"The number of times substring appears in string s is: {CountTimes} times");

        Console.Write("Enter your substring you wanna insert in string s: ");
        string s5= Console.ReadLine();
        string s6 = InsertSubstring(s, s5);
        Console.WriteLine($"""After insert: "{s6}" """);
    }
    static string PrintString(string s) //Bai1
    {
        return s;
    }
    static int StringLength(string s) //Bai2
    {
        int NoS = 0;
        foreach (char c in s)
        {
            NoS++;
        }
        return NoS;
    }
    static string Bai3(string s) //Bai3
    {
        string temp = "";
        foreach (char c in s)
        {
            if (c != ' ')
            {
                temp += $"{c} ";
            }
        }
        return temp;
    }
    static string Bai4(string s) //Bai4
    {
        int n = s.Length;
        int j = n - 1;
        string temp = "";
        while (j >= 0)
        {
            if (s[j] != ' ')
            {
                temp += $"{s[j]} ";
            }
            j--;
        }
        return temp;
    }
    //s.Trim(); // Bo cac khoang trang du dau cuoi
    static int CountWord(string s) //Bai5
    {
        s = s.Trim();
        int count = 0;
        if (!string.IsNullOrEmpty(s))
        {
            count = 1;
        }
        int i = 0;
        while (i < s.Length)
        {
            if (s[i] == ' ' && s[i + 1] != ' ')
            {
                count++;
            }
            i++;
        }
        return count;
    }
    static bool[] CompareString(string s, string s2) //Bai6
    {
        bool Length;
        bool Same;
        if (s.Length == s2.Length)
        {
            Length = true;
            Same = true;
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] != s2[i])
                {
                    Same = false;
                    break;
                }
            }
        }
        else
        {
            Length = false;
            Same = false;
        }
        bool[] Result = new bool[2] { Length, Same };
        return Result;
    }
    static int[] A_D_SC(string s) //Bai7
    {
        int D = 0;
        int A = 0;
        int SC = 0;
        s = s.ToLower();
        foreach (char c in s)
        {
            if (c >= '0' && c <= '9')
            {
                D++;
            }
            else if (c >= 'a' && c <= 'z')
            {
                A++;
            }
            else
            {
                SC++;
            }
        }
        int[] Result = new int[3] { A, D, SC };
        return Result;
    }
    static int[] Vowel_Consonant(string s) //Bai8
    {
        int V = 0;
        int C = 0;
        s = s.ToLower();
        foreach (char c in s)
        {
            if (c == 'u' || c == 'e' || c == 'o' || c == 'a' || c == 'i')
            {
                V++;
            }
            else if (c >= 'a' && c <= 'z')
            {
                C++;
            }
        }
        int[] Result = new int[2] { V, C };
        return Result;
    }
    static bool ChkSubstring̣(string s, string s3) //Bai9
    {
        bool Result = s.Contains(s3);
        return Result;
    }
    static int SearchPosition(string s, string s3) //Bai10
    {
        int Result = s.IndexOf(s3);
        return Result;
    }
    static void ChkAlphabet (char c) //Bai11
    {
        if (Char.IsLetter(c))
        {
            if (Char.IsUpper(c))
            {
                Console.WriteLine("The entered character is an alphabet in upper case");
            }
            else
            {
                Console.WriteLine("The entered character is an alphabet in lower case");
            }
        }
        else
        {
            Console.WriteLine("The entered character is not an alphabet.");
        }
    }
    static int NoTimes (string s, string s4) //Bai12
    {
        int CountTimes = 0;
        int strtindex = s.IndexOf(s4);
        if (strtindex != -1)
        {
            CountTimes = 1;
            while (strtindex != -1 && strtindex < s.Length)
            {
                strtindex = s.IndexOf(s4, strtindex + 1);
                if (strtindex != -1)
                {
                    CountTimes++;
                }
            }
        }
        else
        {
            CountTimes = 0;
        }
        return CountTimes;
    }
    static string InsertSubstring (string s, string s5) //Bai13
    {
        s = s5 + " " + s.Trim();
        return s;
    }
}
