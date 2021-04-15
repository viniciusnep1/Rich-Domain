using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class PaymentMethod : BaseEntity
    {
        public PaymentMethod(int number, DateTime paidDate, DateTime expiseDate, decimal total, decimal totalPaid, string owner, string document, string email)
        {
            Number = number;
            PaidDate = paidDate;
            ExpireDate = expiseDate;
            Total = total;
            TotalPaid = totalPaid;
            Owner = owner;
            Document = document;
            Email = email;
        }

        public int Number { get; private set; }
        public DateTime PaidDate{ get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total{ get; private set; }
        public decimal TotalPaid{ get; private set; }
        public string Owner { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }

    }
   
}
