using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem1684
    {
        public int CountConsistentStrings()
        {
            string allowed = "abc";
            string[] words = ["a", "b", "c", "ab", "ac", "bc", "abc"];
            int countConsistentStrings = 0;
            bool status = false;
            char singleChar;
            for (int i = 0; i < words.Length; i++)
            {
                status = false;
                for (int j = 0; j < words[i].Length; j++)
                {
                    singleChar = words[i][j];

                    if (isPresent(singleChar, allowed))
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                        break;
                    }
                }

                if (status)
                {
                    countConsistentStrings++;
                }
            }
            return countConsistentStrings;
        }

        public bool isPresent(char word, string allowed)
        {
            bool status = false;

            for (int i = 0; i < allowed.Length; i++)
            {
                if (word == allowed[i])
                {
                    status = true;
                }
            }
            return status;
        }
    }
}
