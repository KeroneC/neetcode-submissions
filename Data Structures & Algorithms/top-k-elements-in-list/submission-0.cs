public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var map = new Dictionary<int, int>();

        foreach(int num in nums){

            if(!map.ContainsKey(num)){
                map[num] = 1;
            }else{
                map[num]++;
            }
        }

        var topK = map.OrderByDescending(pair => pair.Value)
                        .Take(k)
                        .Select(pair => pair.Key)
                        .ToArray(); // Convert to array

        return topK;

        
    }
}
