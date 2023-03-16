using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using PalindromeExercise;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        string reversedWord = "";

        for (int i = word.Length; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        return (word.ToLower() == reversedWord.ToLower());
        
    }
}

 
