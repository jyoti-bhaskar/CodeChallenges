using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Challenges
{
    public class ScaleBalancing
    {
        public static string Run(string[] strArr)
        {
            string s = "";
            string[] sep = { ",", "[", "]", " " };
            string[] scaleNum = strArr[0].Split(sep, StringSplitOptions.RemoveEmptyEntries);
            string[] BalNum = strArr[2].Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] leftScale = new int[] { }, rightScale = new int[] { };

            List<int> leftscaleList = new List<int>();
            List<int> rightScaleList = new List<int>();

            int sn, bn, sn2;

            for (int j = 0; j < scaleNum.Length; j++)
            {
                sn = Convert.ToInt32(scaleNum[j]);
                for (int k = 0; k < BalNum.Length; k++)
                {
                    bn = Convert.ToInt32(BalNum[k]);
                    if (j == 0)
                    {
                        if (sn + bn == Convert.ToInt32(scaleNum[1]))
                        {
                            s = BalNum[k];
                            goto found;
                        }
                        leftscaleList.Add(sn + bn);
                    }
                    else if (j == 1)
                    {
                        if (sn + bn == Convert.ToInt32(scaleNum[0]))
                        {
                            s = BalNum[k];
                            goto found;
                        }
                        rightScaleList.Add(sn + bn);
                    }

                }
            }

            leftScale = leftscaleList.ToArray();
            rightScale = rightScaleList.ToArray();

            int[] v = leftScale.Intersect(rightScale).ToArray();
            if (v.Length > 0)
            {
                int cv = int.Parse(string.Join("", v[0]));

                int forLeft = Array.IndexOf(leftScale, cv);
                int forRight = Array.IndexOf(rightScale, cv);

                string[] values = new string[] { BalNum[forLeft], BalNum[forRight] };
                s = String.Join(",", values.OrderBy(x => x).ToArray());
            }
            else
            {
                leftscaleList.Clear();
                sn = Convert.ToInt32(scaleNum[0]);
                sn2 = Convert.ToInt32(scaleNum[1]);
                if (sn > sn2)
                {
                    for (int k = 0; k < BalNum.Length; k++)
                    {
                        bn = Convert.ToInt32(BalNum[k]);
                        if (sn - bn == Convert.ToInt32(scaleNum[1]))
                        {
                            s = BalNum[k];
                            goto found;
                        }
                        leftscaleList.Add(sn - bn);
                    }
                }
                else
                {
                    for (int k = 0; k < BalNum.Length; k++)
                    {
                        bn = Convert.ToInt32(BalNum[k]);
                        if (sn - bn == Convert.ToInt32(scaleNum[0]))
                        {
                            s = BalNum[k];
                            goto found;
                        }
                        rightScaleList.Add(sn - bn);
                    }
                }
                v = leftscaleList.Intersect(rightScaleList).ToArray();
                if (v.Length > 0)
                {
                    leftScale = leftscaleList.ToArray();
                    int cv = int.Parse(string.Join("", v[0]));
                    int cv2 = int.Parse(string.Join("", v[1]));
                    // Console.WriteLine("Common value in array => " + cv + " and cv2 => " + cv2);
                    int forLeft, forRight;
                    if (leftScale.Contains(cv) && leftScale.Contains(cv2))
                    {
                        forLeft = Array.IndexOf(leftScale, cv);
                        forRight = Array.IndexOf(leftScale, cv2);
                    }
                    else
                    {
                        forLeft = Array.IndexOf(leftScale, cv);
                        forRight = Array.IndexOf(rightScale, cv2);
                    }
                    string[] values = new string[] { BalNum[forLeft], BalNum[forRight] };
                    s = String.Join(",", values.OrderBy(x => x).ToArray());
                }
                else
                    s = "not possible";
            }
        found:
            return s;
        }
    }

}