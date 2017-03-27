using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class NodeList<T>: System.Collections.CollectionBase
    {
        private Node<T> head;
        private Node<T> tail;
        private int Count;

        public NodeList(T firstItem)
        {
            this.head = new Node<T>(firstItem);
            this.tail = head;
            Count = 1;
        
        }

        public void add(T item)
        {
            if(this.Count == 1)
            {
                this.tail = new Node<T>(item);
                this.tail.next = null;
                this.tail.previous = this.head;
            }

            else
            {
                this.tail.next = new Node<T>(item);
                this.tail.next.next = null;
                this.tail.next.previous = tail;
                this.tail = this.tail.next;

            }

        }

         

        private class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node<T> previous;

            public Node(T data)
            {
                this.data = data;
                this.next = this;
                this.previous = this.next;

            }
        }

    }
}
