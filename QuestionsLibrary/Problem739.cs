using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem739
    {
        public int[] DailyTemperatures()
        {
            int[] temperatures = [30, 40, 50, 60]; 
            int dayCounter = 0;
            int[] dailyTemperatures = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                int tempratureBigNumber = temperatures[i];
                for (int j = i; j < temperatures.Length; j++)
                {
                    if (tempratureBigNumber < temperatures[j])
                    { 
                        dailyTemperatures[i] = dayCounter;
                        break;
                    }
                    dayCounter++;
                }
                dayCounter = 0; 
            }
              
            return dailyTemperatures;
        }
    }
}
