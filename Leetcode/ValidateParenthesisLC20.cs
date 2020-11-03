using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ValidateParenthesisLC20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    stack.Push(s[i]);
                else
                {
                    if (stack.Count == 0) return false;
                    var lastIn = stack.Pop();
                    if (s[i] == ']' && lastIn != '[')
                        return false;
                    else if (s[i] == '}' && lastIn != '{')
                        return false;
                    else if (s[i] == ')' && lastIn != '(')
                        return false;
                }
            }
            return stack.Count == 0; ;
        }
    }
}
