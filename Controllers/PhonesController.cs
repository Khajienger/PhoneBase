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
                new PhoneRecord { surname = "Имя505", name = "Фамилия505", patronymic = "Отчество505", number = "8800-555-35-35", address = "Улица Пушкина, дом Колотушкина", description = "Время и Стекло"},
                new PhoneRecord { surname = "ИмяA", name = "ФамилияA", patronymic = "ОтчествоA", number = "8900-555-35-35", address = "УлицаA, дом Колотушкина", description = "A..."},
                new PhoneRecord { surname = "ИмяB", name = "ФамилияB", patronymic = "ОтчествоB", number = "8890-555-35-35", address = "УлицаB, дом Колотушкина", description = "B..."},
                new PhoneRecord { surname = "ИмяC", name = "ФамилияC", patronymic = "ОтчествоC", number = "8809-555-35-35", address = "УлицаC, дом Колотушкина", description = "C..."},
                new PhoneRecord { surname = "ИмяD", name = "ФамилияD", patronymic = "ОтчествоD", number = "8899-555-35-35", address = "УлицаD, дом Колотушкина", description = "D..."},
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