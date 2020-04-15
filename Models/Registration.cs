using System.ComponentModel.DataAnnotations;
namespace MVCII_Login_Registration.Models
{
    public class Registration
    {
        [Required(ErrorMessage="First Name must be at least 2 Characters Long")]
        [Display(Name="First Name : ")]
        [MinLength(2)]
        public string FirstName {get;set;}
        [Required(ErrorMessage="Last Name must be at least 2 Characters Long")]
        [MinLength(2)]
        [Display(Name="Last Name : ")]
        public string LastName{get;set;}
        [Required(ErrorMessage="Please Enter a Valid Email")]
        [Display(Name="Email Name : ")]
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}
        [Required(ErrorMessage="Please Enter a Valid Password")]
        [MinLength(8)]
        [Display(Name="Password : ")]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password : ")]
        [MinLength(8)]
        public string ConfirmPassword{get;set;}
    }
}