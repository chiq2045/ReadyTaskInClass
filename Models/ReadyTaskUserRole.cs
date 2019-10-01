using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadyTask.Models
{
    public class ReadyTaskUserRole : IdentityRole<int>
    {
        public ReadyTaskUserRole()
        {

        }
        public ReadyTaskUserRole(string name)
        {
            Name = name;
        }
    }
}
