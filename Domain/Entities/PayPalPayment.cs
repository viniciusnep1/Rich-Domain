using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PayPalPayment : PaymentMethod
    {

        public PayPalPayment(string transactionCode,int number, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, string document, string email) : base(number, paidDate, expireDate, total, totalPaid, owner, document, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }

    }
}
