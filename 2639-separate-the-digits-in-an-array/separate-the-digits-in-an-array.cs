public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> res = new List<int>();
        foreach (int num in nums)
        {
            if (num < 10)
            {
                res.Add(num);
            }
            else
            {
                string temp = num.ToString();
                foreach (char c in temp)
                {
                    res.Add(c - '0');
                }
            }
        }
        return res.ToArray();
    }
}