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

            Console.WriteLine("" + newList.First.Data + "");
        }
    }
}