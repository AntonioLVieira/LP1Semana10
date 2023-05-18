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
            list.Add("Oi");
            list.Add("BomDia");

            Console.WriteLine("Lista: ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Stack<string> stack = new Stack<string>();
            stack.Push("Olá");
            stack.Push("Adeus");
            stack.Push("Oi");
            stack.Push("Oi");
            stack.Push("BomDia");

            Console.WriteLine("Stack: ");
            while (stack.Count > 0)
            {
                string item = stack.Pop();
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Olá");
            queue.Enqueue("Adeus");
            queue.Enqueue("Oi");
            queue.Enqueue("Oi");
            queue.Enqueue("BomDia");

            Console.WriteLine("Queue: ");
            while (queue.Count > 0)
            {
                string item = queue.Dequeue();
                Console.WriteLine(item);
            }

            Console.WriteLine();

            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Olá");
            hashSet.Add("Adeus");
            hashSet.Add("Oi");
            hashSet.Add("Oi");
            hashSet.Add("BomDia");

            Console.WriteLine("HashSet: ");
            foreach (string item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
