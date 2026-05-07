public class Solution {
    public int MyAtoi(string s) {

        int sol = 0;
        int sign = 1;
        int i = 0;

        while (i < s.Length && s[i] == ' ')
        {
            i++;
        }

        if (i < s.Length && (s[i] == '+' || s[i] == '-'))
        {
            if (s[i] == '-')
            {
                sign = -1;
            }

            i++;
        }

        while (i < s.Length && char.IsDigit(s[i]))
        {
            int digit = s[i] - '0';

            if (sol > int.MaxValue / 10 ||
               (sol == int.MaxValue / 10 && digit > 7))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            sol = (sol * 10) + digit;

            i++;
        }

        return sign * sol;
    }
}