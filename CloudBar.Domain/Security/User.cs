using CloudBar.Domain.General;
using System;

namespace CloudBar.Domain.Security
{
    public class User : BaseEntity
    {
        public Guid RoleId { get; set; }
        public Guid PersonId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }
        public Person Person { get; set; }
    }
}
