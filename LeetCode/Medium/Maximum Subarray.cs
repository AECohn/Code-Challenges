public class Solution
{
    static void Main()
    {
        Console.WriteLine(MaxSubArray(new int[] {5, 4, -1, 7, 8}));
    }

    static public int MaxSubArray(int[] nums)
    {
        var temp = GetSubArrays(nums);
        var Sums = new int[temp.Count];
        for (int i = 0; i < temp.Count; i++)
        {
            Sums[i] = temp[i].Sum();
        }

        return Sums.Max();
    }

    static public List<List<int>> GetSubArrays(int[] array)
    {
        var SubArrays = new List<List<int>>();
        for (int i = 0; i < array.Length; i++)
        {
            var tempList = new List<int>();
            for (int x = i; x < array.Length; x++)
            {
                tempList.Add(array[x]);
                SubArrays.Add(new List<int>(tempList));
            }
        }

        return SubArrays;
    }
}