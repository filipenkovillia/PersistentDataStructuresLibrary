using PersistentDataStructuresLibrary.Interfaces;

namespace PersistentDataStructuresLibrary
{
    public class TreeNode : ITreeNode
    {
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
        public int Value { get; set; }

        public TreeNode()
        {
            Left = null;
            Right = null;
            Value = 0;
        }
    }
}
