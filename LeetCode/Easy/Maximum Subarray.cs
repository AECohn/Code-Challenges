public class Solution
{
    static void Main()
    {
        GetSubArrays(new int[] {1, 2, 3, 4});
    }

    static public int MaxSubArray(int[] nums)
    {

        
        for (int i = 0; i < nums.Length; i++)
        {
            
        }

        return 0;
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