using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Userticket
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل را درست وارد کنید")]
        public string Email { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Services { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Message { get; set; }
    }
}
