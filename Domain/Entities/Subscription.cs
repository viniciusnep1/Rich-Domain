using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("subscription")]
    public class Subscription : BaseEntity
    {
        public Subscription(DateTime creatDate, DateTime updateDate, DateTime? expiseDate, bool active)
        {
            CreatDate = creatDate;
            UpdateDate = updateDate;
            ExpiseDate = expiseDate;
            Active = active;
            _paymentMethods = new List<PaymentMethod>();
        }

        public DateTime CreatDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        public DateTime? ExpiseDate { get; private set; }
        public bool Active { get; private set; }
        private List<PaymentMethod> _paymentMethods { get; set; }
        public IReadOnlyCollection<PaymentMethod> PaymentMethods { get; private set; }
        
        public void AddPaymentMethod(PaymentMethod paymentMethod)
        {
            _paymentMethods.Add(paymentMethod);
        }

        public void Activated()
        {
            Active = true;
            UpdateDate = DateTime.Now;
        }

        public void Deactivated()
        {
            Active = false;
            UpdateDate = DateTime.Now;
        }
    }
}
