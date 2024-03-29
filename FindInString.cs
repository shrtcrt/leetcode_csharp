namespace leetcode;

public class FindInString
{
    public void RunCases()
    {
        var  haystack = "sadbutsad";
        var needle = "sad";
    
        Console.WriteLine($"Expect 0 {StrStr(haystack, needle)}");
        // Output: 0
        //Explanation: "sad" occurs at index 0 and 6.
        // The first occurrence is at index 0, so we return 0.

        haystack = "leetcode";
        needle = "leeto";

        Console.WriteLine($"Expect -1 {StrStr(haystack, needle)}");
        
        //Output: -1
        //Explanation: "leeto" did not occur in "leetcode", so we return -1.

    }

    // find the first occurence of needle in the haystack
    // returns index
     public int StrStr(string haystack, string needle) {
        return haystack.IndexOf(needle);
    }
}
