using System;

namespace ListOpgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList newList = new();
            
            newList.AddFirst(1);
            newList.AddFirst(2);
            newList.AddFirst(3);

            Console.WriteLine("Number of elements: " + newList.Count());

            Console.WriteLine("Using GetSomething " + newList.GetSomething(0) + "");
            Console.WriteLine("Using GetSomething " + newList.GetSomething(1) + "");
            Console.WriteLine("Using GetSomething " + newList.GetSomething(2) + "");
            // if (newList.First.Data == 1) {
            //     Console.WriteLine("Using GetSomething " + newList.First.Index + "");
            //     Console.WriteLine("Using GetSomething " + newList.GetSomething(0).Data + "");
            // }

            for (int i = 0; i < newList.Count() + 1; i++) {
                Console.WriteLine("[ " + newList.GetSomething(i).Data + " | " + newList.GetSomething(i).Data + " ]");
            }
        }
    }
}