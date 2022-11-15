// See https://aka.ms/new-console-template for more information

public class Solution 
{

    public static void Main()
    {
        Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
    }
    public static int LengthOfLastWord(string s)
    {
        List<string> Words = s.Split(' ').ToList();
        Words.RemoveAll(x => x == "");
        return Words[Words.Count - 1].Length;


    }
}