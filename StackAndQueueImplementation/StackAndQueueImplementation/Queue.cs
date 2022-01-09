using System.Collections.Generic;
using System;

namespace StackAndQueueImplementation
{
    public class Queue
    {
        public List<int> Enqueue(List<int> queue, int data)
        {
            queue.Add(data);
            return queue;
        }

        public List<int> Dequeue(List<int> queue)
        {
            queue.RemoveAt(0);
            return queue;
        }
        public void Peak(List<int> queue)
        {
           Console.WriteLine("Peak: {0}",queue[0]);
        }

    }
}
