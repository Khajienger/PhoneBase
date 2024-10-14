using System.ComponentModel.DataAnnotations;

namespace PhoneBase.Models
{
    public class UserLogin
    {
        [Required, MaxLength(20)]
        public string Login { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}