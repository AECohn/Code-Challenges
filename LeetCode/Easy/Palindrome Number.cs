/*
https://leetcode.com/problems/palindrome-number/

Given an integer x, return true if x is palindrome integer.

An integer is a palindrome when it reads the same backward as forward.

For example, 121 is a palindrome while 123 is not.
*/


public class Solution 
{
    public bool IsPalindrome(int x)
    {
        string numstring = x.ToString();
        int counter = numstring.Length;

        for (int i = 0; i < counter; i++)
        { 
            counter--;
            if (numstring[i] != numstring[counter])
                {
                return false;
                }
            
        }
        return true;
    }
}
