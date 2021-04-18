using Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("person_address")]
    public class PersonAddress : BaseEntity
    {
        [ForeignKey(nameof(Address))]
        public Guid AddressId { get; set; }
        public virtual Address Address { get; set; }

        [ForeignKey(nameof(Person))]
        public Guid PersonId { get; set; }
        public virtual Person Person { get; set; }

    }
}
