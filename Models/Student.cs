﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationApp.Models
{
    public class Student : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Class { get; set; }

        public int ResCount { get; set; }

    }
}
