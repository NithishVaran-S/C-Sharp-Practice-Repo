public class Solution {
    public int LengthOfLastWord(string s) {

        string[] strs = s.Split(' ');

        for (int i = strs.Length - 1; i >= 0; i--)
        {
            if (!string.IsNullOrEmpty(strs[i]))
            {
                return strs[i].Length;
            }
        }

        return 0;
    }
}