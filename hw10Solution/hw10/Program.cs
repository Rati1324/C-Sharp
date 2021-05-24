using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace hw10
{
    class Program
    {
        //14.1.3. შექმენით 10-ელემენტიანი დინამიური მასივი სტრიქონების მასივის საფუძველზე.
        // დინამიურ მასივს ჩაუმატეთ სტრიქონი მე-2 პოზიციიდან.ეკრანზე გამოიტანეთ დინამიურ
        //მასივში ელემენტების რაოდენობა და თვით დინამიური მასივი.
        public static void task()
        {
            List<string> L = new List<string>()
            {
                "String1",
                "String2",
                "String3",
                "String4",
                "String5",
                "String5",
                "String6",
                "String7",
                "String8",
                "String9",
                "String10",
            };
            Console.WriteLine("Enter a string you want to insert:");
            string S = Console.ReadLine();

            Console.WriteLine("After which element to insert (1-10):");

            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                throw new Exception("Only positive integers allowed");
            }
            if (index < 1 || index > 10) throw new Exception("Only integers from 1-10 allowed");
            L.Insert(index, S);

            Console.WriteLine("\nSuccessfully inserted string");
            Console.WriteLine($"\nLength of the List: {L.Count}");
            Console.WriteLine("\nAll elements of the list:");
            foreach (var item in L)
            {
                Console.WriteLine(item);
            }
        }

        public static void task_2()
        {
            //14.2.2.შექმენით 5 - ელემენტიანი რიგი.წაიკითხეთ და ეკრანზე გამოიტანეთ რიგის I ელემენტის
            //მნიშვნელობა მისი წაშლის გარეშე.ეკრანზე გამოიტანეთ რიგში არსებული ელემენტების
            //რაოდენობა და რიგის ყველა ელემენტი. რიგიდან ყველა ელემენტი წაშალეთ.
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(2);
            Q.Enqueue(4);
            Q.Enqueue(6);
            Q.Enqueue(3);
            Q.Enqueue(7);

            Console.WriteLine($"number of elements: {Q.Count()}");
            Console.WriteLine($"\nall elements:");
            foreach (var item in Q)
            {
                Console.WriteLine(item);
                
            }
            int len = Q.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Deleting Element {i+1}");
                Q.Dequeue();
                Thread.Sleep(500);
            }
             
            Console.WriteLine("\nall elements deleted");

        }
        static void Main(string[] args)
        {
            task_2();
        }
    }
}
