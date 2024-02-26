// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        GradeCalculator();
        TemperatureConverter();
    }

    static void GradeCalculator()
    {
        Console.WriteLine("Grade Calculator\n");

        Console.Write("Enter marks for Mathematics: ");
        if (!double.TryParse(Console.ReadLine(), out double mathMarks) || mathMarks < 0 || mathMarks > 100)
        {
            Console.WriteLine("Invalid input for Mathematics marks. Marks should be between 0 and 100.");
            return;
        }

        Console.Write("Enter marks for Science: ");
        if (!double.TryParse(Console.ReadLine(), out double scienceMarks) || scienceMarks < 0 || scienceMarks > 100)
        {
            Console.WriteLine("Invalid input for Science marks. Marks should be between 0 and 100.");
            return;
        }

        Console.Write("Enter marks for English: ");
        if (!double.TryParse(Console.ReadLine(), out double englishMarks) || englishMarks < 0 || englishMarks > 100)
        {
            Console.WriteLine("Invalid input for English marks. Marks should be between 0 and 100.");
            return;
        }

        double averageMarks = (mathMarks + scienceMarks + englishMarks) / 3;
        Console.WriteLine($"\nAverage marks: {averageMarks}\n");

        char finalGrade = GetGrade(averageMarks);
        Console.WriteLine($"Final Grade: {finalGrade}");
    }

    static char GetGrade(double averageMarks)
    {
        char grade;
        switch (averageMarks / 10)
        {
            case 10:
            case 9:
                grade = 'A';
                break;
            case 8:
                grade = 'B';
                break;
            case 7:
                grade = 'C';
                break;
            case 6:
                grade = 'D';
                break;
            default:
                grade = 'F';
                break;
        }
        return grade;
    }

    static void TemperatureConverter()
    {
        Console.WriteLine("\nTemperature Converter\n");

        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine("Choose the temperature scale to convert from:");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                continue;
            }

            double temperature;
            string scaleFrom, scaleTo;

            if (choice == 1)
            {
                Console.Write("\nEnter the temperature in Celsius: ");
                if (!double.TryParse(Console.ReadLine(), out temperature))
                {
                    Console.WriteLine("Invalid input for temperature.");
                    continue;
                }
                scaleFrom = "Celsius";
                scaleTo = "Fahrenheit";
                temperature = (temperature * 9 / 5) + 32;
            }
            else
            {
                Console.Write("\nEnter the temperature in Fahrenheit: ");
                if (!double.TryParse(Console.ReadLine(), out temperature))
                {
                    Console.WriteLine("Invalid input for temperature.");
                    continue;
                }
                scaleFrom = "Fahrenheit";
                scaleTo = "Celsius";
                temperature = (temperature - 32) * 5 / 9;
            }

            Console.WriteLine($"\n{temperature}{scaleTo} is equal to {temperature}{scaleFrom}.\n");

            Console.Write("Do you want to convert another temperature? (Y/N): ");
            char again = Console.ReadLine().ToUpper()[0];
            repeat = (again == 'Y');
        }

        Console.WriteLine("\nThank you for using the temperature converter!");
    }
}
