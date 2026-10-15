public class Solution {

    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hash = new Dictionary<int, int>();
        int[] ind = [0,0];
        for (int i = 0;  i < nums.Length; i++){
            int dif = target - nums[i];
            if (hash.ContainsKey(dif)){
                ind[0] = hash[dif]; 
                ind[1] = i; 
                break;
            }
            else{
                hash.Add(nums[i], i);
            }
        }
        return ind;
    }
}
