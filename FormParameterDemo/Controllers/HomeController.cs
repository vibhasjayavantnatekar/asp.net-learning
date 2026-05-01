using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormParameterDemo.Models;

namespace FormParameterDemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult MyForm()
    {
        return View();
    }
    
    public IActionResult ShowData(string nm , string gn , string age)
    {
        ViewBag.name = nm;
        ViewBag.gender = gn ;
        ViewBag.age =  age;
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
