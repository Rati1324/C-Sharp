using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class ArrayListTask1
    {
        //14.1.1. შექმენით 10-ელემენტიანი დინამიური მასივი სტრიქონების მასივის საფუძველზე.
        //დინამიურ მასივს დაუმატეთ ორი სტრიქონი. ეკრანზე გამოიტანეთ დინამიურ მასივში
        //ელემენტების რაოდენობა და თვით დინამიური მასივი.
        public static void Task_1()
        {
            ArrayList x = new ArrayList();
            int num;
            Console.WriteLine("enter the number of elements you want to add");
            if (!Int32.TryParse(Console.ReadLine(), out num)){ throw new Exception("you can only enter a number"); }
            for (int i = 0; i < num; i++)
            {
                x.Add(Console.ReadLine());
            }
            Console.WriteLine($"number of elements is {num}");
            Console.WriteLine();
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
