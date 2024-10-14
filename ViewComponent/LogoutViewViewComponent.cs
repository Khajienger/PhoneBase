using Microsoft.AspNetCore.Mvc;
public class LogoutViewViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}