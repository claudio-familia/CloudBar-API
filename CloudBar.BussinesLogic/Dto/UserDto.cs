using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Dto
{
    public class UserDto
    {
        public int RoleId { get; set; }
        public int? PersonId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
