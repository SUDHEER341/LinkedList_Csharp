using System.Security.Cryptography.X509Certificates;

namespace CustomLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
         LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            linkedList.AddLast(4);// 3->2->1->4
            linkedList.AddAfter(2, 5); //3->2->5->1->4
            linkedList.DeleteFirst(); // 2->5->1->4
            linkedList.DeleteLast(); //2->5->1
            linkedList.DeleteExisting(5); //2->1
            linkedList.PrintList();

            //===========stack operations===========

            linkedList.Push(4);
            linkedList.Push(5);
            linkedList.Push(6);
            linkedList.Push(7);//7->6->5->4
            linkedList.Pop(); //6->5->4
            Console.WriteLine(linkedList.Peek());    // pick the first element  ->6
            Console.WriteLine(linkedList.isEmpty());
            linkedList.PrintList();

            //queue operations

            linkedList.Enqueue(10);
            linkedList.Enqueue(20);
            linkedList.Enqueue(30);
            linkedList.Dequeue();
            linkedList.PrintList();
        }
    }
}