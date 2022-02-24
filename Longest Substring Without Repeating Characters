/*
https://leetcode.com/problems/longest-substring-without-repeating-characters/
Given a string s, find the length of the longest substring without repeating characters.
*/


public class Solution 
{
    
        public int LengthOfLongestSubstring(string s)
    {
        string substring = "";
        List<string> substring_lengths = new List<string>();

        if (s == "")
        {
            return 0;
        }

        else if (s.Length == 2 && s[0] != s[1])
        {
            return 2;
        }
        else
        {
            substring_lengths.Add(" ");
            for (int i = 0; i < s.Length - 1; i++)
            {
                substring = "";
                substring += s[i];
                substring_lengths.Add(substring);
                for (int x = i + 1; x < s.Length; x++)
                {
                    if(substring.Contains(s[x]))
                    {
                        substring_lengths.Add(substring);
                        break;
                    }
                    else
                    {
                        
                        substring += s[x];
                        substring_lengths.Add(substring);
                    }
                }
            }


            return substring_lengths.Max(s => s.Length);
        }
}
}
