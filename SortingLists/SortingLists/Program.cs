using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //test of singly linked list
            var linkedlist = new SinglyLinkedList();

            linkedlist.Find("Fred");
            linkedlist.Add("Fred");
            linkedlist.Find("Fred");
            linkedlist.Find("Wilma");
            linkedlist.Add("Wilma");
            linkedlist.Find("Wilma");

            var list = new SinglyLinkedList();

            list.Add("fred");
            list.Add("wilma");
            list.Add("betty");
            list.Add("barney");

            list.ShowNodes();

            list.Delete("wilma");
            list.Delete("barney");
            list.Delete("fred");
            list.Delete("betty");

            list.ShowNodes();


            Console.ReadLine();
        }
    }
}
