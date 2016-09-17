using System;
using System.Linq;

namespace AlgorithmicTasks
{
    public partial class Program
    {
        /// <summary>
        /// Detect loop using Floyd’s cycle-finding algorithm
        /// </summary>
        /// <param name="llist"></param>
        /// <returns></returns>
        public static bool DetectLoop(CustomLinkedList<int> llist)
        {
            //check
            if (llist == null)
                throw new Exception("linked list is null");
            if (!llist.Any())
                return false;

            var oneHop = llist.First;
            var twoHop = llist.First;
            while (oneHop != null && twoHop?.Next != null)
            {
                oneHop = oneHop.Next;
                twoHop = twoHop.Next.Next;
                if (oneHop == twoHop)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Find loop in the list
        /// </summary>
        /// <param name="llist"></param>
        /// <returns></returns>
        public static CustomLinkedListNode<int> FindLoopLink(CustomLinkedList<int> llist)
        {
            //check
            if (llist == null)
                throw new Exception("linked list is null");
            if (!llist.Any())
                return null;

            var oneHop = llist.First;
            var twoHop = llist.First.Next;

            //exist loop
            while (twoHop?.Next != null)
            {
                if (oneHop == twoHop)
                    break;
                oneHop = oneHop.Next;
                twoHop = twoHop.Next.Next;
            }

            //find looping link
            if (oneHop == twoHop)
            {
                oneHop = llist.First;
                while (oneHop != twoHop.Next)
                {
                    oneHop = oneHop.Next;
                    twoHop = twoHop.Next;
                }

                //twoHop.Next looping link
                return twoHop;
            }

            return null;
        }
    }
}
