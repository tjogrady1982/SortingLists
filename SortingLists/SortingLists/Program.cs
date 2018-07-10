using System;
using System.Collections;
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

            var doublelinkedlist = new DoublyLinkedList();

            doublelinkedlist.Find("Fred");
            doublelinkedlist.Add("Fred");
            doublelinkedlist.Find("Fred");
            doublelinkedlist.Find("Wilma");
            doublelinkedlist.Add("Wilma");
            doublelinkedlist.Find("Wilma");

            doublelinkedlist.ShowNodes();

            var seconddoublelinkedlist = new DoublyLinkedList();
            seconddoublelinkedlist.Add("fred");
            seconddoublelinkedlist.Add("wilma");
            seconddoublelinkedlist.Add("betty");
            seconddoublelinkedlist.Add("barney");

            seconddoublelinkedlist.ShowNodes();

            seconddoublelinkedlist.Delete("fred");

            seconddoublelinkedlist.ShowNodes();

            seconddoublelinkedlist.Delete("betty");

            seconddoublelinkedlist.ShowNodes();


            var arraylist = new ArrayList();
            arraylist.Contains("Fred"); //should be false
            arraylist.Add("Fred");
            arraylist.Contains("Fred"); //should be true
            arraylist.Contains("Wilma"); //should be false
            arraylist.Add("Wilma");
            arraylist.Contains("Wilma"); //should be true

            foreach(var item in arraylist)
            {
                Console.WriteLine(item);
            }

            var secondarraylist = new ArrayList();

            secondarraylist.Add("fred");
            secondarraylist.Add("wilma");
            secondarraylist.Add("betty");
            secondarraylist.Add("barney");


            foreach (var item in secondarraylist)
            {
                Console.WriteLine(item);
            }

            secondarraylist.Remove("wilma");
            secondarraylist.Remove("barney");

            foreach (var item in secondarraylist)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }
}
