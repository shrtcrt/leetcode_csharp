namespace leetcode;

public class FindTheDifferenceRunner
{
    public void RunCases()
    {
        // Case One
        var s = "abcd";
        var  t = "abcde";

        Console.WriteLine($"Looking for e {FindTheDifference(s, t)}");

        s = "";
        t = "y";

        Console.WriteLine($"Looking for y {FindTheDifference(s, t)}");
    }


    // given two strings, s and t
    // return the letter that was added to t
    public char FindTheDifference(string s, string t) {
       // if (string.IsNullOrWhiteSpace(s)) return char.Parse(t);

        int result = 0;

            foreach (char c in t) result += c;

            foreach (char c in s) result -= c;
            
            return (char)result;     


            s = String.Concat(s.OrderBy(c => c));
        t = String.Concat(t.OrderBy(c => c));

        for (int i = 0; i < s.Length; i++)
        {
            if (t[i] == s[i]) continue;
            return t[i];
        }
        return t[t.Length-1];

        
    }
}
