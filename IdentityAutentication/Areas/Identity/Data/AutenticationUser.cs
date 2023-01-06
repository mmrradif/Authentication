using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityAutentication.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AutenticationUser class
public class AutenticationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

