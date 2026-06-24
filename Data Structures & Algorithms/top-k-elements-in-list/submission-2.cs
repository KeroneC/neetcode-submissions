
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // Step 1: Build frequency map
        var map = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (map.ContainsKey(num))
                map[num]++;
            else
                map[num] = 1;
        }

        // Step 2: Build bucket where index = frequency
        var bucket = new List<int>[nums.Length + 1];
        foreach (var pair in map)
        {
            int freq = pair.Value;
            if (bucket[freq] == null)
                bucket[freq] = new List<int>();

            bucket[freq].Add(pair.Key);
        }

        // Step 3: Traverse bucket from high to low
        var result = new List<int>();
        for (int i = bucket.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (bucket[i] != null)
            {
                foreach (int num in bucket[i])
                {
                    result.Add(num);
                    if (result.Count == k)
                        break;
                }
            }
        }

        return result.ToArray();
    }
}