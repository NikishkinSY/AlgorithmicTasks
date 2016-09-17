using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmicTasks.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IntersectTest()
        {
            var first = new[] { 6, 7, 9 };
            var second = new[] { 1, 3, 4, 5, 6 };
            var intersectItems = Program.Intersect(first, second);
            Assert.AreEqual(1, intersectItems.Length);
        }

        [TestMethod()]
        public void UnionTest()
        {
            var first = new[] { 6, 7, 9 };
            var second = new[] { 1, 3, 4, 5, 6 };
            var intersectItems = Program.Union(first, second);
            Assert.AreEqual(7, intersectItems.Length);
        }

        [TestMethod()]
        public void DetectLoopTest()
        {
            //linked list with loop
            var llist = new CustomLinkedList<int>();

            var headNode = new CustomLinkedListNode<int>(0);
            var lastNode = new CustomLinkedListNode<int>(3);

            llist.AddItem(headNode);
            llist.AddItem(1);
            llist.AddItem(2);
            llist.AddItem(lastNode);

            //loop
            lastNode.Next = headNode;
            var existLoop = Program.DetectLoop(llist);
            Assert.IsTrue(existLoop);
        }

        [TestMethod()]
        public void FindLoopLinkTest()
        {
            //linked list with loop
            var llist = new CustomLinkedList<int>();

            var headNode = new CustomLinkedListNode<int>(0);
            var lastNode = new CustomLinkedListNode<int>(3);

            llist.AddItem(headNode);
            llist.AddItem(1);
            llist.AddItem(2);
            llist.AddItem(lastNode);

            //loop
            lastNode.Next = headNode;
            var loopItem = Program.FindLoopLink(llist);
            Assert.AreEqual(3, loopItem.Value);
        }
    }
}