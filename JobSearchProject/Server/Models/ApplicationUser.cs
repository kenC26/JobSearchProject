using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchProject.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name{ get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string qualification { get; set; }
        public string salary { get; set; }
    }
}
