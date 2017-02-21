using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class ImplementStackUsingQueues
    {
        public void Main()
        {
            
        }

        public class MyStack
        {

            private Queue<int> queue1 { get; set; }
            private Queue<int> queue2 { get; set; }      
            /** Initialize your data structure here. */
            public MyStack()
            {
                queue1 = new Queue<int>();
                queue2 = new Queue<int>();
            }

            /** Push element x onto stack. */
            public void Push(int x)
            {
                queue1.Enqueue(x);                
            }

            /** Removes the element on top of the stack and returns that element. */
            public int Pop()
            {
                if (queue1.Count == 0)
                    return 0;

                while (queue1.Count > 1)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }

                int result =  queue1.Dequeue();

                while (queue2.Count != 0)
                {
                    queue1.Enqueue(queue2.Dequeue());
                }

                return result;

            }

            /** Get the top element. */
            public int Top()
            {
                if (queue1.Count == 0)
                    return 0;

                while (queue1.Count > 1)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }

                int result =  queue1.Peek();

                queue2.Enqueue(queue1.Dequeue());
                while (queue2.Count != 0)
                {
                    queue1.Enqueue(queue2.Dequeue());
                }

                return result;
            }

            /** Returns whether the stack is empty. */
            public bool Empty()
            {
                return queue1.Count == 0;
            }
        }

    }
}
