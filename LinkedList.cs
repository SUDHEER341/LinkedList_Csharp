using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    

   public class LinkedList<T>
    {
        private Node<T> head;

        private  class Node<T>
        {
            public T Data;
            public Node<T> Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
        }

        public void AddLast(T data)
        {
            Node <T> newNode = new Node<T> (data);
            if(head == null)
            {
                head = newNode;
                return;
            }
            Node<T> current =head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddAfter(T existingData , T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            Node<T> current = head;

            while(current != null && !current.Data.Equals(existingData))
             {

                current = current.Next;
            }
            if(current != null)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void DeleteFirst()
        {
            if(head == null)
            {
                return;
            }
            head = head.Next;
        }

        public void DeleteLast()
        {
            if(head == null || head.Next == null)
            {
                head = null;
                return;
            }

            Node<T> current = head;
            while(current.Next.Next != null)
            {
                current =current.Next;
            }
            current.Next = null;
        }

        public void DeleteExisting (T existingData)
        {
            if(head == null)
            {
                return; 
            }

            // check if head node have the existing data

            if (head.Data.Equals(existingData))
            {
                head = head.Next;
                return;
            }

            Node<T> current = head;
            while(current.Next != null)
            {
                // check if next node have the existing data
                if (current.Next.Data.Equals(existingData))
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
        public void PrintList()
        {
            Node <T> current = head;
            while(current != null)
            {
                Console.Write(current.Data + "->");
                current = current.Next;
            }
            Console.WriteLine("END");
        }

        //==================custom stack =================

        public void Push(T data)
        {
            AddFirst(data);
        }

        public void Pop()
        {
            DeleteFirst();
        }

        public T Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is Empty!");
            }
            return head.Data;
        }

        public bool isEmpty()
        {
            return head == null;
        }

        // ==============Queue operations=========== 

        public void Enqueue(T data)
        {
            AddFirst(data);
        }

        public void Dequeue()
        {
            DeleteLast();
        }

        public T Peek_Queue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty!");
            }
            return head.Data;
        }

        public bool Is_Empty_Queue()
        {
            return head == null;
        }
    }
    
}
