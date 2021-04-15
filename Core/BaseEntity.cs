using Flunt.Notifications;
using System;

namespace Core
{
    public abstract class BaseEntity : Notifiable<Notification>
    {
        public BaseEntity()
        {
            Id = new Guid();
        }
        public Guid Id { get;  private set; }
    }
}
