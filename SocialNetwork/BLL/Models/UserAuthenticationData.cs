﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class UserAuthenticationData //нужен для принятия корректных данных входа
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
