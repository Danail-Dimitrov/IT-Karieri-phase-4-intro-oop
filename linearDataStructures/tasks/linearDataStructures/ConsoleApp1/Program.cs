using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main (string[] args)
        {
            //Use only to test the ArrayList class

            var list = new ArrayList<string>();

            list.Add("aaa");
            list.Add("bbb");
            list.Add("ccc");
            list.Insert(1, "ddd");

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Lenght());
            Console.WriteLine(list);

            list.Insert(2, "eee");

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Lenght());
            Console.WriteLine(list);
           
        }
    }
}
