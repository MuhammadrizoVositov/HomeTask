﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Colors
    {
        public record Color
        {
            public byte Red { get; set; }
            public byte Blue { get; set; }
            public byte Green { get; set; }

        }
    }
}
