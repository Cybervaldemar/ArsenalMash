using Site.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class UserRoleViewModel
    {
        public int ID { get; set; }
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}