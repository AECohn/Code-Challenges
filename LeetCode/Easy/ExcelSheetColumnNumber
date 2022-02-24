/*
https://leetcode.com/problems/excel-sheet-column-number/

Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.
*/

public class Solution 
{
    public int TitleToNumber(string columnTitle) 
       {
        char[] reverseColumn = columnTitle.ToCharArray();
        Array.Reverse((reverseColumn));

        double value = 0;

        for (int i = 0; i < reverseColumn.Length; i++)
        {
            double formula = (reverseColumn[i] - 64) * (Math.Pow(26, (double) i));
            value += formula;
        }

        return (int) value;
    }
}


