﻿// See https://aka.ms/new-console-template for more information

 static void task1()
{
        //периметр прямокутного трикутника за двома катетами?
        double firstCat;
        double secondCat;
        double hypotenuse;
        double perimeter;


        Console.WriteLine("\nTask1 !");
        Console.Write("First cat: ");
        firstCat = Convert.ToDouble(Console.ReadLine());
        Console.Write("Second cat: ");
        secondCat = Convert.ToDouble(Console.ReadLine());

        hypotenuse = Math.Sqrt(firstCat * firstCat + secondCat * secondCat);

        perimeter = firstCat + secondCat + hypotenuse;

        Console.WriteLine("Perimeter=" + perimeter);
    }

    static void task2()
    {
        //чи однакові цифри даного двозначного числа?
        int number;
        int suportNumber;

        Console.WriteLine("\nTask2 !");
        Console.Write("Enter a two significant number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (Math.Abs(number) > 99 || Math.Abs(number) < 10)
        {
            Console.WriteLine("wrong number entered");
            return;
        }

        suportNumber = number % 10;

        if (suportNumber != (number - suportNumber) / 10)
        {
            Console.WriteLine("false");
            return;
        }

        Console.WriteLine("true");
        return;
    }

    static void task3()
    {
        //Дана точка на площині з координатами(х, у). Скласти
        //програму на c#, яка видає одне з повідомлень "Так", "Ні", "На межі" залежно від того, 
        //чи лежить точка всередині заштрихованої області, поза заштрихованої області або
        //на її межі. Області задаються наступним чином: 
        //y = -| x |

        double x;
        double y;
        double functionValue;

        Console.WriteLine("Enter the coordinate x:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the coordinate y:");
        y = Convert.ToDouble(Console.ReadLine());

        functionValue = -Math.Abs(x);

        if (y > functionValue)
        {
            Console.WriteLine("true");
        }
        else if (y < functionValue)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("On the border");
        }
    }

    static void task4()
    {
        Console.WriteLine("Enter the number of months that have passed:");
        int m = Convert.ToInt32(Console.ReadLine());

        DateTime now = DateTime.Now;
        DateTime unknownDate = now.AddMonths(-m);

        string monthName = unknownDate.ToString("MMMM");
        Console.WriteLine($"Month of unknown date: {monthName}");

        Console.ReadLine();
    }

    static void task5()
    {
        double dividend = 10.0;
        double divisor = 3;

        Console.WriteLine("Enter the dividend:");
        dividend = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the divisor:");
        divisor = Convert.ToDouble(Console.ReadLine());

        double quotient = Divide(dividend, divisor);
        Console.WriteLine($"Fraction {dividend} on {divisor} = {quotient}");

        Console.ReadLine();
    }

    static double Divide(double dividend, double divisor)
    {
        if (divisor == 0)
        {
            Console.WriteLine("Division by zero is impossible");
            return 0;
        }

        double quotient = dividend / divisor;
        return quotient;
    }

    static void task6()
    {
        double a = 10.0;
        double b = 3;

        Console.WriteLine("Enter the a:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the b:");
        b = Convert.ToDouble(Console.ReadLine());

        double result = (a / (a * a + 1)) + (b / (b * b + 1));
        Console.WriteLine("result:" + result);

        Console.ReadLine();
    }



}

