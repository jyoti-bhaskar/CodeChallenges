using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    public class NonRepeating
    {
        public static string Run(string sen)
        {
            int count = 1;

            if (string.IsNullOrWhiteSpace(sen)) 
                return "Empty string";

            for (int i = 0; i < sen.Length; i++)
            {
                for (int j = 0; j < sen.Length; j++)
                {
                    if (sen[i] == sen[j] && i != j)
                        count++;
                }
                if (count == 1)
                    return sen[i].ToString();
                else
                    count = 1;
            }

            return "-1";
        }
    }
}