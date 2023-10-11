using System.ComponentModel.DataAnnotations;

namespace PhoneBase.Models
{
    public class PhoneRecord
    {
        public int id { get; set; }
        [Display (Name = "Фамилия")]
        public string surname { get; set; }

        [StringLength(20)]
        [Display(Name = "Имя")]
        public string name { get; set; }

        [Display(Name = "Отчество")]
        public string patronymic { get; set; }

        [Required (ErrorMessage = "Телефон")]
        [Display(Name = "Телефон")]
        public string number { get; set; }

        [Display(Name = "Адрес")]
        public string address { get; set; }

        [Display(Name = "Описание")]
        public string description { get; set; }
    }
}