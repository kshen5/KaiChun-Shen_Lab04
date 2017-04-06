using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaiChun_Shen_Lab04_Ex1
{
    class StackTest
    {
        // create arrays of ints
        private static int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        private static Stack intStack; // stack stores ints  

        static void Main()
        {
            intStack = new Stack(10); // stack of ints

            TestPushInt(); // push ints onto intStack
            TestPopInt(); // pop ints from intStack
            TestPeekInt();
        }

        // test Push method with intStack
        private static void TestPushInt()
        {
            // push elements onto stack
            try
            {
                Console.WriteLine("\nPushing elements onto intStack");

                // push elements onto stack
                foreach (var element in intElements)
                {
                    Console.Write($"{element} ");
                    intStack.Push(element); // push onto intStack
                }
            }
            catch (StackOverflowException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        // test Pop method with intStack
        private static void TestPopInt()
        {
            // pop elements from stack
            try
            {
                Console.WriteLine("\nPopping elements from intStack");

                int popValue; // stores element removed from stack

                // remove all elements from stack
                while (true)
                {
                    popValue = intStack.Pop(); // pop from intStack
                    Console.Write($"{popValue:F1} ");
                }
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        public static void TestPeekInt()
        {
            try
            {
                Console.WriteLine("\nPeeking elements from intStack");

                int peekValue;
                while (true)
                {
                    peekValue = intStack.Peek();
                    Console.Write($"{peekValue:F1} ");
                }
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }
    }
}
