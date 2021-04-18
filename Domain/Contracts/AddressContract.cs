using Domain.Entities;
using Flunt.Validations;

namespace Domain.Contracts
{
    public class AddressContract : Contract<Address>
    {
        public AddressContract(Address person)
        {
            Requires()
                .IsNotNull(person.Number, "Address.Number")
                .IsLowerThan(person.Number, 0, "Address.Number", "O númeor da casa deve ser maior que 0")
                .IsLowerThan(person.Street, 4, "Address.Street", "O nome da rua deve conter pelo menos 4 caracteres");

        }
    }
}
