using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleApplication.Models
{
    public class User
    {
        [Key]
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Username { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string Mobile { set; get; }
        public string Address { set; get; }
    }
}