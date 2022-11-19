namespace PersistentDataStructuresLibrary.Interfaces
{
    /// <summary>
    /// Represents a node of a stack and queue
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IValueNode<T>
    {
        /// <summary>
        /// Reference to the next node in a data structure
        /// </summary>
        ValueNode<T>? Next { get; set; }
        /// <summary>
        /// Value of the node
        /// </summary>
        T Value { get; set; }
    }
}
