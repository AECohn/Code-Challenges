/*
https://leetcode.com/problems/remove-element/

Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.

Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.

Return k after placing the final result in the first k slots of nums.

Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
*/

public class Solution 
{
    public int RemoveElement(int[] nums, int val)
   {
   
            int counter = 0;

            if (Check_all())
            {
                for (int i = nums.Length - 1; i >= 0; i--)
                    if (nums[i] == val && i != nums.Length - 1)
                        Shifter(i);

                return (Array.FindAll(nums, (x => x != val)).Length);
            }
            else
                return (Array.FindAll(nums, (x => x != val)).Length);

            bool Check_all()
            {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                    if (nums[i] == val)
                        count++;

                if (count != nums.Length)
                    return (true);
                else
                    return (false);
            }

            void Shifter(int start)
            {
                counter++;
                int swap = nums[start];

                for (int shift = start; shift < nums.Length - 1; shift++)
                    nums[shift] = nums[shift + 1];

                nums[nums.Length - 1] = swap;

                if (nums[start] == val && counter <= nums.Length)
                    Shifter(start);
            }
        
    }
}
