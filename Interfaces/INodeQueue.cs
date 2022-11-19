namespace PersistentDataStructuresLibrary.Interfaces
{
    /// <summary>
    /// Represents a simple first-in-first-out data structure
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface INodeQueue<T>
    {
        /// <summary>
        /// Current number of nodes in the queue
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Value in the first node in the queue
        /// </summary>
        T First { get; }
        /// <summary>
        /// Determines whether the queue contains any nodes
        /// </summary>
        bool IsEmpty { get; }
        /// <summary>
        /// Value in the last node in the queue
        /// </summary>
        T Last { get; }

        /// <summary>
        /// Removes head node from the queue
        /// </summary>
        /// <returns>Value in the head node</returns>
        T Dequeue();
        /// <summary>
        /// Adds a node with specified value in the tail
        /// </summary>
        /// <param name="value">Value to set in the tail node</param>
        void Enqueue(T value);
    }
}