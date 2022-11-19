namespace PersistentDataStructuresLibrary.Interfaces
{
    internal interface IValueNode<T>
    {
        ValueNode<T>? Next { get; set; }
        T Value { get; set; }
    }
}
