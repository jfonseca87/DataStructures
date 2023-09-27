using System.Collections;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack LIFO (Last In - First Out)
            // StackStructure();

            // Queue FIFO (First In - First Out)
            // QueueStructure();

            // Linked List
            // LinkedList();

            // int[] numbers = { 2, 12, 34, 45, 67, 89, 123, 234, 345, 456, 456, 678, 789 };
            // int number = Array.BinarySearch(numbers, 123);

            // Graph
            // GraphExamples();

            // Tree
            // TreeExamples();

            Console.ReadLine();
        }

        #region Stack
        static void StackStructure()
        {
            Stack<string> strings = new Stack<string>();
            strings.Push("Hello");
            strings.Push("World");
            strings.Push("!");

            Console.WriteLine($"Stack => {nameof(strings)}");
            Console.WriteLine("\tCount: {0}", strings.Count);
            Console.Write("\tValues:");
            PrintValues(strings);

            Console.WriteLine("==============================================");

            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            // Check the current item on the head of the stack
            Console.WriteLine($"Current value before apply any change: {numbers.Peek()}");

            // Remove two items from the stack
            numbers.Pop();
            numbers.Pop();

            // Check triggered Pop twice stack's current value
            Console.WriteLine($"Current value after triggered Pop twice: {numbers.Peek()}");

            Console.WriteLine("==============================================");

            string someWord = "extensions";
            Console.WriteLine(someWord);

            // Convert this word using reverse
            Stack<char> reverseWordStack = new Stack<char>(someWord.ToCharArray());
            Console.WriteLine("Reverse word result:");
            PrintValues(reverseWordStack);
        }
        #endregion Stack

        #region Queue
        static void QueueStructure()
        {
            Queue queue = new Queue();
            queue.Enqueue("Hello");
            queue.Enqueue("World");
            queue.Enqueue("!");

            Console.WriteLine($"Queue: {nameof(queue)}");
            Console.WriteLine($"\tCount: {queue.Count}");
            Console.Write("\tValues: ");
            PrintValues(queue);

            Console.WriteLine("========================================");
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Enqueue(5);

            Console.WriteLine("Queue before any action");
            PrintValues(numbers);

            // Remove two values
            numbers.Dequeue();
            numbers.Dequeue();

            Console.WriteLine("Queue after remove two values");
            PrintValues(numbers);
        }
        #endregion Queue

        #region Linked List
        static void LinkedList()
        {
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            LinkedListNode<string> node = sentence.Find("jumps");
        }
        #endregion Linked List

        #region Graph
        static void GraphExamples()
        {
            // Social Network
            SocialGraph newSocialNetWork = new SocialGraph();
            newSocialNetWork.AddFriendship(
                new User { UserId = 1, Name = "Pepito" },
                new User { UserId = 2, Name = "Pepita" }
                );

            // Dependency graph for packages
            Package packageA = new Package { Name = "A" };
            Package packageB = new Package { Name = "B" };
            Package packageC = new Package { Name = "C" };
            packageA.Dependencies = new List<Package> { packageB, packageC };
        }

        #endregion

        #region Tree
        static void TreeExamples()
        {
            // File System
            FileSystemNode directoryRoot = new FileSystemNode { Name = "Root" };
            directoryRoot.Children = new List<FileSystemNode>
            {
                new FileSystemNode { Name = "Folder1", Children = new List<FileSystemNode> { /* Files and subfolders */ } },
                new FileSystemNode { Name = "Folder2", Children = new List<FileSystemNode> { /* Files and subfolders */ } },
            };

            // Creating a binary search tree
            TreeNode searchTree = new TreeNode { Value = 10 };
            searchTree.Left = new TreeNode { Value = 5 };
            searchTree.Right = new TreeNode { Value = 15 };

            // Creating an organizational hierarchy
            EmployeeNode CEO = new EmployeeNode { Name = "John Doe" };
            CEO.Subordinates = new List<EmployeeNode>
            {
                new EmployeeNode { Name = "Alice" },
                new EmployeeNode { Name = "Bob" },
            };
        }
        #endregion

        private static void PrintValues(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine("");
        }
    }

    #region Graph Resources
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    class SocialGraph
    {
        Dictionary<User, List<User>> adjacencyList = new Dictionary<User, List<User>>();

        public void AddFriendship(User user1, User user2)
        {
            if (!adjacencyList.ContainsKey(user1))
                adjacencyList[user1] = new List<User>();

            if (!adjacencyList.ContainsKey(user2))
                adjacencyList[user2] = new List<User>();

            adjacencyList[user1].Add(user2);
            adjacencyList[user2].Add(user1);
        }
    }

    class Package
    {
        public string Name { get; set; }
        public List<Package> Dependencies { get; set; }
    }
    #endregion

    #region Tree Resources
    class FileSystemNode
    {
        public string Name { get; set; }
        public List<FileSystemNode> Children { get; set; }
    }

    class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }

    class EmployeeNode
    {
        public string Name { get; set; }
        public List<EmployeeNode> Subordinates { get; set; }
    }
    #endregion
}