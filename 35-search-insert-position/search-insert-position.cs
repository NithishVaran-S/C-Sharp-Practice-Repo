public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0;
        int right = nums.Length;
        int mid = (left + right) / 2;
        bool res = false;
        while (left < right)
        {
            Console.WriteLine(mid);
            if (target < nums[mid])
            {
                right = mid;
                mid = (left + right)/2;
            }
            else if (target > nums[mid])
            {
                left = mid + 1;
                mid = (left + right)/2;   
            }
            else
            {
                res = true;
                break;
            }
            
        }
        return mid;
    }
}