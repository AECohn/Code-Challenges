/*

https://leetcode.com/problems/reverse-integer/

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
*/


public class Solution 
{
    public int Reverse(int x)
    {
        try
        {
        string startstring = x.ToString();
        string reversestring = "";

        if (startstring[0] == '-')
        {
            reversestring = "-";
            for (int i = startstring.Length - 1; i >= 1; i--)
            {
                reversestring += startstring[i].ToString();
            }
        }
        else
        {
            for (int i = startstring.Length - 1; i >= 0; i--)
            {
                reversestring += startstring[i].ToString();
            }
        }

     

        return Convert.ToInt32(reversestring);
        }
        catch
        {
            return 0;
        }
        

    }
}
