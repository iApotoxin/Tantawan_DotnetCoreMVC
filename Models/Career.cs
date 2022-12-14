using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TantawanMVC.Models
{
    public class Career
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Salary {get; set; }
        public DateTime Date {get; set; }
        public int Age {get; set; }
        public string Email {get; set; }
        public string Phone {get; set; }
        public string Address {get; set; }
       public IFormFile? File {get;set;}
    }
}