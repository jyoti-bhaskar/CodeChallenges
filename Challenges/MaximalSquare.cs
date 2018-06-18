using System;

namespace Challenges
{
    public class MaximalSquare
    {
        public static string Run(string[] strArr)
        {
            int count = 0;
            char[][] c = new char[strArr.Length][];
            for (int row = 0; row < strArr.Length; row++)
            {
                c[row] = strArr[row].ToCharArray();
                char[] s = strArr[row].ToCharArray();
                for (int col = 0; col < s.Length; col++)
                {
                    Console.WriteLine("at "+row+ " and "+col+" is ==>  "+s[col]);
                    if (s[col] == '1')
                    {
                        if (s[col + 1] == '1' && s[col+1]< s.Length)
                        {
                            // char v= c[row][col]; //error
                            // Console.WriteLine("Bottom next character...  "+v);                         
                                 c[row + 1] = strArr[row + 1].ToCharArray();
                                 if (c[row + 1][col] == '1' && c[row + 1][col + 1] == '1')
                                  {
                                      count = row + 1 + col + 1;
                                  }                            
                        }
                    }
                }
            }
            //char[] c = string.Join(string.Empty, strArr).ToCharArray();
            //  var charArray = strArr.SelectMany(x=>x.ToCharArray());
            //foreach (char chr in c)           
              //  Console.Write(chr);
            //Console.ReadKey();
           /* Console.WriteLine("");
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine("members.."+strArr[i]);
                for (int j = 0; j < strArr[i].Length; j++)
                {
                    Console.WriteLine("into J.." + strArr[j]);
                }
            }*/
          

           
            return strArr[0];
        }
    }
}