using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicTasks
{
    public class CustomLinkedList<T> : List<CustomLinkedListNode<T>>
    {
        public CustomLinkedListNode<T> First => this.FirstOrDefault();

        public void AddItem(CustomLinkedListNode<T> item)
        {
            if (this.Any())
                this.Last().Next = item;
            Add(item);
        }
        public void AddItem(T value)
        {
            AddItem(new CustomLinkedListNode<T>(value));
        }
    }

    public class CustomLinkedListNode<T>
    {
        public CustomLinkedListNode(T value)
        {
            Value = value;
        }
        public CustomLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
