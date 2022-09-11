using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tantawan_DotnetCoreMVC.Models;
using TantawanMVC.Models;

namespace TantawanMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Capabilities()
    {
        return View();
    }

    public IActionResult Customer()
    {
        return View();
    }

    public IActionResult Career(Career career)
    {
              if (ModelState.IsValid) 
        { 
                // DateTime _datetime = DateTime.Now;

                string _firstname = career.FirstName;
                string _lastname = career.LastName;
                string _position = career.Position;
                int _salary = career.Salary;
                DateTime _date = career.Date;
                int _age = career.Age;
                string _email = career.Email;
                string _phone = career.Phone;
                string _address = career.Address;
                IFormFile _file  = career.File;

                Console.WriteLine(_firstname);
                Console.WriteLine(_lastname);
                Console.WriteLine(_position);
                Console.WriteLine(_salary);
                Console.WriteLine(_date);
                Console.WriteLine(_age);
                Console.WriteLine(_email);
                Console.WriteLine(_phone);
                Console.WriteLine(_address);
                // Console.WriteLine(_file.FileName);
                
                ModelState.Clear();  
        }
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Contact(Contact contact)
    {
           if (ModelState.IsValid) 
        { 
                DateTime _datetime = DateTime.Now;
                string _email = contact.Email;
                string _fullname = contact.FullName;
                string _phone = contact.Phone;
                string _message = contact.Message;

                Console.WriteLine(_datetime);
                Console.WriteLine(_email);
                Console.WriteLine(_fullname);
                Console.WriteLine(_phone);
                Console.WriteLine(_message);
                ModelState.Clear();  
        }
    return View();
    }

    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
