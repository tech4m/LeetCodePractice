using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem1472
    {
        Stack<string> stackBrowsingHistory = new Stack<string>();
        Stack<string> backBrowsingHistory = new Stack<string>();
        public Problem1472(string homepage)
        {
            stackBrowsingHistory.Push(homepage);
        }

        public void Visit(string url)
        {
            stackBrowsingHistory.Push(url);
            backBrowsingHistory.Clear();
        }

        public string Back(int steps)
        {
            while (stackBrowsingHistory.Count() > 1 && steps > 0)
            {
                backBrowsingHistory.Push(stackBrowsingHistory.Peek());
                stackBrowsingHistory.Pop();
                steps--;
            }
            return stackBrowsingHistory.Peek();
        }

        public string Forward(int steps)
        {
            string forward = null;
            while (backBrowsingHistory.Count > 0 && steps > 0)
            {
                stackBrowsingHistory.Push(backBrowsingHistory.Pop());
                steps--;
            }

            return stackBrowsingHistory.Peek();
        }
    }
}
