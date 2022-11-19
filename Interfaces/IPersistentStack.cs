namespace PersistentDataStructuresLibrary.Interfaces
{
    /// <summary>
    /// Represents a fully persistent stack
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IPersistentStack<T>
    {
        /// <summary>
        /// Maximal number of sustainable versions
        /// </summary>
        int NumberOfVersions { get; set; }

        /// <summary>
        /// Gets NodeStack<T> with the specified version number
        /// </summary>
        /// <param name="versionNumber">Number of version</param>
        /// <returns>NodeStack<T> with the specified version number</returns>
        NodeStack<T> GetStackByVersion(int versionNumber);
        /// <summary>
        /// Peeks the value from the head node of the stack specified by version number
        /// </summary>
        /// <param name="versionNumber">Number of version</param>
        /// <returns>Value from the head node of the stack specified by version number</returns>
        T Peek(int versionNumber);
        /// <summary>
        /// Removes head node from the stack specified by version number
        /// </summary>
        /// <param name="versionNumber">Number of version</param>
        /// <returns>Resulted stack without head node</returns>
        NodeStack<T> Pop(int versionNumber);
        /// <summary>
        /// Adds a node with the specified value to the head of the specified stack
        /// </summary>
        /// <param name="versionNumber">Number of version</param>
        /// <param name="value">Value to set in the new node</param>
        /// <returns>Resulted stack with a new node in the head</returns>
        NodeStack<T> Push(int versionNumber, T value);
    }
}
