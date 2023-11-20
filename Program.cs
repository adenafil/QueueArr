using System;
using System.Collections;

namespace tes
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueArr queue = new QueueArr(4);

            Console.WriteLine("Add some data : 1 2 3 4");

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine("Date Terdepan : " + queue.First());

            Console.WriteLine("Dequeue 2 Data");

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("Data Terdepan : " + queue.First());

            Console.WriteLine("Enqueue 2 data baru : 5 6");
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine("Dequeue Sebanyak 3 kali");
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("Data terdepan : " + queue.First());

            Console.WriteLine("Size : " + queue.Size());
        }
    }
}
