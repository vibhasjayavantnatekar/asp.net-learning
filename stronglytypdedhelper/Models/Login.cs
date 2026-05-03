using System.ComponentModel;

namespace stronglytypdedhelper.Models
{
    public class Login
    {
        [DisplayName("User Name")]
        public string username { get; set; }
        
        [DisplayName("Password")]

        public string password {get; set;}



    }
}