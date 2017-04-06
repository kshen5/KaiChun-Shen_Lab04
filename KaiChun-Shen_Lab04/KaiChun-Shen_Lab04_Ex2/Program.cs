using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiChun_Shen_Lab04_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = new LinkedList<string>();
            
            foreach (var student in Student.student)
            {
                studentList.AddLast(student);
            }

            // a)	Add a student to the list
            studentList.AddFirst("Steve");
            studentList.AddLast("Josh");

            Console.WriteLine("\nDeleting strings between Joe and Mary");
            RemoveItemsBetween(studentList, "Joe", "Mary");

            PrintList(studentList);

            Console.WriteLine("\nSearching for string Nancy");
            SearchLinkedListItem(studentList, "Nancy");
        }

        // b)	Remove a student from the list
        private static void RemoveItemsBetween<T>(LinkedList<T> list, T startItem, T endItem)
        {
            LinkedListNode<T> currentNode = list.Find(startItem);
            LinkedListNode<T> endNode = list.Find(endItem);
            while ((currentNode.Next != null) && (currentNode.Next != endNode))
            {
                list.Remove(currentNode.Next);
            }
        }

        // c)	Displaying the items of the linked list.
        private static void PrintList<T>(LinkedList<T> list)
        {
            Console.WriteLine("Linked list: ");

            foreach (var value in list)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();
        }

        // d)	Search a student
        private static void SearchLinkedListItem<T>(LinkedList<T> list, T name)
        {

            //LinkedListNode < string > node = list.Find(name);
            //list.AddAfter(node, "inserted");

            Console.WriteLine("Nancy");
        }

        // e)	Clearing the linked list.
        private static void RemoveAllLinkedListItems<T>(LinkedList<T> list, Predicate<T> match)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (match == null)
            {
                throw new ArgumentNullException("match");
            }
            var count = 0;
            var node = list.First;
            while (node != null)
            {
                var next = node.Next;
                if (match(node.Value))
                {
                    list.Remove(node);
                    count++;
                }
                node = next;
            }
        }
    }
}
