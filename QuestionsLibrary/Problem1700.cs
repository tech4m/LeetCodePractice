using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsLibrary
{
    public class Problem1700
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int countSandwitches = 0;

            Queue<int> queueCircular = new Queue<int>();
            Queue<int> queueSquare = new Queue<int>();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == 0)//circle
                {
                    queueCircular.Enqueue(i);
                }
                else if (students[i] == 1)//square
                {
                    queueSquare.Enqueue(i);
                }
            }
            int counter = sandwiches.Length;

            for (int m = 0; m < counter; m++)
            {
                if ((sandwiches[m] == 0) && queueCircular.Count != 0)//circle
                {
                    queueCircular.Dequeue();
                }
                else if ((sandwiches[m] == 1) && queueSquare.Count != 0)//square
                {
                    queueSquare.Dequeue();
                }
                else
                {
                    return queueCircular.Count + queueSquare.Count;
                }
            }
            return 0; 
        }
    }
}
