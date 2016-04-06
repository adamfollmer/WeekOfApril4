using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringInterface
{
    public class Node<T>
    {
        Node<T> next;
        Node<T> previous;
        CustomLinkedList<T> list;
        T nodeValue;
        public Node(T value)
        {
            nodeValue = value;
            next = null;
            previous = null;
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node<T> Previous
        {
            get { return previous; }
            set { previous = value; }
        }
        public CustomLinkedList<T> List
        {
            get { return list; }
            set { list = value; }
        }
        public T Value
        {
            get { return nodeValue; }
            set { nodeValue = value; }
        }

    }
    public class CustomLinkedList<T> : IEnumerable
    {
        Node<T> head;
        Node<T> tail;
        List<Node<T>> list = new List<Node<T>>();
        public CustomLinkedList()
        {

        }
        public Node<T> Head
        {
            get { return head; }
        }
        public Node<T> Tail
        {
            get { return tail; }
        }
        public List<Node<T>> List
        {
            get { return list; }
        }
        public void AddFirst(T value)
        {
            Node<T> headtoBe = new Node<T>(value);
            head = headtoBe;
            head.List = this;
            list.Add(head);
            if (tail != null)
            {
                Node<T> compareNode = tail;
                while (compareNode.Previous != null)
                {
                    compareNode = compareNode.Previous;
                    if (compareNode.Previous == null)
                    {
                        head.Next = compareNode;

                    }
                }
                compareNode.Previous = head;
            }
        }
        public void AddLast(T value)
        {
            Node<T> tailToBe = new Node<T>(value);
            if (tail != null)
            {
                Node<T> oldTail;
                tailToBe.Previous = tail;
                oldTail = tail;
                oldTail.Next = tailToBe;
            }
            tail = tailToBe;
            tail.List = this;
            list.Add(tail);
        }
        public void AddAfter(Node<T> targetNode, T value) //Don't think this is as simple as it is
        {
            Node<T> addAfterNode = new Node<T>(value);
            if (targetNode != tail)
            {
                Node<T> originalNext = targetNode.Next;
                addAfterNode.Previous = targetNode;
                addAfterNode.Next = targetNode.Next;
                targetNode.Next = addAfterNode;
                originalNext.Previous = addAfterNode;
            }
            else
            {
                tail = addAfterNode;
                targetNode.Next = addAfterNode;
                addAfterNode.Previous = targetNode;
            }

        }
        public void AddBefore(Node<T> targetNode, T value)
        {
            if (targetNode == null)
            {
            } else if (targetNode == head)
            {
                Node<T> addBeforeNode = new Node<T>(value);
                head = addBeforeNode;
                targetNode.Previous = addBeforeNode;
                addBeforeNode.Next = targetNode;
            }
            else
            {
                Node<T> addBeforeNode = new Node<T>(value);//ok
                Node<T> originalPrevious = targetNode.Previous;
                addBeforeNode.Previous = targetNode.Previous;//ok
                addBeforeNode.Next = targetNode;//ok
                targetNode.Previous = addBeforeNode;
                originalPrevious.Next = addBeforeNode;
            }

        }
        public void Remove(Node<T> targetNode)
        {
            if (targetNode.Previous != null)
            {
                Node<T> holdNext = targetNode.Next;
                Node<T> holdPrevious = targetNode.Previous;
                holdPrevious.Next = holdNext;
                if (holdNext != null)
                {
                    holdNext.Previous = holdPrevious;
                }
            }
            if (targetNode == head)
            {
                head = targetNode.Next;
            }
            else if (targetNode == tail)
            {
                tail = null;
            }
            targetNode.List = null;
            targetNode.Next = null;
            targetNode.Previous = null;
            list.Remove(targetNode);
        }
        public IEnumerator GetEnumerator()
        {
            Node<T> nextNode;
            if (head.Next != null)
            {
                yield return head.Value;
                nextNode = head.Next;
                while (nextNode.Next != null)
                {
                    yield return nextNode.Value;
                    nextNode = nextNode.Next;
                }
                yield return nextNode.Value;
            }
            else
            {
                yield return head.Value;
            }
        }
        public int Count()
        {
            int count = 0;
            foreach (T value in this)
            {
                count++;
            }
            return count;
        }
    }
}
