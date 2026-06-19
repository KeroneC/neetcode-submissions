public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        var map = new Dictionary<char, int>();

        foreach(char c in s){
            
            if(map.ContainsKey(c)){
                map[c]++;
            }else{
                map[c] = 1;
            }
        }

        foreach(char c in t){

            if(map.ContainsKey(c)){
                if(map[c] < 1){
                    return false;
                }else{
                    map[c]--;
                }
            }else{
                return false;
            }
        }

        return true;
    }
}
