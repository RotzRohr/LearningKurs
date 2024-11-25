namespace Palindromprüfung;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gib ein Wort ein:");
        string word = Console.ReadLine().ToLower();
        string reversedWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        if (word == reversedWord)
        {
            Console.WriteLine($"Das Wort ist ein Palindrom. ({word} = {reversedWord})");
        }
        else
        {
            Console.WriteLine($"Das Wort ist kein Palindrom. ({word} != {reversedWord})");
        }
    }

    public static bool isPalindrome(string word)
    {
        word = word.ToLower();
        string reversedWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        return word == reversedWord;
    }
}