using System.Collections.Generic;

namespace FirstPracticeSession.LeetCode
{
    public class ImplementQueueUsingStacks
    {
        public class Queue
        {
            public Stack<int> PushStack { get; set; }
            public Stack<int> PopStack { get; set; }

            public Queue()
            {
                PushStack = new Stack<int>();
                PopStack = new Stack<int>();
            }
            // Push element x to the back of queue.
            public void Push(int x)
            {
                PushStack.Push(x);
                PopStack.Clear();
                foreach (var item in PushStack.ToArray())
                {
                    PopStack.Push(item);
                }
            }

            // Removes the element from front of queue.
            public void Pop()
            {
                PopStack.Pop();
                PushStack.Clear();
                foreach (var item in PopStack)
                {
                    PushStack.Push(item);
                }
            }

            // Get the front element.
            public int Peek()
            {
                return PopStack.Peek();
            }

            // Return whether the queue is empty.
            public bool Empty()
            {
                return PopStack.Count == 0;
            }
        }
    }
}
