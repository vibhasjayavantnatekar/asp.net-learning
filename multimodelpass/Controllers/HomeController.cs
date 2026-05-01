using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using multimodelpass.Models;

namespace multimodelpass.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ShowStudents()
    {
        
        List<Student> students = new List<Student>()
        {
          new Student()
          {
              Roll = 1 ,
              Name = "Vibhas",
              gender = "male",
              course = "BCA"
          },
          new Student()
          {
              Roll =  2,
              Name = "Sita",
              gender = "female",
              course = "BCA"
          },
          new Student()
          {
              Roll = 3 ,
              Name = "suresh",
              gender = "male",
              course = "BCA"
          },
          new Student()
          {
              Roll = 4 ,
              Name = "paras",
              gender = "male",
              course = "BCA"
          }



        };

        return View(students);

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
