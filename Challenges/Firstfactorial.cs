//Using the C# language, have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it (e.g. if num = 4, return (4 * 3 * 2 * 1)). For the test cases, the range will be between 1 and 18 and the input will always be an integer
//--------------------------------------------------
using System;

namespace Challenges
{
    public static class FirstFactorial
    {
        public static int Run(int num)
        {
            int answer = 1;
            for (int i = 1; i <= num; i++)
            {
                answer = answer * i;
            }
            //Console.WriteLine("Answer is ..."+answer);
            return answer;
        }
    }
}