using System;
using System.Collections.Generic;
using System.Linq;

namespace priorityqueuedemo
{
    class Way1<T> 
    {
        public SortedDictionary<int, Queue<T>> elements;
        
        public Way1()
        {
           elements= new SortedDictionary<int, Queue<T>>();

        }
        public void MyEnqueue(int priority, T item)
        {
            
            if (!elements.ContainsKey(priority))
            {
                elements[priority] = new Queue<T>();
            }
            elements[priority].Enqueue(item);
        }
        public T MyDequeue()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("queue is empty");
            }

            var highpriority = elements.Keys.Min();
            var queue = elements[highpriority];

            T item = queue.Dequeue();

            if (queue.Count == 0)  
            {
                elements.Remove(highpriority);
            }

            return item;
        }
        public T MyPeek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("queue is empty ");
            }
            return elements[elements.Keys.Min()].Peek();
        }
        public bool MyContains(T item)
        {
            return elements.Values.Any(q => q.Contains(item));

        }
        public int Count => elements.Sum(kv => kv.Value.Count);
        public void Myprintqueue()
        {
            foreach (var queue in elements)
            {
                foreach (var item in queue.Value)
                {
                    Console.WriteLine(item);

                    
                }


            }
        }

        
    }

}