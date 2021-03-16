using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Dto
{
    public class PersonDto
    {
        public string Identification { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? Datebirth { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public int PlaceId { get; set; }
    }
}
