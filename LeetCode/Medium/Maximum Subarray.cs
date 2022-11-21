public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int HighestNumber = nums[0];

        int i = 0;

        int Counter(int newValue, int currentCount)
        {
            int value = currentCount + newValue;

            if (nums[i] > value)
            {
                value = nums[i];
            }

            if (value > HighestNumber)
            {
                HighestNumber = value;
            }

            i++;


            if (i == nums.Length)
            {
                return value;
            }


            Counter(nums[i], value);
            return HighestNumber;
        }

        int output = Counter(nums[0], 0);

        return output;
}
}