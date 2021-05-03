using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Temp
{
    class stacktask
    {
        //14.2.3. შექმენით 10-ელემენტიანი სტეკი.წაიკითხეთ და ეკრანზე გამოიტანეთ სტეკის
        //უკანასკნელი ელემენტის მნიშვნელობა მისი წაშლის გარეშე. ეკრანზე გამოიტანეთ სტეკში
        //არსებული ელემენტების რაოდენობა და სტეკის ყველა ელემენტი. სტეკიდან ყველა ელემენტი
        //წაშალეთ.
        public static void stacktask1()
        {
            Stack x = new Stack();
            int num;
            Console.WriteLine("enter the number of elements you want to add");
            if (!Int32.TryParse(Console.ReadLine(), out num)) { throw new Exception("you can only enter a number"); }
            for (int i = 0; i < num; i++)
            {
                x.Push(Console.ReadLine());
            }
            Console.WriteLine(x.Count);

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            x.Clear();
            Console.ReadKey();
        }
    }
}
