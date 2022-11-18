/*
https://leetcode.com/problems/contains-duplicate

Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
*/

public class Solution 
{
    public bool ContainsDuplicate(int[] nums) 
    {
         return nums.Length != nums.ToHashSet().ToArray().Length;
    }
}