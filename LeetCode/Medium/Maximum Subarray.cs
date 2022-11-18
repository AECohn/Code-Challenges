public class Solution
{
    static void Main()
    {
        Console.WriteLine(MaxSubArray(new int[] {-2,1,-3,4,-1,2,1,-5,4}));
    }

    static public int MaxSubArray(int[] nums)
    {
        int count;
        int HighestNumber = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            count = 0;
            for (int x = i; x < nums.Length; x++)
            {
                count += nums[x];
                if (count > HighestNumber)
                {
                    HighestNumber = count;
                }
            }
        }

        return HighestNumber;

    }
}