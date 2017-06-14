using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack : StackInterface
    {
        List<int> stack = new List<int>();
        List<int> minStack = new List<int>();
        int min = 0;

        public int GetMinimumItem()
        {
            if (minStack.Count > 0)
                return minStack[minStack.Count - 1];
            return 0;
        }

        public int Pop()
        {
            if (stack.Count == 0) return -1;
            int item = (int)stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            minStack.RemoveAt(minStack.Count - 1);
            min = minStack[minStack.Count - 1];
            return item;
        }

        public void Push(int item)
        {
            stack.Add(item);
            if (item < min || min == 0)
            {
                minStack.Add(item);
            } else
            {
                minStack.Add(min);
            }
        }

        public int GetMinStackCount()
        {
            return minStack.Count();
        }

    }
}
