using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_RepositoryDLL.Models
{
    public class RegisterModel
    {
        [Required]
        public string Fullname { get; set; }

        //PASSWORD
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your confirm password was not match")]
        public string ConfirmPassword { get; set; }
        //END PASSWORD

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
    }
}