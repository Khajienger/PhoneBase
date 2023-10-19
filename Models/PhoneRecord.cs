using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PhoneBase.Models
{
    public class PhoneRecord
    {
        [Required]
        [StringLength(10)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        [Display (Name = "Фамилия")]
        public string surname { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Имя")]
        public string name { get; set; }

        [AllowNull]
        [StringLength(20)]
        [Display(Name = "Отчество")]
        public string patronymic { get; set; }

        [Required (ErrorMessage = "Телефон")]
        [StringLength(20)]
        [Display(Name = "Телефон")]
        public string number { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Адрес")]
        public string address { get; set; }

        [StringLength(50)]
        [AllowNull]
        [Display(Name = "Описание")]
        public string description { get; set; }
    }
}