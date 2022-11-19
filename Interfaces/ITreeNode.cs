namespace PersistentDataStructuresLibrary.Interfaces
{
    /// <summary>
    /// Represents a node of a segment tree
    /// </summary>
    internal interface ITreeNode
    {
        /// <summary>
        /// Reference to the left son node in segment tree
        /// </summary>
        TreeNode? Left { get; set; }
        /// <summary>
        /// Reference to the right son node in segment tree
        /// </summary>
        TreeNode? Right { get; set; }
        /// <summary>
        /// Value of the node
        /// </summary>
        int Value { get; set; }
    }
}
