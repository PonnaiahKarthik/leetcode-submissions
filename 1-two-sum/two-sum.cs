public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var set = new Dictionary<int,int>();

        for(int i =0 ;i<nums.Length;i++){

            if(set.ContainsKey(nums[i])){
                return [i, set[nums[i]]];
            }
            else{
                set.TryAdd(target-nums[i],i);
            }
        }
        return [0,0];
    }
}