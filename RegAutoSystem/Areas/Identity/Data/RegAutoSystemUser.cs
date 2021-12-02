using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RegAutoSystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the RegAutoSystemUser class
    public class RegAutoSystemUser : IdentityUser
    {
        [PersonalData, Column(TypeName = "nvarchar(30)"), Required]
        public string FirstName { get; set; }
        [PersonalData, Column(TypeName = "nvarchar(30)"), Required]
        public string LastName { get; set; }
    }
}
