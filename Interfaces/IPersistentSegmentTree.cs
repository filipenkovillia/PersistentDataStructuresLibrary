namespace PersistentDataStructuresLibrary.Interfaces
{
    /// <summary>
    /// Represents a fully persistent segment tree
    /// with sum operation over elements of the array
    /// </summary>
    public interface IPersistentSegmentTree
    {
        /// <summary>
        /// Total number of nodes
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Change value in a node
        /// </summary>
        /// <param name="oldRoot">Root node of a tree to do a change in</param>
        /// <param name="index">Index of a node to change value in</param>
        /// <param name="newValue">New value, which will be set</param>
        void Change(TreeNode oldRoot, int index, int newValue);
        /// <summary>
        /// Get a segment tree by a version number
        /// </summary>
        /// <param name="versionNumber">Number of version</param>
        /// <returns>Root node of a tree</returns>
        TreeNode GetRootByVersionNumber(int versionNumber);
        /// <summary>
        /// Gets the zero-based index of the specified value in the segment tree
        /// </summary>
        /// <param name="root">Root of a tree to search in</param>
        /// <param name="searchValue">Value to search for</param>
        /// <returns>The zero-based index of the specified value in the segment tree</returns>
        int IndexOf(TreeNode root, int searchValue);
        /// <summary>
        /// Computes sum of node values, which are into a segment
        /// </summary>
        /// <param name="root">Root of a tree to compute sum in</param>
        /// <param name="leftSegment">Left bound of a segment</param>
        /// <param name="rightSegment">Right bound of a segment</param>
        /// <returns>The sum of the values in projected nodes</returns>
        int SegmentSum(TreeNode root, int leftSegment, int rightSegment);
    }
}