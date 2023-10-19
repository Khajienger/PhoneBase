using Microsoft.AspNetCore.Mvc;
using PhoneBase.Models;

namespace PhoneBase.Controllers
{
    public class PhonesController : Controller
    {
        private List<PhoneRecord> phoneRecords = new List<PhoneRecord>();
        private bool isLoaded = false;

        public IActionResult Index()
        {
            if (!isLoaded)
            {
                phoneRecords = GetPhoneRecords();
                isLoaded = true;
            }
            return View(phoneRecords);
        }

        public IActionResult PhoneRecordDetails(int ID)
        {
            if (!isLoaded)
            {
                phoneRecords = GetPhoneRecords();
                isLoaded = true;
            }
            return View(phoneRecords[ID]);
        }

        public IActionResult AddPhoneRecord()
        {
            return View();
        }

        private List<PhoneRecord> GetPhoneRecords()

        {
            return new List<PhoneRecord>

            {
                new PhoneRecord { id = 0, surname = "Иванов", name = "Иван", patronymic = "Иванович", number = "8-800-555-35-35", address = "Пушкина, 8а", description = "Рабочий"},
                new PhoneRecord { id = 1, surname = "Петрова", name = "Юлия", patronymic = "Владимировна", number = "8900-555-35-35", address = "Мира, 48", description = "Домашний"},
                new PhoneRecord { id = 2, surname = "Сидоров", name = "Алексей", patronymic = "Игорьевич", number = "8890-555-35-35", address = "Ленина, 22", description = "Коммерческий"},
                new PhoneRecord { id = 3, surname = "Сушков", name = "Александр", patronymic = "Олегович", number = "8809-555-35-35", address = "Халтурина, 35", description = "Рабочий"},
                new PhoneRecord { id = 4, surname = "Мирская", name = "Ирина", patronymic = "Викторовна", number = "8899-555-35-35", address = "Урицкого, 8г", description = "Дополнительный"},
            };
        }

        //[HttpPost]
        //public IActionResult CheckData(PhoneRecord PhoneRecord)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return Redirect("/");
        //    }
        //    return View();
        //}
    }
}