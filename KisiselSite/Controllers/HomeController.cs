using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Hakkimda() => View();
    public IActionResult Yeteneklerim() => View();
    public IActionResult Projelerim() => View();
    public IActionResult Deneyimlerim() => View();
    public IActionResult Iletisim() => View();
}