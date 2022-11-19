namespace PersistentDataStructuresLibrary.Interfaces
{
    /// <summary>
    /// Represents a fully persistent queue, built on stacks
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPersistentQueue<T>
    {
        /// <summary>
        /// Maximal number of sustainable versions
        /// </summary>
        int NumberOfVersions { get; set; }

        /// <summary>
        /// Removes first node from a queue
        /// </summary>
        /// <param name="versionNumber">Version number of a queue</param>
        /// <returns>Resulted queue without first node</returns>
        NodeQueue<T> Dequeue(int versionNumber);
        /// <summary>
        /// Adds a node to the tail of a queue
        /// </summary>
        /// <param name="versionNumber">Version number of a queue</param>
        /// <param name="value">Value of a node to add</param>
        /// <returns>Resulted queue with a new node in the end</returns>
        NodeQueue<T> Enqueue(int versionNumber, T value);
        /// <summary>
        /// Peeks a value from the tail node of a queue
        /// </summary>
        /// <param name="versionNumber">Version number of a queue</param>
        /// <returns>Value of a node in the tail of the queue</returns>
        T Peek(int versionNumber);
    }
}