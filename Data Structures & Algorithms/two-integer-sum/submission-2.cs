public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var map = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            int compliment = target - nums[i];

            if(map.ContainsKey(compliment)){

                return new int[] {map[compliment], i};

            }else{

                map[nums[i]] = i;

            }

        }

        return null;
    }
}
