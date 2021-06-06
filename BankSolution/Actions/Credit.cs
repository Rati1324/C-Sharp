using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Actions
{
    public class Credit
    {
        private string personID;
        private DateTime creditDate = DateTime.Now;
        private decimal amount;
        private string currency;
        private decimal interest;
        private DateTime DueDate;
        private decimal leftToPay;

        public Credit(string personID, DateTime creditDate, decimal amount, string currency,
            decimal interest, DateTime DueDate, decimal leftToPay)
        {
            this.personID = personID;
            this.creditDate = creditDate;
            this.amount = amount;
            this.currency = currency;
            this.interest = interest;
            this.leftToPay = leftToPay;
            this.DueDate = DueDate; 

            var X = XElement.Load("../../../BankForm/bin/Debug/Credit.xml");
            X.Add(new XElement("Credit",
                new XElement("Person_ID", personID),
                new XElement("Credit_Date", creditDate.ToString()),
                new XElement("Amount", amount),
                new XElement("Currency", currency),
                new XElement("Interest", interest),
                new XElement("leftToPay", leftToPay),
                new XElement("Due_Date", DueDate)));
            X.Save("../../../BankForm/bin/Debug/Credit.xml");
        }
        

    }
}
