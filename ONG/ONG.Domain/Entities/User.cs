﻿using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Age { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Uf { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }

        public bool PasswordIsValid(string password)
        {
            return Password == password;
        }
    }
}
