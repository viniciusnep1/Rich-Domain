using Domain.Entities;
using Domain.enums;
using Flunt.Validations;

namespace Domain.Contracts
{
    public class PersonContract : Contract<Person>
    {
        public PersonContract(Person person)
        {
            Requires()
                .IsNotNullOrEmpty(person.Name, "Name", "Nome não pode ser nulo")
                .IsNotNullOrEmpty(person.LastName, "LastName", "Sobrenome não pode ser nulo")
                .IsTrue(Validate(person), "Document.Number", "Documento inválido");
        }

        private bool Validate(Person person)
        {
            if (person.DocumentType == DocumentType.CNPJ && person.DocumentNumber.Length == 14)
                return true;

            if (person.DocumentType == DocumentType.CPF && person.DocumentNumber.Length == 11)
                return true;

            return false;
        }
    }
}
