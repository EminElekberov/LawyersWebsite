using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Models.AdminAccount
{
    public class ForgetPassword
    {
        [Required]
        [StringLength(maximumLength:100)]
        public string Email { get; set; }
    }
}
