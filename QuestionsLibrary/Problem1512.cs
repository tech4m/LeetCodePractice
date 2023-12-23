using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems1512
{
    public class Problem1512
    {
        public void goodPair()
        {
            int[] inputArray = [1, 2, 3, 1, 1, 3];
            int counter = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 1; j < inputArray.Length; j++)
                {
                    if ((i < j) && (inputArray[i] == inputArray[j]))
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine("Counter:-->" + counter);
        }
    }
}
