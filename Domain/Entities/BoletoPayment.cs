using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class BoletoPayment : PaymentMethod
    {
        public BoletoPayment(string barCode , string boletoNumber,int number, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, string document, string email) : base(number, paidDate, expireDate, total, totalPaid, owner, document, email)
        {
            this.BarCode = barCode;
            this.BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private  set; }
    }

}
