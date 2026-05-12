public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int point = 0;
        int count = 0;

        for (int i = 0; i<nums.Length; i++)
        {
            if (nums[i]!=val)
            {
                nums[point] = nums[i];
                point += 1;
                count += 1;
            }
        }

        for (int i = point+1; i<nums.Length; i++)
        {
            nums[i] = 0;
        }

        return count;
    }
}