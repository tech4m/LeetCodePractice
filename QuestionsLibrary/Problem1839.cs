using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsLibrary
{
    public class Problem1839
    {
        public int LongestBeautifulSubstring(string word)
        {
            int count = 1;
            int max = 0;
            int len = 1;
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i - 1] <= word[i])
                {
                    if (word[i - 1] == word[i])
                    {
                    }
                    else
                    {
                        count++;
                    }
                    len++;
                    if (count == 5)
                    {
                        max = Math.Max(max, len);
                    }
                }
                else
                {
                    count = 1;
                    len = 1;
                }
            }
            return max;
        }
    }
}
