namespace PersistentDataStructuresLibrary.Interfaces
{
    public interface IPersistentQueue<T>
    {
        int NumberOfVersions { get; set; }
        NodeQueue<T> Dequeue(int versionNumber);
        NodeQueue<T> Enqueue(int versionNumber, T value);
        T Peek(int versionNumber);
    }
}