using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1358._Number_of_Substrings_Containning_All_Three_Characters
{
    public class Solution
    {
        public int NumberOfSubstrings(string s) 
        {
            int[] count = new int[3];
            int left = 0 , result = 0;

            for(int rigth = 0; rigth < s.Length; rigth++)
            {
                count[s[rigth] - 'a']++;

                while(count[0] > 0 && count[1] > 0 && count[2] > 0)
                {
                    result += s.Length - rigth;
                    count[s[left] - 'a']--;
                    left++;
                }
            }

            return result;
        }
    }
}