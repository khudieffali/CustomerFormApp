﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CustomersFormApp.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
