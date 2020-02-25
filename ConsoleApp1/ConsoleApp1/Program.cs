using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node run = new Node();
            Node.CreateLinkedList();
            run.Transvers();
            run.Transversback();
            Console.Read();
        }
    }



    class Node
    {
        public static Node Head, Tail;
        public String name = "yup";
        public Node nextNode;
        public Node previousNode;
        public Node myNode;

        public static void CreateLinkedList()
        {
            Node k = new Node();
            k.name = "basket";
            Head = k;

            Node p = new Node();
            k.nextNode = p;
            p.previousNode = k;
            p.name = "banana";

            Node s = new Node();
            p.nextNode = s;
            s.previousNode = p;
            s.name = "apple";

            Node w = new Node();
            s.nextNode = w;
            w.previousNode = p;
            w.name = "kiwi";
            Tail = w;

        }
        public void Transvers()
        {
            Node currentNode = Head;
            while(currentNode != null )
            {
                Console.WriteLine(currentNode.name);
                currentNode = currentNode.nextNode;

            }
        }
        public void Transversback()
        {
            Node currentNode = Tail;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.name);
                currentNode = currentNode.previousNode;


          
            }
       
        }
   
    }
}
