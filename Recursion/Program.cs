using System;

public class Factorial
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give me an int\n");
        string n = Console.ReadLine();
        var isInputValid = int.TryParse(n, out int num);
        if (!isInputValid)
            Console.WriteLine("Invalid input");
        else
        {
            int result = CalculateFactorial(num);
            Console.WriteLine(result);
        }

    }

    public static int CalculateFactorial(int num)
    {
        int result = 1;
        if (num == 1)
        {
            return 1;
        }
        else
        {
            result = num * CalculateFactorial(num - 1);
        }
        return result;
    }
}