using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using UserRegistrationAssignment.CustomValidations;

namespace UserRegistrationAssignment.Models
{
    public class User
    {
        [Required(ErrorMessage ="Name can not be blank")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email can not be blank")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please provide the password")]
        [MinLength(8,ErrorMessage ="Password length should be 8 minimum")]
        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*",ErrorMessage = "Please use one lower and one upper case letter")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Confirm Password can not be blank")]
        [Compare("Password",ErrorMessage ="Confirm Password doesnot match with Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Please provide contact number.")]
        [RegularExpression(@"^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$", ErrorMessage = "Invalid Contact Number.")]
        public string Contact { get; set; }
        [Required(ErrorMessage ="Please specify your gender")]
        public Gender Gender { get; set; }
        [CheckBoxValidation(ErrorMessage = "Please Accept Terms")]
        public bool AcceptTerms { get; set; }

    }
    public enum Gender
    {
        Male = 0,
        Female = 1,
        Other = 2,
    }
}
