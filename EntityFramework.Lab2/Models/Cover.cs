﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab2.Models
{
    public class Cover
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public Book Book { get; set; }
    }
}
