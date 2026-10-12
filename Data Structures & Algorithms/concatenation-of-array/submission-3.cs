public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length; 
        List<int> numbers = Enumerable.Repeat(0, len * 2).ToList(); 
        int i = 0; 
        foreach(int num in nums) {
            numbers[i] = num;
            numbers[len + i] = num;
            i++;
        }
        return numbers.ToArray();
    }
}