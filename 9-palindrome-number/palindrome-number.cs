public class Solution {
    public bool IsPalindrome(int x) {
        string num = x.ToString();
        int left = 0;
        int right = (num.Length) - 1;
        if (x<0){
            return false;
        }
        else if (x==0){
            return true;
        }
        else {
            while (left < right){
                if (num[left]==num[right]){
                    left += 1;
                    right -= 1;
                }
                else{
                    return false;
                }
            }
        }
        return true;
    }
}