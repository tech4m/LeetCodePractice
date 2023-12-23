using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem2942
    {
        public int[] findWordContaining()
        {
            string[] words = ["leet", "code"];
            int[] xyz = null;
            int j = 0;
            string findString = "e";
            int index = 0;
            for (int i = 0; i < words.Length; i++)
            {
                index = i;

                string strElement = words[i];

                if (words[i].Contains(findString))
                {
                    xyz[j] = i;
                    j += 1;
                }
            }

            return xyz;
        }
    }
}
