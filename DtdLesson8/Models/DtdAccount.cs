using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DtdLesson8.Models
{
    public class DtdAccount
    {
        public int ID { get; set; }
        [
        Display(Name = "DtdAccount"),
        Required(ErrorMessage = "Please enter your full name"),
        MinLength(3, ErrorMessage = "Full name must be at least 3 characters long"),
        MaxLength(50, ErrorMessage = "Full name must not exceed 50 characters"),
        ]


        public string DtdFullname { get; set; }
        [Display(Name = "DtdEmail")]
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [DataType(DataType.EmailAddress)]
        public string DtdEmail { get; set; }
        [Display(Name = "DtdPhone")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action: "CheckPhone", controller: "DtdAccount")]


        [Required(ErrorMessage = "Please enter your phone number")]
        public string DtdPhone { get; set; }
        [Display(Name = "DtdAddress")]
        [Required(ErrorMessage = "Please enter your address")]
        [StringLength(100, ErrorMessage = "Address must not exceed 100 characters")]

        public string DtdAddress { get; set; }
        [Display(Name = "DtdAvatar")]
        public string DtdAvatar { get; set; }
        [Display(Name = "DtdBirthday")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter your date of birth")]
        public DateTime DtdBirthday { get; set; }
        [Display(Name = "DtdGender")]
        public string DtdGender { get; set; }
        [Display(Name = "DtdPassword")]
        [DataType(DataType.Password)]
        public string DtdPassword { get; set; }
        [Display(Name = "DtdLink")]
        [Required(ErrorMessage = "Please enter your social media link")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string DtdLink { get; set; }
    }
    
}
