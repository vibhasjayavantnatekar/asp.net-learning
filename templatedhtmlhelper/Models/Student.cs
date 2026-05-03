using System.ComponentModel;
using Microsoft.AspNetCore.SignalR;

namespace templatedhtmlhelper.Models
{
    public class Student
    {
        [DisplayName("Roll Number")]
        public int Roll {get; set;}

        [DisplayName("Enter a Name")]

        public string Name {get; set;}

        [DisplayName("Enter Date of Birth")]


         public DateOnly Dob {get; set;}


        [DisplayName("IS has any Diability")]

        public Boolean isDiasable{get; set;}


    }
}