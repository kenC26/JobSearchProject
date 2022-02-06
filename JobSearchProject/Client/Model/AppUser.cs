using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace JobSearchProject.Client.Model
{
    public class AppUser
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string NormalizedEmail { get; set; }
        public string Email { get; set; }
        public string NormalizedUserName { get; }
        public string UserName { get; set; }
        public string Id { get; set; }
    }
}
