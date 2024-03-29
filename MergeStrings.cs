// https://leetcode.com/problems/merge-strings-alternately/?envType=study-plan-v2&envId=programming-skills

using System.Text;

namespace leetcode;

/// <summary>
/// Given two strings, merge the strings like a zipper starting with word 1
/// </summary>
public class MergeStrings
{
    public void RunCases()
    {        
        var word1 = "abc";
        var word2 = "pqr";

        Console.WriteLine($"Merge Strings: Case One: apbqcr: {MergeAlternately(word1, word2)}");

        word1 = "ab";
        word2 = "pqrs";

        Console.WriteLine($"Merge Strings: Case Two: apbqrs: {MergeAlternately(word1, word2)}");

        word1 = "abcd";
        word2 = "pq";

        Console.WriteLine($"Merge Strings: Case Three: apbqcd: {MergeAlternately(word1, word2)}");
        
    }

    public string MergeAlternately(string word1, string word2) {
        var lenOne = word1.Length;
        var lenTwo = word2.Length;

        Console.WriteLine($"{lenOne} {lenTwo}");

        var combinedWord = new StringBuilder();
        
        for (int i = 0; i < lenOne; i++)
        {
            combinedWord.Append(word1.Substring(i, 1));

            if (i < lenTwo)
            {
                combinedWord.Append(word2.Substring(i, 1));
            }
            Console.WriteLine($"Letter: {combinedWord.ToString()}");    
        }

        if (lenTwo > lenOne)
        {
            combinedWord.Append(word2.Substring(lenOne, lenTwo - lenOne));
        }

        
        
        return combinedWord.ToString();
    }
}
