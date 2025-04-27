public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] twoSum = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int x = 0; x < nums.Length - 1; x++)
            {
                if (nums[i] + nums[x] == target)
                {
                    Console.WriteLine(x);
                    twoSum[0] = x;
                    twoSum[1] = i;
                    break;
                }
            }
        }
        return twoSum;
    }
}
