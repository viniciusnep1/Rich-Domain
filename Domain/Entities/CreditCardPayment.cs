using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{

    public class CreditCardPayment : PaymentMethod
    {
        public CreditCardPayment(string cardHolderName, string creditCardNumber, string lastTransactionNumber,int number, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, string document, string email) : base(number, paidDate, expireDate, total, totalPaid, owner, document, email)
        {
            CardHolderName = cardHolderName;
            CreditCardNumber = creditCardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get;private set; }
        public string CreditCardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}
