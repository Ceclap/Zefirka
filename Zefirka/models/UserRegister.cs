﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zefirka.Models
{
    public class UserRegister
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}