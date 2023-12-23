using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems268
{
    public class Problem268
    {
        public int MissingNumber()
        {
            int[] nums = [3, 0, 1];
            int[] missingarry = new int[nums.Length + 1];
            Hashtable hb = new Hashtable();
            int missingNumber = 0;

            for (int i = 0; i <= nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == nums[j])
                    {
                        missingarry[i] = 1;
                    }
                }
            }
            for (int i = 0; i <= nums.Length; i++)
            {
                if (missingarry[i] == 0)
                {
                    missingNumber = i;
                }
            }
            return missingNumber;
        }
    }
}
