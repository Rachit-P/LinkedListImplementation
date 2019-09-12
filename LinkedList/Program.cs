using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create sample Node items 
            Node node1 = new Node() { ValueOfNode = 1 };
            Node node2 = new Node() { ValueOfNode = 2 };
            Node node3 = new Node() { ValueOfNode = 3 };
            Node node4 = new Node() { ValueOfNode = 4 };
            Node nodeToAddInBetween = new Node() { ValueOfNode = 88 };

            // Create a Linked list instance and add some sample nodes
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeToLinkedList(node1);
            linkedList.AddNodeToLinkedList(node2);
            linkedList.AddNodeToLinkedList(node3);
            linkedList.AddNodeToLinkedList(node4);
            Console.WriteLine("Linked list items after adding all sample nodes: ");
            linkedList.ReadAndPrintAllNodes();

            // Add a node in between the Linked list, shifting all the nodes after that
            linkedList.AddNodeToLinkedList(nodeToAddInBetween, node2);
            Console.WriteLine("Linked list items after adding a node at second place and shifting elements after it: ");
            linkedList.ReadAndPrintAllNodes();

            // Update a node's value in the Linked list
            linkedList.UpdateNodeInLinkedList(node3, 41);
            Console.WriteLine("Linked list items after updating third node: ");
            linkedList.ReadAndPrintAllNodes();

            // Delete a linked list item, in this example it's the head which is being deleted and second node will become head
            linkedList.DeleteNodeFromLinkedList(node1);
            Console.WriteLine("Linked list items after deleting head node, making second node as the head: ");
            linkedList.ReadAndPrintAllNodes();

            Console.ReadKey();
        }
    }
}
