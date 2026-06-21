public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        if(strs == null || strs.Length == 0){
            return new List<List<string>>
            {
                new List<string> {""}
            };
        }

        var groups = new Dictionary<string, List<string>>();

        foreach(string word in strs){

            char [] charArray = word.ToCharArray();
            Array.Sort(charArray);
            string sortedWord = new string(charArray);

            if(!groups.ContainsKey(sortedWord)){
                groups[sortedWord] = new List<string>();
            }

            groups[sortedWord].Add(word);
        }

        return groups.Values.ToList<List<string>>();
    }
}
