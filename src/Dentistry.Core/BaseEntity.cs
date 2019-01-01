using System;
using System.ComponentModel.DataAnnotations;

namespace Dentistry.Core
{
    public abstract class BaseEntity<TPrimaryKey> 
    {
        [Key]
        public virtual TPrimaryKey Id { get; set; }
        public DateTime? SystemDate { get; set; }
    }
}
