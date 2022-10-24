namespace PersistentDataStructuresLibrary
{
    public class TreeNode
    {
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
        public int Value;

        public TreeNode()
        {
            Left = null;
            Right = null;
            Value = 0;
        }
    }
}
