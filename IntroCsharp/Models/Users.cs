using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;



namespace IntroCsharp.Models
{
    public enum UserRole
    {
        ROLE_USER = 0,
        ROLE_admin = 1
    }

    public class User
    {
        public int ID {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        [Column(TypeName = "nvarchar(255)")]
        public UserRole Role {get; set;}
    }
}