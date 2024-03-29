using System.Text;

namespace leetcode;

public class Anagram
{
    public void RunCases()
    {
        var s = "anagram";
        var  t = "nagaram";

        // Output: true
        Console.WriteLine($"True {IsAnagram(s, t)}");


        s = "rat"; 
        t = "car";

        Console.WriteLine($"false {IsAnagram(s, t)}");

        s = "aacc"; 
        t = "ccac";

        Console.WriteLine($"false {IsAnagram(s, t)}");
        //Output: false
    }

    //return true if this is an anagram
    // An Anagram is a word or phrase formed by rearranging 
    // the letters of a different word or phrase, typically using all the original letters exactly once.
    public bool IsAnagram(string s, string t) {
       var first = s.ToCharArray();
       var word = new StringBuilder();

       word.Append(t); 

       foreach (var each in first)
       {
            word.Replace(each.ToString(), string.Empty);
            //t = t.Replace(each.ToString(), string.Empty);
       }

        return word.Length == 0 ? true : false;
       
    }
}
