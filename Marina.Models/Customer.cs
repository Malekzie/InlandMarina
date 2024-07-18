using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marina.Models
{
    public class Customer: IdentityUser
    {

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string City { get; set; }

        //Navigation Property
        public virtual ICollection<Lease> Leases { get; set; }

    }
}
