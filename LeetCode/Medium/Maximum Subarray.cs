public class Solution
{
    static void Main()
    {
        Console.WriteLine(MaxSubArray(new int[] {5,4,-1,7,8}));
    }

    static public int MaxSubArray(int[] nums)
    {
        var temp = GetSubArraySizes(nums);
        return temp.Max();
    }

   
    static public List<int> GetSubArraySizes(int[] array)
    {
        var Sizes = new List<int>();
        int count;
        for (int i = 0; i < array.Length; i++)
        {
            count = 0;
            for (int x = i; x < array.Length; x++)
            {
                count += array[x];
                Sizes.Add(count);
            }

        }
        return Sizes;
    }
}