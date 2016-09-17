using System;

namespace AlgorithmicTasks
{
    public partial class Program
    {
        private static void Main(string[] args)
        {
            //intersection and Union
            var first = new [] { 6, 7, 9 };
            var second = new [] { 1, 3, 4, 5, 6 };

            var resultIntersect = Intersect(second, first);
            var resultUnion = Union(second, first);

            //write to console
            Console.Write("First array: ");
            foreach (var item in first)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.Write("Second array: ");
            foreach (var item in second)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.Write("Intersect: ");
            foreach (var item in resultIntersect)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.Write("Union: ");
            foreach (var item in resultUnion)
                Console.Write($"{item} ");
            Console.WriteLine();

            //linked list with loop
            var llist = new CustomLinkedList<int>();

            var headNode = new CustomLinkedListNode<int>(0);
            var lastNode = new CustomLinkedListNode<int>(3);

            llist.AddItem(-2);
            llist.AddItem(-1);
            llist.AddItem(headNode);
            llist.AddItem(1);
            llist.AddItem(2);
            llist.AddItem(lastNode);
            
            //loop
            lastNode.Next = headNode;

            var existLoop = DetectLoop(llist);
            var loopItem = FindLoopLink(llist);

            //write to console
            Console.Write("Linked list: ");
            foreach (var item in llist)
                Console.Write($"{item} ");
            Console.WriteLine();
            Console.WriteLine($"Exist loop: {existLoop}, loop item: {loopItem}");
            Console.ReadKey();
        }
    }
}
