public class Solution {
    public int Reverse(int x) {
        int num = 0;
        while (x != 0)
        {  
            if (num > int.MaxValue/10 || num < int.MinValue/10)
            {
                return 0;
            }
            num = (num*10)+(x%10);
            x = x/10 ;
        }
        
        Console.WriteLine(num);
        return num;
    }
}