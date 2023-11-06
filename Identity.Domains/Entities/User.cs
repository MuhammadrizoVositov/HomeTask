﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domains.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public int Age { get; set; }

        public string EmailAddress { get; set; } = default!;

        public string PasswordHash { get; set; } = default!;

        public bool IsEmailAddressVerified { get; set; }    
    }
}
