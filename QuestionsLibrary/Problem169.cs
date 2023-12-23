using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems169
{
    public class Problem169
    {
        public int MajorityElement()
        {
            int[] nums = [2, 2, 1, 1, 1, 2, 2];
            int[] numWithCounter = new int[nums.Length];
            int majorityElement = 0;
            int majoritycounter = 0;
            int counter = 0;
            int halfCounter = nums.Length / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                counter = 0;
                majorityElement = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        counter += 1;
                    }
                }
                if (halfCounter < counter)
                {
                    majorityElement = nums[i];
                    break;
                }
            }

            return majorityElement;
        }
    }
}
