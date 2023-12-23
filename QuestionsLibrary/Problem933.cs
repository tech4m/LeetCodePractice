using System.Collections.Generic;

namespace QuestionsLibrary
{
    public class Problem933
    {
        Queue<int> recentCallQueue = new Queue<int>();
        public Problem933()
        {
            recentCallQueue.Enqueue(1);
            recentCallQueue.Enqueue(100);
            recentCallQueue.Enqueue(3001);
            recentCallQueue.Enqueue(3002);
        }

        public int Ping(int t)
        { 
            int minTime = t - 3000; 

            recentCallQueue.Enqueue(t);

            while (recentCallQueue.Peek() < minTime)
            {
                recentCallQueue.Dequeue();
            }
            return recentCallQueue.Count;
        }
    }
}
