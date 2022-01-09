using System;
using System.Collections.Generic;

namespace StackAndQueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stackDemo = new List<int>();
            Stack stackOperation = new Stack();
            stackOperation.Push(stackDemo, 1);
            stackOperation.Push(stackDemo, 3);
            stackOperation.Push(stackDemo, 2);
            stackOperation.Push(stackDemo, 4);
            stackOperation.Push(stackDemo, 5);
            stackOperation.Push(stackDemo, 7);
            stackOperation.Push(stackDemo, 6);
            Console.WriteLine("elements in Stack");
            foreach (int element in stackDemo)
            {
                Console.WriteLine(element);
            }
            stackOperation.Pop(stackDemo);
            Console.WriteLine("elements in Stack after pop");
            foreach (int element in stackDemo)
            {
                Console.WriteLine(element);
            }
            stackOperation.Peak(stackDemo);



            List<int> queueDemo = new List<int>();
            Queue queueOperation = new Queue();
            queueOperation.Enqueue(queueDemo, 1);
            queueOperation.Enqueue(queueDemo, 2);
            queueOperation.Enqueue(queueDemo, 3);
            queueOperation.Enqueue(queueDemo, 4);
            queueOperation.Enqueue(queueDemo, 5);
            queueOperation.Enqueue(queueDemo, 6);
            queueOperation.Enqueue(queueDemo, 7);
            queueOperation.Enqueue(queueDemo, 8);
            Console.WriteLine("Queue bedore dequeue");
            foreach (int element in queueDemo)
            {
                Console.WriteLine(element);
            }
            queueOperation.Dequeue(queueDemo);
            Console.WriteLine("queue after dequeue");
            foreach (int element in queueDemo)
            {
                Console.WriteLine(element);
            }
            queueOperation.Peak(queueDemo);

        }
    }

}
