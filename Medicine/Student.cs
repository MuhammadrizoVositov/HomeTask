﻿using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public  string? PhoneNumber { get; set; }
        public string? EmailAdress { get; set; }
    }
}
