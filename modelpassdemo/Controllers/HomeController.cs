using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using modelpassdemo.Models;

namespace modelpassdemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public string ShowData( Product pr)
    {
        return pr.prodId + " "+pr.prodname+" "+pr.prodPrice+" "+pr.prodQty;
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
