using System;
using System.Collections.Generic;
using System.Text;

namespace Dentistry.Application.Patient.Dto
{
    public class PatientListInput
    {
        public string Filter { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
