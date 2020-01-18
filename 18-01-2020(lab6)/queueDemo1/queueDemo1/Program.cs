using System;
using System.Collections;

namespace stackl
{
    class Program
    {        static void Main(string[] args)
        {
            Console.WriteLine("queue:-");

            Queue days = new Queue();

            days.Enqueue("sunday");
            days.Enqueue("monday");
            days.Enqueue("tuesday");
            days.Enqueue("wednesday");
            days.Enqueue("thusday");
            days.Enqueue("friday");
            days.Enqueue("saturday");

            for (int i = days.Count; i > 0; i--)
            {
                Console.WriteLine(days.Dequeue().ToString());
            }

            Console.ReadKey();

        }
    }
    }