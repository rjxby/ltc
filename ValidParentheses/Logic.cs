using System;
using System.Collections.Generic;
using System.Linq;

namespace TrimBinarySearchTree
{
    public class Logic
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            var stack = new Stack<char>();

            foreach (var charItem in s)
            {
                switch (charItem)
                {
                    case '(':
                        stack.Push(charItem);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                    case '{':
                        stack.Push(charItem);
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case '[':
                        stack.Push(charItem);
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                }
            }

            if(stack.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}