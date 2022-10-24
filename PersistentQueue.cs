namespace PersistentDataStructuresLibrary
{
    public class PersistentQueue<T>
    {
        // TODO: arrays of queues
        private int _currentVersionsCount;
        private NodeStack<T>[] _headStacks;
        private NodeStack<T>[] _tailStacks;

        public PersistentQueue(int versionCount)
        {
            _headStacks = new NodeStack<T>[versionCount];
            _tailStacks = new NodeStack<T>[versionCount];
            _currentVersionsCount = 0;
        }

        public NodeQueue<T> Dequeue(int versionNumber)
        {
            if (versionNumber > _currentVersionsCount)
                throw new Exception("Incorrect version");
            NodeStack<T> currentHeadStack = _headStacks[versionNumber];
            NodeStack<T> currentTailStack = _tailStacks[versionNumber];
            if (currentHeadStack.Count == 0 && currentTailStack.Count == 0)
                throw new Exception("Queue is empty");
            if (currentHeadStack.Count != 0)
            {
                currentHeadStack.Pop();
                return new NodeQueue<T>(currentHeadStack, currentTailStack);
            }
            else
            {
                while (!currentTailStack.IsEmpty)
                {
                    currentHeadStack.Push(currentTailStack.Pop());
                }
                currentHeadStack.Pop();
                return new NodeQueue<T>(currentHeadStack, currentTailStack);
            }
        }

        public NodeQueue<T> Enqueue(int versionNumber, T value)
        {
            if (versionNumber > _currentVersionsCount)
                throw new Exception("Incorrect version");
            NodeStack<T> currentHeadStack = _headStacks[versionNumber];
            NodeStack<T> currentTailStack = _tailStacks[versionNumber];
            currentTailStack.Push(value);
            _currentVersionsCount++;
            _headStacks[_currentVersionsCount] = currentHeadStack;
            _tailStacks[_currentVersionsCount] = currentTailStack;
            return new NodeQueue<T>(currentHeadStack, currentTailStack);
        }

        public T Peek(int versionNumber)
        {
            if (versionNumber > _currentVersionsCount)
                throw new Exception("Incorrect version");
            NodeStack<T> currentHeadStack = _headStacks[versionNumber];
            NodeStack<T> currentTailStack = _tailStacks[versionNumber];
            if (currentHeadStack.Count == 0 && currentTailStack.Count == 0)
                throw new Exception("Queue is empty");
            if (currentHeadStack.Count != 0)
            {
                return currentHeadStack.Peek();
            }
            else
            {
                while (!currentTailStack.IsEmpty)
                {
                    currentHeadStack.Push(currentTailStack.Pop());
                }
                return currentHeadStack.Peek();
            }
        }
    }
}
