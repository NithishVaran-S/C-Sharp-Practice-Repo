public class Solution {

    public bool CanReach(int[] arr, int start) {

        if (start < 0 || start >= arr.Length || arr[start] < 0)
        {
            return false;
        }

        if (arr[start] == 0)
        {
            return true;
        }

        arr[start] = -arr[start];

        return CanReach(arr, start + arr[start]) ||
               CanReach(arr, start - arr[start]);
    }
}