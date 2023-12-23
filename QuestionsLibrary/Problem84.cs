using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem84
    {
        public int largestRectangleArea()
        {
            int[] heights = [2, 1, 5, 6, 2, 3];
            Stack<int> stack = new Stack<int>();
            int max = 0;
            stack.Push(0);

            for (int i = 1; i < heights.Length; i++)
            {
                while (stack.Count() != 0 && heights[i] < heights[stack.Peek()])
                {
                    max = getMax(heights, stack, max, i);
                }
                stack.Push(i);
            }
            int ii = heights.Length;
            while (stack.Count() != 0)
            {
                max = getMax(heights, stack, max, ii);
            }
            return max;
        }
        public int getMax(int[] arr, Stack<int> stack, int max, int i)
        {
            int area;
            int poped = stack.Pop();
            if (stack.Count() == 0)
            {
                area = arr[poped] * i;
            }
            else
            {
                area = arr[poped] * (i - 1 - stack.Peek());
            }
            return Math.Max(max, area);
        }

        //public int LargestRectangleArea()
        //{
        //    int[] heights = [2, 1, 5, 6, 2, 3];
        //    if (heights.Length == 0) return 0;
        //    Stack<int> stack = new Stack<int>();
        //    stack.Push(-1);
        //    int maxArea = 0;
        //    for (int i = 0; i <= heights.Length; i++)
        //    {
        //        int cur = (i == heights.Length ? 0 : heights[i]);
        //        while (stack.Peek() != -1 && cur < heights[stack.Peek()])
        //        {
        //            maxArea = Math.Max(maxArea, heights[stack.Pop()] * (i - stack.Peek() - 1));
        //        }
        //        stack.Push(i);
        //    }
        //    return maxArea;
        //}


        //public int LargestRectangleArea()
        //{
        //    int[] heights = [0,9];
        //    int len = heights.Length;
        //    Stack<int> s = new Stack<int>();
        //    int maxArea = 0;
        //    for (int i = 0; i <= len; i++)
        //    {
        //        int h = (i == len ? 0 : heights[i]);
        //        if (s.Count == 0 || h >= heights[s.Peek()])
        //        {
        //            s.Push(i);
        //        }
        //        else
        //        {
        //            int tp = s.Pop();
        //            maxArea = Math.Max(maxArea, heights[tp] * (s.Count() == 0 ? i : i - 1 - s.Peek()));
        //            i--;
        //        }
        //    }
        //    return maxArea;
        //}

        //public int LargestRectangleArea()
        //{
        //    int[] heights = [0,9];
        //    int largestRectangleArea = 0;
        //    Stack<int> stack = new Stack<int>();
        //    int stackElement = 0;
        //    Stack<int> rectangleArea = new Stack<int>();
        //    int area = 0;
        //    for (int i = 0; i < heights.Length; i++)
        //    {
        //        rectangleArea.Push(heights[i]);


        //        //if (stack.Count == 0)
        //        //{
        //        //    stack.Push(heights[i]); 
        //        //}
        //        //else
        //        //{
        //        //    stackElement = stack.Pop();
        //        //    if (stackElement - heights[i] > 0)
        //        //    {
        //        //        area = heights[i] + heights[i];
        //        //        rectangleArea.Push(area);
        //        //    }
        //        //    else if (heights[i] - stackElement > 0)
        //        //    {
        //        //        area = stackElement + stackElement;
        //        //        rectangleArea.Push(area);
        //        //    }
        //        //    else
        //        //    {
        //        //        area = stackElement + stackElement;
        //        //        rectangleArea.Push(area);
        //        //        area = 0;
        //        //    }
        //        //    stack.Push(heights[i]);
        //        //}

        //    }

        //    largestRectangleArea = rectangleArea.Max();
        //    return largestRectangleArea;
        //}
    }
}
