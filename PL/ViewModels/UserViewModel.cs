﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo.PL.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string fname  { get; set; }
        public string lname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }

        public UserViewModel()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}
