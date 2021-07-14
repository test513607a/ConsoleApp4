using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // name, phonnumber
            // customer object - name, phone
            // DataStructure - 
            // 4 operations 
            // insert, delete, getall, getbyname, getbyphone
            // single linked list - 
            // assumpition : going by the uniqueness of NAme, Number
            // for simplicity sake
            Console.WriteLine("Hello World!");

            LinkedList ll = new LinkedList();


            ll.AddToLinkedList(new Customer("a","123"));
            ll.AddToLinkedList(new Customer("b","124"));
            ll.AddToLinkedList(new Customer("c","124"));

            ll.RemoveFromLinkedList(new Customer("b","124"));

            ll.DisplayAllItems();
        
        
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Customer(string _Name, string _PhoneNumber)
        {
            Name = _Name;
            PhoneNumber = _PhoneNumber;
        }
    }
    public class LinkedListNode
    {
        public Customer Value { get; set; }

        public LinkedListNode Next { get; set; }

    }
    public class LinkedList
    {
        public LinkedListNode First { get; set; }
        public LinkedListNode Last { get; set; }

        public LinkedListNode AddToLinkedList(Customer _value)
        {
            LinkedListNode node = new LinkedListNode();
            node.Value = _value;

            if (First == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }

            return node;
        }

       


        public void RemoveFromLinkedList(Customer _cust)
        {

            LinkedListNode previousNode = null, currentNode = First, Initial;
            while (currentNode != null)
            {
                if (currentNode != null && currentNode.Value.Name == _cust.Name )
                {
                    if (previousNode == null)
                    {
                        Initial = currentNode.Next;
                    }
                    else
                    {
                        previousNode.Next = currentNode.Next;
                        //currentNode = null;
                    }
                }
                else
                {
                    previousNode = currentNode;
                }
                currentNode = currentNode.Next;
            }

        }

     
        public void DisplayAllItems()
        {
            LinkedListNode current = First;
            while (current != null)
            {
                Console.WriteLine($"{current.Value.Name} - {current.Value.PhoneNumber}");
                current = current.Next;
            }
        }
    }
}
