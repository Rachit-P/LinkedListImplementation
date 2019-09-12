using System;

namespace LinkedList
{
    class Node
    {
        public int? ValueOfNode;
        public Node NextNode;
    }

    class LinkedList
    {
        Node head = null;

        #region [Public Methods]
        /// <summary>
        /// This method reads all the elements of the linked list and prints them on the console
        /// </summary>
        public void ReadAndPrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.ValueOfNode);
                current = current.NextNode;
            }
        }

        /// <summary>
        /// This method handles adding items to linked list.
        /// It handles following conditions: 
        /// 1) Adding elements to an empty list
        /// 2) Adding elements in between
        /// 3) Adding elements at the end
        /// </summary>
        /// <param name="nodeToAdd"></param>
        /// <param name="nodeToAddAfter"></param>
        public void AddNodeToLinkedList(Node nodeToAdd, Node nodeToAddAfter = null)
        {
            // If the Linked list is empty and we are adding the first element
            if (head == null)
            {
                head = nodeToAdd;
                return;
            }
            // If we have to add in between, then using a temporary node we will add it
            if (nodeToAddAfter != null && nodeToAddAfter.NextNode != null)
            {
                Node nodeNextToNodeToAddAfter = nodeToAddAfter.NextNode;
                nodeToAddAfter.NextNode = nodeToAdd;
                nodeToAdd.NextNode = nodeNextToNodeToAddAfter;
                return;
            }
            // If we have to insert the element at the end of the linked list
            // Traverse and reach the end of linked list add the element there
            // If nothing is passed to returnNodePreviousToThePassedOne() 
            // then it returns last node of Linked List.
            returnNodePreviousToThePassedOne().NextNode = nodeToAdd;
        }

        /// <summary>
        /// Update node value in Linked list
        /// </summary>
        /// <param name="nodeToBeUpdated"></param>
        /// <param name="valueToUpdate"></param>
        public void UpdateNodeInLinkedList(Node nodeToBeUpdated, int valueToUpdate)
        {
            nodeToBeUpdated.ValueOfNode = valueToUpdate;
        }

        /// <summary>
        /// This method deletes a particular node from the Linked list by breaking the link
        /// </summary>
        /// <param name="nodeToDelete"></param>
        public void DeleteNodeFromLinkedList(Node nodeToDelete)
        {
            if (nodeToDelete != head)
            {
                returnNodePreviousToThePassedOne(nodeToDelete).NextNode = nodeToDelete.NextNode;
            }
            else
            {
                head = nodeToDelete.NextNode;
            }
            nodeToDelete.NextNode = null;
        }
        #endregion

        #region [Private Methods]
        /// <summary>
        /// This method returns the last node of the linked list if null is passed
        /// Or the Node previous to the one passed
        /// It returns null if the list is empty
        /// </summary>
        /// <returns></returns>
        private Node returnNodePreviousToThePassedOne(Node traverseTill = null)
        {
            Node lastNode = head;
            Node currentNode = head;
            while (currentNode != traverseTill)
            {
                lastNode = currentNode;
                currentNode = currentNode.NextNode;
            }
            return lastNode;
        }
        #endregion
    }
}
