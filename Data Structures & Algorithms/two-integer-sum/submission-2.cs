public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int dif = target - nums[i];

            if (hash.TryGetValue(dif, out int j)) {
                return new int[] { j, i };
            }

            hash[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}