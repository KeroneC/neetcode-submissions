public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hs = new HashSet<int>();

        for(int i = 0;  i < nums.Length; i++){

            if(hs.Contains(nums[i])){
                return true;
            }else{
                hs.Add(nums[i]);
            }
            
        }

        return false;
    }
}
