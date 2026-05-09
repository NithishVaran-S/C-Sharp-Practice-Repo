public class Solution {
    public int LengthOfLongestSubstring(string s) {
    
        int big = 0; 
        for (int i = 0; i < s.Length; i++)
        {   
            int count = 0;
            HashSet<char> check = new HashSet<char>();
            for (int j = i; j < s.Length; j++)
            {
                if (check.Contains(s[j])){
                    break;
                }
                else{
                    count += 1;
                    check.Add(s[j]);
                }
                if (count > big){
                    big = count;
                }
            }
        }
        return big;
    }
}