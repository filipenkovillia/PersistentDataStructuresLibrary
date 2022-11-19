using PersistentDataStructuresLibrary.Interfaces;

namespace PersistentDataStructuresLibrary
{
    public class NodeStack<T> : INodeStack<T>
    {
        public int Count { get; private set; }
        public ValueNode<T>? Head { get; set; }
        public bool IsEmpty
        {
            get { return Count == 0; }
        }
        // TODO: common functions like count, sum, contains etc.

        public NodeStack()
        {
            Count = 0;
        }

        public NodeStack(ValueNode<T> head)
        {
            Head = head;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            return Head!.Value;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            ValueNode<T> tempNode = Head!;
            Head = Head!.Next;
            Count--;
            return tempNode.Value;
        }

        public void Push(T value)
        {
            var newNode = new ValueNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
            Count++;
        }
    }
}
