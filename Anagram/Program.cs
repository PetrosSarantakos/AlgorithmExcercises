using System;

public class Palindrome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give me a string\n");
        string s1 = Console.ReadLine();
        Console.WriteLine("Give me a second string\n");
        string s2 = Console.ReadLine();

        if (string.IsNullOrEmpty(s1)|| string.IsNullOrEmpty(s2))
        {
            Console.WriteLine("String is null or empty");
        }
        else
        {
            bool isAnagram = CheckAnagram(s1.ToLower(),s2.ToLower());
            if (isAnagram)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("No Anagram");
            }
        }

    }

    private static bool CheckAnagram(string s1, string s2)
    {
        Dictionary<char, int> s1CharsCount = new Dictionary<char, int>();
        Dictionary<char, int> s2CharsCount = new Dictionary<char, int>();
        // Initialize with all letters of the alphabet
        for (char c = 'a'; c <= 'z'; c++)
        {
            s1CharsCount[c] = 0;
            s2CharsCount[c] = 0;
        }

        var s1Chars = s1.ToCharArray();
        var s2Chars = s2.ToCharArray();

        foreach (char c in s1Chars) 
        {
            s1CharsCount[c]++;
        }

        foreach (char c in s2Chars)
        {
            s2CharsCount[c]++;
        }

        for (char c = 'a'; c <= 'z'; c++){
            if (s1CharsCount[c] != s2CharsCount[c])
            {
                return false;
            }
        }

        return true;
    }

}