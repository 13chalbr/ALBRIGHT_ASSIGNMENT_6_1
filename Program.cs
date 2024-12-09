using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_6_1
{
    internal class Program
    {
        // MSSA CCAD16 - 09DEC2024
        // CHRIS ALBRIGHT
        // ASSIGNMENT 6.1
        static void Main(string[] args)
        {
            // Assignment 6.1.1 ---------------------------------------------------------------------------------------------

            // Implement a single linked list with each node representing a house. You may add data in it like house number,
            // brief address, type of house ( like Ranch, Colonial) . each house (node) will be linked to next .Give facility
            // to the user to search a house by its number and then display the details. ( Windows / Console)

            Console.WriteLine("Assignment 6.1.1 ----------------------------------------------------------------------------");
            Console.WriteLine("LINKED LIST SEARCHER (HOUSES):");
            char hold1 = 'y';
            do
            {
                LinkedList<House> houseLinkedList = new LinkedList<House>();
                houseLinkedList.AddFirst(new House(1, "123 street", "Townhouse"));
                houseLinkedList.AddLast(new House(2, "456 drive", "Ranchhouse"));
                houseLinkedList.AddLast(new House(3, "789 lane", "Splitlevel"));
                Console.WriteLine("\nHidden Houses 'Database':");
                LinkedList.PrintLinkedList(houseLinkedList);

                Console.WriteLine("\nEnter your target house number:");
                int target = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                LinkedList.SearchLinkedList(houseLinkedList, target);
                Console.WriteLine($"\nWant to go again? type y/n");
                hold1 = Console.ReadKey().KeyChar;
                hold1 = Char.ToLower(hold1);
                
            }
            while (hold1 == 'y');


            // Assignment 6.1.2 ---------------------------------------------------------------------------------------------

            // Explore Linkedlist class from C# library. (COMPLETE)

            Console.WriteLine("\n\nAssignment 6.1.2 ----------------------------------------------------------------------------");
            Console.WriteLine("Linkedlist research - COMPLETE:");

            // Assignment 6.1.3 ---------------------------------------------------------------------------------------------

            // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero
            // elements. Note that you must do this in-place without making a copy of the array.

            Console.WriteLine("\nAssignment 6.1.3 ----------------------------------------------------------------------------");
            Console.WriteLine("ARRAY - ZERO ELEMENT APPENDER:");
            char hold2 = 'y';
            do
            {
                int[] array = { 0, 1, 0, 3, 12 };
                int zeroCount = 0;
                //original array print
                Console.WriteLine("\nOriginal array:");
                foreach (int i in array)
                {
                    Console.WriteLine(i);
                }
                //move forward nonzero elements
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        zeroCount++;
                    }
                    else
                    {
                        array[i - zeroCount] = array[i];
                    }
                }
                //add zeros to end
                for (int i = array.Length-zeroCount; i < array.Length; i++ )
                {
                    array[i] = 0;
                    zeroCount--;
                }
                //print adjusted array
                Console.WriteLine("\n\nAdjusted array:");
                foreach (int i in array)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine($"\nWant to go again? type y/n");
                hold2 = Console.ReadKey().KeyChar;
                hold2 = Char.ToLower(hold2);
            }
            while (hold2 == 'y');

            Console.WriteLine("\nGoodbye!");










        }
    }
}


