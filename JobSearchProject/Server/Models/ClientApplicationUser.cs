﻿using System.Text.Json.Serialization;
namespace JobSearchProject.Server.Models
{
    public class ClientApplicationUser
    {
        public ClientApplicationUser(ApplicationUser AppUser)
        {
            this.Id = AppUser.Id;
            this.Name = AppUser.Name;
            this.PhoneNumber = AppUser.PhoneNumber;
            this.NormalizedEmail = AppUser.NormalizedEmail;
            this.Email = AppUser.Email;
            this.NormalizedUserName = AppUser.NormalizedUserName;
            this.UserName = AppUser.UserName;
        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string NormalizedEmail { get; set; }
        public string Email { get; set; }
        public string NormalizedUserName { get; }
        public string UserName { get; set; }
        public string Id { get; set; }
    }
}
