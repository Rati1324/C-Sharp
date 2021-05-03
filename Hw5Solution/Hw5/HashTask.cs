using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public class HashTask
    {   
        //14.1.7. შექმენით 10-ელემენტიანი ჰეშ-ცხრილი.ჰეშ-ცხრილში შეასრულეთ ძებნა გასაღებისა და
        //სიდიდის მიხედვით.ნაპოვნი გასაღები და სიდიდე ეკრანზე გამოიტანეთ.ეკრანზე გამოიტანეთ
        //ჰეშ-ცხრილში ელემენტების რაოდენობა და ყველა გასაღები და ყველა სიდიდე.
        public static string FindByKey(Hashtable h, string key)
        {
            if (h.ContainsKey(key)) return (string) h[key];
            return "Not Found";
        }
        
    }
}
