using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using requestobjectdemo.Models;

namespace requestobjectdemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ShowData()
    {
        
            var name = Request.Form["nm"] ; 
            var gender = Request.Form["gen"];
            var age = Request.Form["age"];
            
            ViewBag.name = name;
            ViewBag.gender = gender;
            ViewBag.age = age;
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
