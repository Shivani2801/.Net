using System.ComponentModel.DataAnnotations;

namespace JobApplicationGlobal.Models
{
    public class JobApplication
    {

        [Required(ErrorMessage = "Enter your name")]
        [Display(Name = "Job Applicatant Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your Gender")]
        [Display(Name = "Job Applicatant Gender")]
        public string Gender { get; set; }

        [Display(Name = "Job Applicatant Email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter your Dob")]
        [Display(Name = "Job Applicatant Date of birth")]
        public DateTime DOB { get; set; }

        [Range(2, 4, ErrorMessage = "Required experience is between 2 - 4")]
        [Display(Name = "Job Applicatant Experience")]
        public int Experience { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms")]
        [Display(Name = "Terms and conditions")]
        public bool TermsAccepted { get; set; }


    }
}
