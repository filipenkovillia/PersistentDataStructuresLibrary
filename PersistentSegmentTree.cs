namespace PersistentDataStructuresLibrary
{
    public class PersistentSegmentTree
    {
        private readonly int _numberOfVertexes;
        private readonly TreeNode[] _roots;
        private readonly TreeNode[] _vertexNodes;

        public int Count { get; private set; }

        public PersistentSegmentTree(int numberOfVertexes)
        {
            Count = 1;
            _numberOfVertexes = numberOfVertexes;
            _roots = new TreeNode[_numberOfVertexes];
            _vertexNodes = new TreeNode[_numberOfVertexes];
            _roots[0] = _vertexNodes[++Count];
            Build();
        }

        private void Build()
        {
            Build_Rec(_roots[0], 0, _numberOfVertexes - 1);
        }

        private void Build_Rec(TreeNode root, int leftInterval, int rightInterval)
        {
            if (leftInterval == rightInterval)
                return;

            root.Left = _vertexNodes[++Count];
            root.Right = _vertexNodes[++Count];
            int middle = (leftInterval + rightInterval) / 2;
            Build_Rec(root.Left, leftInterval, middle);
            Build_Rec(root.Right, middle + 1, rightInterval);
        }

        public void Change(TreeNode oldRoot, int index, int newValue)
        {
            TreeNode newRoot = _vertexNodes[++Count];
            Change_Rec(oldRoot, newRoot, 0, _numberOfVertexes - 1, index, newValue);
        }

        private void Change_Rec(TreeNode oldRoot, TreeNode newRoot, int segmentLeft, int segmentRight, int index, int newValue)
        {
            if (segmentLeft == segmentRight)
            {
                newRoot.Value = newValue;
                return;
            }

            int middle = (segmentLeft + segmentRight) / 2;
            if (index <= middle)
            {
                newRoot.Right = oldRoot.Right;
                newRoot.Left = _vertexNodes[++Count];
                Change_Rec(oldRoot.Left!, newRoot.Left, segmentLeft, middle, index, newValue);
                newRoot.Value = newRoot.Left.Value + newRoot.Right!.Value;
            }
            else
            {
                newRoot.Left = oldRoot.Left;
                newRoot.Right = _vertexNodes[++Count];
                Change_Rec(oldRoot.Right!, newRoot.Right, middle + 1, segmentRight, index, newValue);
                newRoot.Value = newRoot.Left!.Value + newRoot.Right.Value;
            }
        }

        public TreeNode GetRootByVersionNumber(int versionNumber)
        {
            return _roots[versionNumber];
        }

        public int IndexOf(TreeNode root, int searchValue)
        {
            return IndexOf_Rec(root, 0, _numberOfVertexes - 1, searchValue);
        }

        private int IndexOf_Rec(TreeNode root, int leftInterval, int rightInterval, int searchValue)
        {
            if (leftInterval == rightInterval)
                return leftInterval;

            int middle = (leftInterval + rightInterval) / 2;

            if (root.Left!.Value >= searchValue)
                return IndexOf_Rec(root.Left, leftInterval, middle, searchValue);
            else
                return IndexOf_Rec(root.Right!, middle + 1, rightInterval, searchValue - root.Left.Value);
        }

        public int SegmentSum(TreeNode root, int leftSegment, int rightSegment)
        {
            return SegmentSum_Rec(root, 0, _numberOfVertexes, leftSegment, rightSegment);
        }

        private int SegmentSum_Rec(TreeNode root, int leftInterval, int rightInterval, int leftSegment, int rightSegment)
        {
            if (leftInterval > rightSegment || rightInterval < leftSegment)
                return 0;

            if (leftInterval >= leftSegment && rightInterval <= rightSegment)
                return root.Value;

            int middle = (leftInterval + rightInterval) / 2;
            return SegmentSum_Rec(root.Left!, leftInterval, middle, leftSegment, rightSegment) +
                   SegmentSum_Rec(root.Right!, middle + 1, rightInterval, leftSegment, rightSegment);
        }
    }
}
