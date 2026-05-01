using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using viewbagdemo.Models;

namespace viewbagdemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Roll = 1;
        ViewBag.Name = "Vibhas";
        ViewBag.Course = "BCA";
        ViewBag.Fees = 40000;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
