using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProblems.Problems
{
    // Based on https://github.com/gaylemcd/ctci/blob/master/c-sharp/Chapter03/Q03_3.cs
    #region
    public class SetOfStacks
    {
        public int MaxCapacity { get; set; }
        public List<LimitedStackDoublyLinked> stacks = new List<LimitedStackDoublyLinked>();

        public int Pop()
        {
            return stacks[stacks.Count - 1].Pop();
        }

        public int Peek() {
            return stacks[stacks.Count - 1].Peek();
        }

        public void Push(int item) {
            if(!stacks[stacks.Count - 1].Push(item))
            {
                var stack = new LimitedStackDoublyLinked(MaxCapacity);
                stack.Push(item);
                stacks.Add(stack);
            }
        }

        public int PopAt(int index) {
            return ShiftLeft(index, true);
        }

        private int ShiftLeft(int index, bool removeTop)
        {
            var stack = stacks[index];
            var rtVal = 0; // dummy initial value

            if (removeTop)
            {
                rtVal = stack.Pop();
            }
            else
            {
                rtVal = stack.PopTail();
            }

            if(stack.Size == 0)
            {
                stacks.RemoveAt(index);
            }
            else if((index + 1) < stacks.Count)
            {
                stack.Push(ShiftLeft(index + 1, false));
            }
            
            return rtVal;
        }

        public SetOfStacks(int maxCapacity)
        {
            MaxCapacity = maxCapacity;
            stacks.Add(new LimitedStackDoublyLinked(maxCapacity));
        }
    }

    public class LimitedStackDoublyLinked
    {
        private string errorMsgEmpty = "Invalid Operation, Stack is empty";

        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Size { get; set; }
        public int MaxCapacity { get; set; }

        public bool Push(int value)
        {
            if(Size >= MaxCapacity)
            {
                return false;
            }

            Node newHead = new Node(value);
            if(Head != null)
            {
                Head.Previous = newHead;
                newHead.Next = Head;
                Head = newHead;
            }
            else
            {
                Head = Tail = newHead;
            }

            Size++;

            return true;
        }

        public int Pop() {
            if(Head == null)
            {
                throw new InvalidOperationException(errorMsgEmpty);
            }

            int rtVal = Head.Value;

            if(Size == 1)
            {
                Head = Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Previous = null;
            }

            Size--;

            return rtVal;
        }

        public int Peek()
        {
            if (Head == null)
            {
                throw new InvalidOperationException(errorMsgEmpty);
            }

            return Head.Value;
        }

        public int PopTail()
        {
            if (Tail == null)
            {
                throw new InvalidOperationException(errorMsgEmpty);
            }

            int rtVal = Tail.Value;

            if (Size == 1)
            {
                Head = Tail = null;
            }
            else
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }

            Size--;

            return rtVal;
        }

        public LimitedStackDoublyLinked(int maxCapacity)
        {
            MaxCapacity = maxCapacity;
        }

        public class Node
        {
            public Node Previous { get; set; }
            public Node Next { get; set; }
            public int Value { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }
    }
    #endregion
}
