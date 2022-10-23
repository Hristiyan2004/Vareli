using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class User
    {
        public int RoleId { get;set; }
        public string RoleName { get;set; } 
        public ICollection<User> Users { get; set; }
    }
}
