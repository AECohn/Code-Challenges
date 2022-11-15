/*
https://leetcode.com/problems/valid-parentheses/

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
*/

public class Solution 
{
     public bool IsValid(string s)
    {
        Stack<char> Evaluator = new Stack<char>();

        foreach(char character in s)
        {

            switch (character)
            {

                case ('('):
                    {
                        Evaluator.Push(')');
                        break;
                    }
                case ('['):
                    {
                        Evaluator.Push(']');
                        break;
                    }

                case ('{'):
                    {
                        Evaluator.Push('}');
                        break;
                    }

                default:
                    {
                        if(Evaluator.Count > 0)
                        {
                            if(Evaluator.Pop() != character)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    }
            }                   
            
        }

        return (Evaluator.Count == 0);
    }
}
