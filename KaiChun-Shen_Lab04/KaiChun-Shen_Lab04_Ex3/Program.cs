using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KaiChun_Shen_Lab04_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeDictionary = new SortedDictionary<string, int>();

            employeeDictionary.Add("Joe", 1000);
            employeeDictionary.Add("Bob", 2000);
            employeeDictionary.Add("Mary", 3000);
            employeeDictionary.Add("Nancy", 4000);
            employeeDictionary.Add("Louis", 5000);
        }

        // a)	Add an employee to the dictionary
        private static AddDictionaryItem(SortedDictionary<int, Employee> var)
        {            
            Console.WriteLine("Enter name of employee: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee salary: ");
            string salary = Console.ReadLine();

            string[] words = Regex.Split(name, @"\s+");
            
            foreach (var word in words)
            {
                var key = word.ToLower();
                
                if (employeeDictionary.ContainsKey(key))
                {
                    ++employeeDictionary[key];
                }
                else
                {
                    // add new word with a count of 1 to the dictionary
                    employeeDictionary.Add(key, 1);
                }
            }
            return employeeDictionary;
        }

        // b)	Remove an employee from the list 
        private static void RemoveDictionaryItem(SortedDictionary<int, Employee> var)
        {

        }

        // c)	Displaying the items of the SortedDictionary. 
        private static void PrintDictionary(SortedDictionary<int, Employee> var)
        {
            Console.WriteLine($"\nSorted dictionary contains:\n{"Key",-12}{"Value",-12}");
            
            foreach (var key in employeeDictionary)
            {
                Console.WriteLine($"{key,-12}{employeeDictionary[key],-12}");
            }

            Console.WriteLine($"\nsize: {employeeDictionary.Count}");
        }

        // d)	Search an employee
        private static void SearchDictionaryItem(SortedDictionary<int, Employee> var)
        {

        }

        // e)	Finding an employee with highest salary 
        private static void MaxDictionaryItem(SortedDictionary<int, Employee> var)
        {

        }
    }
}
