//Using the C# language, have the function LongestWord(sen) take the sen parameter being passed and return the largest word in the string. If there are two or more words that are the same length, return the first word from the string with that length. Ignore punctuation and assume sen will not be empty. 
//--------------------------------------------------------------------------------------------------------
using System;

namespace Challenges
{
    public class LongestWord
    {
        public static string Run(string sen)
        {
            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */
            string[] words = sen.Split(' ');
            string w = "", w2 = "", lw = "";
            int s1, s2;
            for (int i = 0; i < words.Length - 1; i++)
            {
                w = words[i];
                s1 = w.Length;
                w2 = words[i + 1];
                s2 = w2.Length;

                if (s1 > s2)
                    lw = w;
                else if (s2 > s1)
                    lw = w2;
                else if (s1 == s2)
                    lw = w;
            }
            return lw;

        }
    } 
}