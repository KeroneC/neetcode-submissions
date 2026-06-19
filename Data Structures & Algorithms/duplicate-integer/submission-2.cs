public class Solution {
    public bool hasDuplicate(int[] nums) {

        var set = new HashSet<int>();

        foreach(int num in nums){

            if(set.Contains(num)){
                return true;
            }else{
                set.Add(num);
            }
        }

        return false;

    }
}
