using Flunt.Notifications;
using System;
using System.ComponentModel.DataAnnotations;

namespace Core
{
    public abstract class BaseEntity : Notifiable<Notification>
    {
        public BaseEntity()
        {
            Id = new Guid();
        }

        [Key]
        public Guid Id { get;  private set; }
    }
}
