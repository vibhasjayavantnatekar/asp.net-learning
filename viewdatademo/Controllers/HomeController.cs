using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using viewdatademo.Models;

namespace viewdatademo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        ViewData["id"] = 1;
        ViewData["name"] = "Lenovo ";
        ViewData["price"] = 45000;
        ViewData["qty"]= 50;


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
