// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MovieWorld.EF.Models
{
    public partial class User
    {
        public User()
        {
            Order = new HashSet<Order>();
        }

        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}