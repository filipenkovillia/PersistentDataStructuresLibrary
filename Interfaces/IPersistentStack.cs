namespace PersistentDataStructuresLibrary.Interfaces
{
    internal interface IPersistentStack<T>
    {
        int NumberOfVersions { get; set; }
        NodeStack<T> GetStackByVersion(int versionNumber);
        T Peek(int versionNumber);
        NodeStack<T> Pop(int versionNumber);
        NodeStack<T> Push(int versionNumber, T value);
    }
}
