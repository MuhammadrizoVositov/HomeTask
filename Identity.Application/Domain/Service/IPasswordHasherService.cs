﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Domain.Settings
{
    public interface IPasswordHasherService
    {
      string HashPassword(string password);
        
      bool ValidatePassword(string password,string hashedPassword);
    }
}
