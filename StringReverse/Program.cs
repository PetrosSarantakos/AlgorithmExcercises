using System;

public class StringReverse
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give me a string\n");
        string n = Console.ReadLine();
        
        if(string.IsNullOrEmpty(n))
        {
            Console.WriteLine("String is null or empty");
        }
        else
        {
            string result = ReverseString(n);
            Console.WriteLine(result);
        }

    }

    private static string ReverseString(string? n)
    {
        char[] stringChars = n.ToCharArray();
        string result = "";

        for(int i = n.Length - 1; i >= 0; i--)
        {
            result += stringChars[i];
        }

        return result;
    }

}