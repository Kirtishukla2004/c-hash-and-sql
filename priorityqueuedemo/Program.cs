using System;
using System.Collections.Generic;
using System.Linq;

namespace priorityqueuedemo
{
    class Program
    {

        static void Main()
        {
            Way1<string> pq = new Way1<string>();

            pq.MyEnqueue(1, "kirti");
            pq.MyEnqueue(3, "scott");
            pq.MyEnqueue(2, "jhon");
            pq.MyEnqueue(5, "chico");
            for (int i = 0; pq.Count > i; i++)
            {
                Console.WriteLine(pq.MyDequeue());

            }
         
            
            Console.WriteLine(pq.MyContains("kirti"));
            pq.Myprintqueue();

            Way1<Way2> pq2 = new Way1<Way2>();
            pq2.MyEnqueue(1,new Way2("A", 1));
            pq2.MyEnqueue(1, new Way2("B", 2));
            pq2.MyEnqueue(1, new Way2("C", 4));
            pq2.MyEnqueue(1, new Way2("D", 3));
            for (int i = 0; pq2.Count > i; i++)
            {
                Console.WriteLine(pq2.MyDequeue());

            }


            Console.WriteLine(pq2.MyContains(new Way2("kirti",1)));
            pq2.Myprintqueue();




        }
    }
}