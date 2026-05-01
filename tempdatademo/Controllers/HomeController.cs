using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tempdatademo.Models;

namespace tempdatademo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        TempData["Message"] = "It is message from Index";
        return RedirectToAction("HomePage");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult HomePage()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
