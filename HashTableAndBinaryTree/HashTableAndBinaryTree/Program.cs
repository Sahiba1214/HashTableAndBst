using System;

namespace HashTableAndBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table Demo");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("0", "be");
            hash.Add("0", "or");
            hash.Add("0", "not");
            hash.Add("0", "to");
            hash.Add("0", "be");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: " + hash5);
            //hash Remove ("2");
            string hash2 = hash.Get("2");
            Console.WriteLine("2th index value: " + hash2);


        }
    }
}
