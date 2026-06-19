public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        var dict = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){

            if(dict.ContainsKey(s[i])){
                dict[s[i]]++;
            }else{

                dict[s[i]] = 1;
            }
        }

        foreach(char c in t){

            if(dict.ContainsKey(c)){
                if(dict[c] < 1){
                    return false;
                }else{
                    dict[c]--;
                }
            }else{
                return false;
            }
        }

        return true;

    }

}
