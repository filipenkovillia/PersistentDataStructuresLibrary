namespace PersistentDataStructuresLibrary.Interfaces
{
    public interface INodeStack<T>
    {
        int Count { get; }
        ValueNode<T>? Head { get; set; }
        bool IsEmpty { get; }

        T Peek();
        T Pop();
        void Push(T value);
    }
}