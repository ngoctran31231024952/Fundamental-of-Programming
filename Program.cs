
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BT_code_ngay_12_8; 
    internal class Baitap
    {
    static void Main(string[] args)
    {
        int val = 55;
        Console.WriteLine("Hello " + "World");
        Console.WriteLine("Value = " + val); //concatenated string
        Console.WriteLine("Value = {0}", val); //Formatted String
        Baitap0();
        Baitap1_1();
        Baitap1_2();
        Baitap1_3();
        Baitap1_4();
        Baitap1_5();
        Baitap1_6();
        Baitap1_7();
        Baitap1_8();
        Baitap1_9();
        Baitap1_10();
        
    }
        static void Baitap0()
        {
            var name = "Mark";
            var date = DateTime.Now;


            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now", name, date.DayOfWeek, date);
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}," + $"it's {date:HH:mm} now");
        }
        static void Baitap1_1()
        {
            Console.Write("Enter value:"); 
            var userInput = Console.ReadLine();
            int a = Convert.ToInt32(userInput);
            Console.Write("Enter value:");
            userInput = Console.ReadLine();
            double b = Convert.ToDouble(userInput);
            Console.Write("Sum two numbers:");
            Console.WriteLine($"{a + b}");
        }
        static void Baitap1_2 ()
        {
            Console.WriteLine("Enter two int numbers!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"before swap a={a}, b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"after swap a={a}, b={b}");
        }
        static void Baitap1_3 ()
        {
            Console.WriteLine("Enter two float numbers!");
            Double a = Convert.ToDouble(Console.ReadLine());
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Multify two floating point numbers:{a * b}"); 
        }
    static void Baitap1_4()
        {
        Console.WriteLine("Enter the number of feet!");
        Double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Convert feet to meter:{feet * 0.3048}");
        }
    static void Baitap1_5()
    {
        Console.WriteLine("Enter degree in Celsius!");
        Double Celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Degree in Fahrenheit:{Celsius * 1.8 + 32}");
        Console.WriteLine("Enter degree in Fahrenheit!");
        Double Fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Degree in Celsius:{(Fahrenheit - 32) / 1.8}");
    }
    static void Baitap1_6()
    {
        Console.WriteLine($"Size of Char:{sizeof(char)}");
        Console.WriteLine($"Size of Int:{sizeof(int)}");
        Console.WriteLine($"Size of Double:{sizeof(double)}");
        Console.WriteLine($"Size of Float:{sizeof(float)}");
        Console.WriteLine($"Size of Bool:{sizeof(bool)}");
    }
    static void Baitap1_7()
    {
        Char kitu;
        Console.Write("Enter a character: ");
        var userInput = Console.ReadLine();
        kitu= Convert.ToChar(userInput);
        int ASCII = kitu;
        Console.WriteLine($"The Ascii value of '{kitu}' is {ASCII}");
    }
    static void Baitap1_8()
    {
        const double PI = 3.14;
        Console.Write("Enter r:");
        Double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Area of Circle:{PI * r *r}");
    }
    static void Baitap1_9()
    {
        Console.Write("Enter the length of a side: ");
        Double side = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Area of square:{side * side}");
    }
    static void Baitap1_10()
    {
        int ndays, year, week, day, DaysInWeek = 7;
        Console.Write("Enter the number of days:");
        ndays = Convert.ToInt32(Console.ReadLine());
        year = ndays / 365;
        week = (ndays % 365) / DaysInWeek;
        day = (ndays % 365) % DaysInWeek;
        Console.WriteLine($"{ndays} days is equivalent to {year} years, {week} weeks, {day} days");
    }

}
