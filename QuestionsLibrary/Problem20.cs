using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem20
    {
        public bool IsValid()
        {
            string s = "(])";
            Stack<char> stack = new Stack<char>();

            char check = ' ';
            bool status = false;

            foreach (char c in s.ToCharArray())
            {
                if (c == '(')
                {
                    stack.Push(')');
                    status = true;
                }
                else if (c == '[')
                {
                    stack.Push(']');
                    status = true;
                }
                else if (c == '{')
                {
                    stack.Push('}');
                    status = true;
                }
                else if (stack.Count == 0 || stack.Pop() != c)
                {
                    status = false;
                    return status;
                }
            }

            //for (int i = 0; i < s.Length; i++)
            //{
            //    char x = s[i];
            //    if (x == '(')
            //    {
            //        stack.Push(x);
            //        status = true;
            //    }
            //    else if (x == '[')
            //    {
            //        stack.Push(x);
            //        status = true;
            //    }
            //    else if (x == '{')
            //    {
            //        stack.Push(x);
            //        status = true;
            //    }
            //    else
            //    {
            //        if (stack.Count == 0)
            //        {
            //            if (x == ')')
            //            {
            //                status = false;
            //                return status;
            //            }
            //            else if (x == ']')
            //            {
            //                status = false;
            //                return status;
            //            }
            //            else if (x == '}')
            //            {
            //                status = false;
            //                return status;
            //            }
            //        }
            //        else
            //        {
            //            //check = stack.Peek();

            //            switch (stack.Peek())
            //            {
            //                case '(':
            //                    check = ')';
            //                    status = true;
            //                    break;
            //                case '[':
            //                    check = ']';
            //                    status = true;
            //                    break;
            //                case '{':
            //                    check = '}';
            //                    status = true;
            //                    break;
            //                default:
            //                    status = false;
            //                    break;
            //            }
            //            if (x == check)
            //            {
            //                stack.Pop();
            //            }
            //            else
            //            {
            //                status = false;
            //                return status;
            //            }
            //        }
            //    }
            //}

            //if (stack.Count > 0)
            //    status = false;
            return status;
        }
    }
}
