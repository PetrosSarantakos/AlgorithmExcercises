using System;

public class FibonacciSequence
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give me an int\n");
        string n = Console.ReadLine();
        var isInputValid=int.TryParse(n, out int num);
        if (!isInputValid)
            Console.WriteLine("Invalid input");
        else
        {
            int result = CalculateFibonacciSeq(num);
            Console.WriteLine(result);
        }
      
    }

    public static int CalculateFibonacciSeq(int num)
    {
        int fibonacciSum = 0;
        int temp = 1;
        for (int i = 0; i <= num; i++)
        {
            var old = fibonacciSum;
            fibonacciSum += temp;
            temp = old;
            Console.WriteLine(fibonacciSum);
        }
        return fibonacciSum;
    }
}