using System;
using System.Collections.Generic;
using System.Linq;

namespace new_app
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Enter Number a:");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number b:");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number c:");
            c = float.Parse(Console.ReadLine());

            float[,] matrix = new float[,] {
                { 1, 4, 2, 65 },
                { 5, 3, 64, 11 },
                { 7, 2, 4, 8 },
                { -4, 4, -2, 1 }
            };

            float[] arr = new float[] { -3, 5, 2, -2, 3 };
            int[] arr2 = new int[] { -3, 5, 2, -2, 3 };

            Console.WriteLine("Task 2 Triangle Result:");
            Console.WriteLine(Tasks.Task_2.triangle(a, b, c) + "\n");

            Console.WriteLine("Task 3 num_range Result:");
            Console.WriteLine(Tasks.Task_3.num_range(a) + "\n");

            Console.WriteLine("Task 4 higher_than_b Result:");
            Console.WriteLine(Tasks.Task_4.higher_than_b(arr, b) + "\n");

            Console.WriteLine("Task 4 even_nums Result:");
            Console.WriteLine(Tasks.Task_4.even_nums(arr2) + "\n");

            Console.WriteLine("Task 4 largest_negative Result:");
            Console.WriteLine(Tasks.Task_4.largest_negative(arr) + "\n");

            Console.WriteLine("Task 4 nums_in_array Result:");
            Console.WriteLine(Tasks.Task_4.nums_in_array_range(arr, a, b) + "\n");

            Console.WriteLine("Task 4 diagonal Result:");
            Console.WriteLine(Tasks.Task_4.diagonal(matrix) + "\n");
        }

    }
}

