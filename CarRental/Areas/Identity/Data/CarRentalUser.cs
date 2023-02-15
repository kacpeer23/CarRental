﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CarRental.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CarRentalUser class
public class CarRentalUser : IdentityUser
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}

