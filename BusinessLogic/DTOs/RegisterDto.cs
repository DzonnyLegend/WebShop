﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.BusinessLogic.DTOs
{
    public class RegisterDto : LoginDto
    {
        public string Email { get; set; }
    }
}
