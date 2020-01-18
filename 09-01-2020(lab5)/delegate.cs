using System;


namespace @delegate
{
    class Program
    {
    public delegate void mydelegate();
        class A
        {
            public static void M1()
            {
                Console.WriteLine("it is method M1");
            }
            static void Main()
            {
                mydelegate obj1 = new mydelegate(M1);
                obj1();
            }
        }
        }
    }

    

