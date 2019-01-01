using System.ComponentModel.DataAnnotations.Schema;

namespace Dentistry.Core.Dentist
{
    [Table("Dentist")]
    public class Dentist : BaseEntity<long>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Proficiency Proficient { get; set; }
    }
}
