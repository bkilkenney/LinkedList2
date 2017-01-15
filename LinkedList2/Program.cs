using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class Node
    {
        //Local variables
        public int data;
        public Node next;

        //Constructor
        public Node(int i)
        {
            this.data = i;
            this.next = null;
        }

        //Print method
        public void Print()
        {
            Console.Write("|" + data + "|->");
            if(next != null)
            {
                next.Print();
            }    
        }

        //Add Sorted method
        public void AddSorted(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }

        }

        //Add method
        public void AddToEnd(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }

    public class MyList
    {
        public Node headNode;

        public MyList()
        {
            this.headNode = null;
        }

        public void AddToEnd(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if(headNode == null) //This means the list is empty
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)  //This means all we have to do is add to the beginning which we have already defined a method for:
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }

        public void AddToBeginning(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void Print()
        {
            if(headNode != null)
            {
                headNode.Print();
            }
        }
            
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

        //Create Linked list with AddToBeginning
            //list.AddToBeginning(11);
            //list.AddToBeginning(7);
            //list.AddToBeginning(19);
            //list.AddToBeginning(27);
            //list.AddToBeginning(31);

        //Create Linked List with AddToEnd
            //list.AddToEnd(11);
            //list.AddToEnd(7);
            //list.AddToEnd(19);
            //list.AddToEnd(27);
            //list.AddToEnd(31);

        //Create a Sorted Linked List
            list.AddSorted(11);
            list.AddSorted(7);
            list.AddSorted(19);
            list.AddSorted(27);
            list.AddSorted(31);

            list.Print();
            Console.WriteLine();

        }
    }
}
