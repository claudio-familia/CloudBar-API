using CloudBar.Domain.General;
using System;

namespace CloudBar.Domain.Security
{
    public class User : BaseEntity
    {
        public int RoleId { get; set; }
        public int PersonId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }
        public Person Person { get; set; }
    }
}
