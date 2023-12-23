using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsLibrary
{
    public class Problem387
    {
        public int FirstUniqChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char tempChar = s[i];
                if ((i == s.LastIndexOf(tempChar)) && (i == s.IndexOf(tempChar)))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
