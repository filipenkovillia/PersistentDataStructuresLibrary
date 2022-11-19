namespace PersistentDataStructuresLibrary.Interfaces
{
    public interface IPersistentSegmentTree
    {
        int Count { get; }

        void Change(TreeNode oldRoot, int index, int newValue);
        TreeNode GetRootByVersionNumber(int versionNumber);
        int IndexOf(TreeNode root, int searchValue);
        int SegmentSum(TreeNode root, int leftSegment, int rightSegment);
    }
}