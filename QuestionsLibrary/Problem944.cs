using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem944
    {
        public int MinDeletionSize()
        {
            int noDeletionSize = 0;
            string[] str = ["rrjk", "furt", "guzm"];
            char aCharj;
            char aChari;
            bool status = false;

            for (int j = 0; j < str[0].Length; j++)
            {
                status = false;
                aCharj = str[0][j];// str[j].Substring(j, j + 1);
                for (int i = 1; i < str.Length; i++)
                {
                    aChari = str[i][j];
                    if (aCharj <= aChari)
                    {
                        aCharj = aChari;
                    }
                    else
                    {
                        status = true;
                    }
                }
                if (status)
                    noDeletionSize++;
            }

            return noDeletionSize;
        }
    }
}
