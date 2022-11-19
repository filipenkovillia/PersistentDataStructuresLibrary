using PersistentDataStructuresLibrary.Interfaces;

namespace PersistentDataStructuresLibrary
{
    public class ValueNode<T> : IValueNode<T>
    {
        public ValueNode<T>? Next { get; set; }
        public T Value { get; set; }

        public ValueNode(T value)
        {
            Value = value;
        }
    }
}
