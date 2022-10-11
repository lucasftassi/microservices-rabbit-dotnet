using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace microservices_rabbit.model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("Key")]
        public long Id { get; set; }
    }
}

