using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Olá");
            list.Add("Adeus");
            list.Add("Oi");

            Console.WriteLine("Lista: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Stack<string> stack = new Stack<string>();
            stack.Push("gato");
            stack.Push("sapo");
            stack.Push("águia");

            Console.WriteLine("Stack: ");
            while (stack.Count > 0)
            {
                string item = stack.Pop();
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("salamandra");
            queue.Enqueue("gaivota");
            queue.Enqueue("raposa");

            Console.WriteLine("Queue: ");
            while (queue.Count > 0)
            {
                string item = queue.Dequeue();
                Console.WriteLine(item);
            }

            Console.WriteLine();

            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("elefante");
            hashSet.Add("girafa");
            hashSet.Add("golfinho");

            Console.WriteLine("HashSet: ");
            foreach (string item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
