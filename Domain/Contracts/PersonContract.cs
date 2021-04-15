using Domain.Entities;
using Flunt.Validations;

namespace Domain.Contracts
{
    public class PersonContract : Contract<Person>
    {
        public PersonContract(Person person)
        {
            Requires()
                .IsNotNullOrEmpty(person.Name, "Name", "Nome não pode ser nulo")
                .IsNotNullOrEmpty(person.LastName, "LasName", "Sobrenome não pode ser nulo");
        }
    }
}
