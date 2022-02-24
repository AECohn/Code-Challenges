/*
https://leetcode.com/problems/longest-common-prefix/

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
*/



public class Solution 
{
   public string LongestCommonPrefix(string[] strs)
    {
       string Output;
        List<string> Prefixes = new List<string>();
        string prefix = "";
        int count;
        string shortestString = strs.OrderBy(c => c.Length).FirstOrDefault();

        for (int i = 0; i < shortestString.Length; i++)
        { 
            count = 0;
            prefix += shortestString[i];
            foreach (string word in strs)
            {
                if (word.StartsWith(prefix))
                {
                    count++;
                }
            }
                if(count == strs.Length)
            {
                Prefixes.Add(prefix);
            }
        }
            Output = Prefixes.Max();
        if(Output == null)
        {
            return "";
        }
        else
        {
            return Output;
        }      
    }
}
