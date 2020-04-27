using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Money2Go.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public string Credit { get; set; }

        public ICollection<Project> projects { get; set; }

        public string Country { get; set; }


    }

}
