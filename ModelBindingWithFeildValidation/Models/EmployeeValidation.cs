using System.ComponentModel.DataAnnotations;

namespace ModelBindingWithFeildValidation.Models
{
    public class EmployeeValidation
    {
        [Required(ErrorMessage = "Name is required!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required!!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile no is required!!")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public string MobNo { get; set; }

        [Required(ErrorMessage = "Designation is required!!")]
        public string Designation { get; set; }


    }
}