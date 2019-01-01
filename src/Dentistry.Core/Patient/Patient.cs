using System.ComponentModel.DataAnnotations.Schema;

namespace Dentistry.Core.Patient
{
    [Table("Patient")]
    public class Patient : BaseEntity<long>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
