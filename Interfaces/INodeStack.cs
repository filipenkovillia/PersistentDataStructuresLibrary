namespace PersistentDataStructuresLibrary.Interfaces
{
    /// <summary>
    /// Represents a simple last-in-first-out data structure
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface INodeStack<T>
    {
        /// <summary>
        /// Current number of nodes in the stack
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Head node in the stack
        /// </summary>
        ValueNode<T>? Head { get; set; }
        /// <summary>
        /// Determines whether the stack contains any nodes
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Gets the value in the head node
        /// </summary>
        /// <returns>Value in the head node</returns>
        T Peek();
        /// <summary>
        /// Removes head node from the stack
        /// </summary>
        /// <returns>Value in the head node</returns>
        T Pop();
        /// <summary>
        /// Adds a node with specified value in the head
        /// </summary>
        /// <param name="value">Value to set in the head node</param>
        void Push(T value);
    }
}