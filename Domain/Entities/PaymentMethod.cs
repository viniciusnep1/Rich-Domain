using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class PaymentMethod : BaseEntity
    {
        protected PaymentMethod(int number, DateTime paidDate, DateTime expiseDate, decimal total, decimal totalPaid, string owner, string document, string email)
        {
            Number = number;
            PaidDate = paidDate;
            ExpiseDate = expiseDate;
            Total = total;
            TotalPaid = totalPaid;
            Owner = owner;
            Document = document;
            Email = email;
        }

        public int Number { get; private set; }
        public DateTime PaidDate{ get; private set; }
        public DateTime ExpiseDate{ get; private set; }
        public decimal Total{ get; private set; }
        public decimal TotalPaid{ get; private set; }
        public string Owner { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }

    }

    public class BoletoPayment : PaymentMethod
    {

        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
    }

    public class CreditCardPayment : PaymentMethod
    {
        public string CardHolderName { get; set; }
        public string CreditCardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }

    public class PayPalPayment : PaymentMethod
    {
        public string TransactionCode { get; set; }

    }
}
