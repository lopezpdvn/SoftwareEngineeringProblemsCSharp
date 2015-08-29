using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProblems.Problems
{
    public class SetOfStacks
    {
        public int MaxCapacity { get; set; }

        private List<LimitedStackDoublyLinked> stacks = new List<LimitedStackDoublyLinked>();

        public int Pop()
        {
            return stacks[stacks.Count - 1].Pop();
        }

        public int Peek() { return -1; }
        public void Push(int item) { }
        public int PopAt(int index) { return -1; }

        private int ShiftLeft(int index, bool removeTop)
        {
            return -1;
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
            newHead.Next = Head;
            if(Head != null)
            {
                Head.Previous = newHead;
            }
            Head = newHead;

            return true;
        }

        public int Pop() {
            if(Head == null)
            {
                throw new InvalidOperationException(errorMsgEmpty);
            }

            int rtVal = Head.Value;

            Head = Head.Next;
            Head.Previous = null;

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

            if(Tail == Head)
            {
                Head = Tail.Previous;
            }
            Tail = Tail.Previous;

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
}
