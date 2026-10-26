using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace THWebLap3.Models
{
    public class Student
    {
        public int Id { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please enter your full name")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Name must be between 4 and 100 characters")]
        public string? Name { get; set; }


        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(@"[A-za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please enter a correct valid email address")]
        public string? Email { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter your password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{8,}$", ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, chữ số và ký tự đặc biệt")]
        public string? Password { get; set; }



        [Required]
        public Branch? Branch { get; set; }



        [Required]
        public Gender? Gender { get; set; }



        public bool IsRegular { get; set; }



        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }



        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DataOfBorth { get; set; }



        [Display(Name = "Score")]
        [Required(ErrorMessage = "Please enter your score")]
        [Range(0, 10, ErrorMessage = "Score must be between 0 and 10")]
        [Column(TypeName = "decimal(3, 1)")]
        public decimal? Score { get; set; }
    }
}
