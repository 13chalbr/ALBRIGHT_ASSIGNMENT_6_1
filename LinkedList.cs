using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_6_1
{
    public class LinkedList
    {
        internal Node head { get; set; }
        // public int length { get; set; } if i wanted to use a for loop instead of foreach

        public LinkedList()
        {
            head = null;
        }
        public void AddFirst(House data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void AddLast(House data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public static void PrintLinkedList(LinkedList<House> houses)
        {
            foreach (House house in houses)
            {
                Console.WriteLine(house + " -> ");
            }
        }
        public static void SearchLinkedList(LinkedList<House> houses, int searchID)
        {
            int iD = searchID;
            LinkedList <House> referenceList = houses;
            House foundObject = FindObjectByHouseNumber(referenceList, iD);
            if (foundObject != null)
            {
                Console.WriteLine($"Found object: HouseNumber = {foundObject.HouseNumber}, Address = {foundObject.Address}, Type = {foundObject.Type}");
            }
            else
            {
                Console.WriteLine($"Object with Id = {iD} not found.");
            }
        }
        public static House FindObjectByHouseNumber(LinkedList<House> houses, int searchID)
        {
            foreach (var item in houses)
            {
                if (item.HouseNumber == searchID)
                {  
                    return item; 
                }
            }
            return null;
        }
    }
}
