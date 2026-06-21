public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        if(strs == null || strs.Length == 0){
            return new List<List<string>>
            {
                new List<string> {""},
            };
        }

        var result = new List<List<string>>();

        var map = new Dictionary<string, List<string>>();

        foreach(string word in strs){

            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            string sortedWord = new string(charArray);

            if(!map.ContainsKey(sortedWord)){
                map[sortedWord] = new List<string>();
            }

            map[sortedWord].Add(word);
        }

        return map.Values.ToList<List<string>>();

       
        
    }
}
