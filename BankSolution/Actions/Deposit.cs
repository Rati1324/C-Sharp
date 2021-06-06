using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Actions
{
    public class Deposit
    {
        private string PersonID;
        private DateTime creationDate;
        private decimal moneyAmount;
        private string currency;
        private decimal interestRate;
        private string userID;

        public Deposit(string PersonID, DateTime creationDate, decimal moneyAmount, string currency,
            decimal interestRate, string userID)
        {
            this.PersonID = PersonID;
            this.creationDate = creationDate;
            this.moneyAmount = moneyAmount;
            this.currency = currency;
            this.interestRate = interestRate;
            this.userID = userID;

            var X = XElement.Load("../../../BankForm/bin/Debug/Deposit.xml");
            X.Add(new XElement("Deposit",
            new XElement("Person_ID", PersonID),
            new XElement("Creation_Date", creationDate.ToString()),
            new XElement("Money_Amount", moneyAmount),
            new XElement("Currency", currency),
            new XElement("Interest_Rate", interestRate),
            new XElement("User_ID", userID)));
            X.Save("../../../BankForm/bin/Debug/Deposit.xml");
        }

    }
}
