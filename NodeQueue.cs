using PersistentDataStructuresLibrary.Interfaces;

namespace PersistentDataStructuresLibrary
{
    public class NodeQueue<T> : INodeQueue<T>
    {
        private NodeStack<T> headStack { get; set; }
        private NodeStack<T> tailStack { get; set; }

        private int count { get; set; }

        public NodeQueue()
        {
            count = 0;
            headStack = new NodeStack<T>();
            tailStack = new NodeStack<T>();
        }

        public NodeQueue(NodeStack<T> headStack, NodeStack<T> tailStack)
        {
            this.headStack = headStack;
            this.tailStack = tailStack;
            this.count = headStack.Count + tailStack.Count;
        }

        public void Enqueue(T value)
        {
            tailStack.Push(value);
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new Exception("Empty queue");
            if (headStack.IsEmpty)
            {
                while (!tailStack.IsEmpty)
                {
                    headStack.Push(tailStack.Pop());
                }
            }
            count--;
            return headStack.Pop();
        }

        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return headStack.Head!.Value;
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tailStack.Head!.Value;
            }
        }

        public int Count { get { return count; } }

        public bool IsEmpty { get { return count == 0; } }

        private void Clear()
        {
            headStack = new NodeStack<T>();
            tailStack = new NodeStack<T>();
            count = 0;
        }
    }
}
