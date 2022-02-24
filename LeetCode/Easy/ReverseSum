/*
https://leetcode.com/problems/reverse-integer/

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
*/


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[]{i, j};
                }
            }

        }

        return new int[] {0,0};
    }
}
