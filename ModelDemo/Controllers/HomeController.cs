using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        Student st = new Student()
        {
            roll = 1,
            name = "Vibhas",
            gender = "Male",
            age = 21,
            course = " BCA",
            fees = 40000
        };


        //Long Method

        // Student st = new Student();
        // st.roll = 1;
        // st.name = "Vibhas";
        // st.gender = "Male";
        // st.age = 21;
        // st.course = " BCA";
        // st.fees = 40000;


        return View(st);
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
