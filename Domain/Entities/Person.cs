using Core;
using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Person : BaseEntity
    {
        public Person(string name, string lastName, string document, string email, List<Subscription> _subscriptions)
        {
            Name = name;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(new PersonContract(this));
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public List<Address> Address { get; set; }
        private List<Subscription> _subscriptions;
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

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
