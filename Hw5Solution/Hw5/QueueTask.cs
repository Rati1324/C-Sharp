using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class QueueTask
    {
        //14.2.2. შექმენით 10-ელემენტიანი რიგი.წაიკითხეთ და ეკრანზე გამოიტანეთ რიგის I ელემენტის
        //მნიშვნელობა მისი წაშლის გარეშე. ეკრანზე გამოიტანეთ რიგში არსებული ელემენტების
        //რაოდენობა და რიგის ყველა ელემენტი. რიგიდან ყველა ელემენტი წაშალეთ.
        public static void Que()
        {
                Queue x = new Queue();
                int num;
                Console.WriteLine("enter the number of elements you want to add");
                if (!Int32.TryParse(Console.ReadLine(), out num)) { throw new Exception("you can only enter a number"); }
                for (int i = 0; i < num; i++)
                {
                    x.Enqueue(Console.ReadLine());
                }
                foreach (var item in x)
                {
                    Console.WriteLine(item);
                }
                x.Clear();
                Console.ReadKey();
        }
    }
}
