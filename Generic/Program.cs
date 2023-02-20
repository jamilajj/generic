using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ArrayList arrayList= new ArrayList();
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add(40);
            arrayList.Add("50A");

            //  arrayList.Remove(30);
            ///   arrayList.RemoveAt(2);
            //arrayList.Insert(arrayList.Count, arrayList);
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========qoue========");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(50);
            
           // var value=queue.Dequeue();
          //  value = queue.Peek();
         //   value=queue.Dequeue();

            foreach (var item in queue) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================stack=======");
            Stack<int> stack = new Stack<int>();
            stack.Push(20);
            stack.Push(30);
            stack.Push(50);
            
            var value= stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine($"{item}");
            }
            arrayList.AddRange(stack);
            Console.WriteLine("Arraylist");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========sortedlist=======");
           SortedList sortedList= new SortedList();
            sortedList.Add("ali", 1);
            sortedList.Add("veli", 2);
            sortedList.Add("totu", 3);
            Console.WriteLine(sortedList["mli"]);
            throw new FormatException();

        }
    }
}
