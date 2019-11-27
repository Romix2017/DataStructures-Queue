using System;
using Queue.Models;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {



            var doubleLinkedDeque = new DoubleLinkDeque<int>();
            doubleLinkedDeque.PushFront(1);
            doubleLinkedDeque.PushFront(2);
            doubleLinkedDeque.PushFront(3);
            doubleLinkedDeque.PushBack(4);
            doubleLinkedDeque.PushBack(5);
            doubleLinkedDeque.PushFront(9);


            Console.WriteLine(doubleLinkedDeque.PopFront());
            Console.WriteLine(doubleLinkedDeque.PopBack());
            Console.WriteLine(doubleLinkedDeque.PopBack());
            Console.WriteLine(doubleLinkedDeque.PopBack());
            Console.WriteLine(doubleLinkedDeque.PopFront());
            Console.WriteLine(doubleLinkedDeque.PopBack());

            Console.ReadLine();


            var easyDeque = new EasyDeque<int>();
            easyDeque.PushFront(1);
            easyDeque.PushFront(2);
            easyDeque.PushFront(3);
            easyDeque.PushBack(4);
            easyDeque.PushBack(5);
            easyDeque.PushFront(9);


            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());

            Console.ReadLine();


            var linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            linkedQueue.Enqueue(5);

            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());

            Console.ReadLine();

            var arrayQueue = new ArrayQueue<int>(5);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());

            Console.ReadLine();

            var easyQueue = new EasyQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Dequeue());

            Console.ReadLine();
        }
    }
}
