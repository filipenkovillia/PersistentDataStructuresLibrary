namespace PersistentDataStructuresLibrary.Interfaces
{
    public interface INodeQueue<T>
    {
        int Count { get; }
        T First { get; }
        bool IsEmpty { get; }
        T Last { get; }

        T Dequeue();
        void Enqueue(T value);
    }
}