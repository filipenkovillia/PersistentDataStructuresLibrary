namespace PersistentDataStructuresLibrary.Interfaces
{
    internal interface ITreeNode
    {
        TreeNode? Left { get; set; }
        TreeNode? Right { get; set; }
        int Value { get; set; }
    }
}
