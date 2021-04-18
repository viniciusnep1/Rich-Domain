using Core;
using Domain.Contracts;
using Domain.enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("person")]
    public class Person : BaseEntity
    {
        public Person(string name, string lastName, string email, DocumentType documentType, string documentNumber)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            DocumentNumber = documentNumber;
            DocumentType = documentType;
            this._subscriptions = new List<Subscription>(); 
            AddNotifications(new PersonContract(this));
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public List<Address> Address { get; set; }

        private List<Subscription> _subscriptions;
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
        public DocumentType DocumentType { get; private set; }
        public string DocumentNumber { get; private set; }


        //Deactivating all subscription before add a new subscription
        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;

            _subscriptions.ForEach(item => { if (item.Active) hasSubscriptionActive = true; });
            if (hasSubscriptionActive) AddNotification("Person.Subscriptions", "Você já possui assinatura ativa!");

            _subscriptions.Add(subscription);
        }
    }
}
