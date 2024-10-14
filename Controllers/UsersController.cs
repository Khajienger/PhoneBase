using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _21_NotebookDb.Controllers
{
    [Authorize(Policy = "OnlyForAdminRole")]
    public class UsersController: Controller
    {
        //private void AddUser(User User)
        //{
        //    using (DataContext context = new DataContext())
        //    {
        //        context.Users.Add(User);
        //        context.SaveChanges();
        //        context.Dispose();
        //    }
        //}

        //private void DeleteUser(string Login)
        //{
        //    using (DataContext context = new DataContext())
        //    {
        //        User _user = context.Users.Where(u => u.login == Login).FirstOrDefault();

        //        context.Users.Remove(_user);
        //        context.SaveChanges();
        //        context.Dispose();
        //    }
        //}
    }
}
