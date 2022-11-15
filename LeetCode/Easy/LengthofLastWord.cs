/*
https://leetcode.com/problems/length-of-last-word/

Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.
*/

public class Solution 
{

    public static void Main()
    {
        Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
    }
    public static int LengthOfLastWord(string s)
    {
        var Words = s.Split(' ').ToList();
        Words.RemoveAll(x => x == "");
        return Words[Words.Count - 1].Length;
    }
}