using Microsoft.AspNetCore.Mvc;
using stronglytypdedhelper.Models;

namespace stronglytypdedhelper.Controllers
{
    public class StudentController : Controller

    {
        public IActionResult Index()
        {
            Login l = new Login() { username="admin" , password="pass@123"};
            return View(l);
        }

        public string Show(Login l)
        {
           
           return l.password + " " +  l.username;
        }
    }
}