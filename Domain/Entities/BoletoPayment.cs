using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class BoletoPayment : PaymentMethod
    {

        public BoletoPayment(string barCode, string boletoNumber,int number, DateTime paidDate, DateTime expiseDate, decimal total, decimal totalPaid, string owner, string document, string email) : base(number, paidDate, expiseDate, total, totalPaid, owner, document, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private  set; }
    }

}
