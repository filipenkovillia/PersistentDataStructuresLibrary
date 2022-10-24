namespace PersistentDataStructuresLibrary
{
    public class PersistentStack<T>
    {
        private int _currentVersionsCount;
        private readonly ValueNode<T>[] _versionHeads;

        public int NumberOfVersions { get; set; }
        //TODO: get previous or next version of stack by versionNumber or instance

        public PersistentStack(int numberOfVersions)
        {
            NumberOfVersions = numberOfVersions;
            _currentVersionsCount = 0;
            _versionHeads = new ValueNode<T>[NumberOfVersions];
        }

        public NodeStack<T> GetStackByVersion(int versionNumber)
        {
            return new NodeStack<T>(_versionHeads[versionNumber]);
        }

        public T Peek(int versionNumber)
        {
            var currentStack = new NodeStack<T>(_versionHeads[versionNumber]);
            return currentStack.Peek();
        }

        public NodeStack<T> Pop(int versionNumber)
        {
            if (versionNumber > _currentVersionsCount)
                throw new Exception("Incorrect version");
            var currentStack = new NodeStack<T>(_versionHeads[versionNumber]);
            currentStack.Pop();
            _currentVersionsCount++;
            _versionHeads[_currentVersionsCount] = currentStack.Head!;
            return new NodeStack<T>(_versionHeads[_currentVersionsCount]);
        }

        public NodeStack<T> Push(int versionNumber, T value)
        {
            if (versionNumber > _currentVersionsCount)
                throw new Exception("Incorrect version");
            var currentStack = new NodeStack<T>(_versionHeads[versionNumber]);
            currentStack.Push(value);
            _currentVersionsCount++;
            _versionHeads[_currentVersionsCount] = currentStack.Head!;
            return new NodeStack<T>(_versionHeads[_currentVersionsCount]);
        }
    }
}
