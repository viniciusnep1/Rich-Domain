using Domain.Entities;
using Flunt.Validations;

namespace Domain.Contracts
{
    public class PaymentContract : Contract<PaymentMethod>
    {
        public PaymentContract(PaymentMethod paymentMethod)
        {
            Requires()
                .IsNotNullOrEmpty(paymentMethod.Document, "Document", "Documento não pode ser nulo")
                .IsEmailOrEmpty(paymentMethod.Email, "Email")
                .IsNotNull(paymentMethod.PaidDate, "PaidDate")
                .IsNotNull(paymentMethod.ExpireDate, "ExpireDate")
                .IsGreaterOrEqualsThan(0, paymentMethod.Total, "Total");
        }
    }
}
