using System;

class Program
{
    static void Main(string[] args)
    {
        SwitchCalcuClass.SimpleCalculator();
    }
}
public class SwitchCalcuClass
{
    public static void SimpleCalculator()
    {
        Console.Write("First number: ");
        var firstNum = Console.ReadLine();
        Console.Write("Second number: ");
        var secondNum = Console.ReadLine();

        if (double.TryParse(firstNum, out double num1) && double.TryParse(secondNum, out double num2))
        {
            Console.Write("(+, -, *, /): ");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot be divided by zero");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("That is not a number -_-");
        }
        
    }
}
