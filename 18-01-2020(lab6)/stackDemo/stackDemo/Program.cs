using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the days are :-");

            Stack days = new stack();
            days.Push("sunday");
            days.Push("monday");
            days.Push("tuesday");
            days.Push("wednesday");
            days.Push("thusday");
            days.Push("friday");
            days.Push("saturday");
            while (days.Count > 0)
            {
                string day = days.Pop().ToString();
                Console.WriteLine(day);

            }
            Console.ReadKey();
        }

    }
}
