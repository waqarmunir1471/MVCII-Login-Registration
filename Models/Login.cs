using System;
using System.ComponentModel.DataAnnotations;

namespace MVCII_Login_Registration.Models
{
    public class Login
    {
        [Required(ErrorMessage="Email Field is Required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Login Email : ")]

        public string LoginEmail {get;set;}
        
        [Required(ErrorMessage="Password Field is Required")]
        [DataType(DataType.Password)]
        [Display(Name="Login Password : ")]

        public string LoginPassword{get;set;}
    }
}