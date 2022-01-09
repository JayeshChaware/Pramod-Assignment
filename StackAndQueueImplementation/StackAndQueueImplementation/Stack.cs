using System;
using System.Collections.Generic;

namespace StackAndQueueImplementation
{
    public class Stack
    {
        public List<int> Push(List<int> stack, int data)
        {
            stack.Add(data);
            Console.WriteLine("element Pushed");
            return stack;
        }
        public List<int> Pop(List<int> stack)
        {
            int length = stack.Count;
            stack.RemoveAt(length-1);
            Console.WriteLine("element Poped");
            return stack;
        }
        public void Peak(List<int> stack)
        {
            int length = stack.Count;
            Console.WriteLine( "peak:{0}",stack[length-1]);
        }


    }

}
