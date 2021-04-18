using Core;
using Domain.Contracts;
using Domain.enums;
using Flunt.Notifications;
using Flunt.Validations;

namespace Services.Commands.PersonCommand
{
    public class PersonCommand : Notifiable<Notification>, ICommand
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentNumber { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract<PersonCommand>()
                .Requires()
                .IsNotNullOrEmpty(Name, "Name", "Nome não pode ser nulo")
                .IsNotNullOrEmpty(LastName, "LastName", "Sobrenome não pode ser nulo")
                .IsTrue(ValidateDocument(), "Document.Number", "Documento inválido"));
        }


        private bool ValidateDocument()
        {
            if (DocumentType == DocumentType.CNPJ && DocumentNumber.Length == 14)
                return true;

            if (DocumentType == DocumentType.CPF && DocumentNumber.Length == 11)
                return true;

            return false;
        }
    }
}
