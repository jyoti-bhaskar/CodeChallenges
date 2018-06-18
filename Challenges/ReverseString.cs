//Using the C# language, have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order. For example: if the input string is "Hello World and Coders" then your program should return the string sredoC dna dlroW olleH. 
//---------------------------------------------------------------

using System;
namespace Challenges
{
    public class FirstReverse
    {
        public static string Run(string str)
        {

            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */
            string r_str = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                r_str = r_str + str[i];
            }
            return r_str;
            //return new string(str.Reverse().ToArray());    
        }



    }
}
