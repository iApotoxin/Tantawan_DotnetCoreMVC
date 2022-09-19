using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TantawanMVC.Models;
using TantawanMVC.Services;
using System.Net.Http;

namespace TantawanMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMailService _mailservice;
    // private readonly IMailBody _mailbody;

    public HomeController(ILogger<HomeController> logger, IMailService mailservice) 
    {
        _logger = logger;
        _mailservice = mailservice;
        // _mailbody = mailbody;
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
                List<IFormFile> listfile = new List<IFormFile>();
                if(career.File!=null)
                {
                    listfile.Add(career.File);
                }
              
                string body = "";
                body += "<p> Name : "+career.FirstName+" "+career.LastName+"</p>";
                body += "<p> Age : "+career.Age+"</p>";
                body += "<p> Birthdate : "+career.Date.ToString("dd-MMM-yyyy")+"</p>";
                body += "<p> Position : "+career.Position+"</p>";
                body += "<p> Salary : "+career.Salary+"</p>";
                body += "<p> Age : "+career.Age+"</p>";
                body += "<p> Tel : "+career.Phone+"</p>";
                body += "<p> Email : "+career.Email+"</p>";
                body += "<p> Address : "+career.Address+"</p>";

                MailRequest mailRequest = new MailRequest(){
                ToEmail = "ai2mmy@gmail.com",
                Subject = "Submit Career",
                Body = body,
                Attachments = listfile
               };
               _mailservice.SendEmailAsync(mailRequest);
                
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
            string body = "";
            body += "<p> Name : "+contact.FullName+"</p>";
            body += "<p> Tel : "+contact.Phone+"</p>";
            body += "<p> Email : "+contact.Email+"</p>";
            body += "<br";
            body += "<p> Message : "+contact.Message+"</p>";
            HttpClient _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7108");
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("ToEmail", "ai2mmy@gmail.com"),
                new KeyValuePair<string, string>("Subject", "Submit Contact"),
                new KeyValuePair<string, string>("Body", body)
            });
            var result =  _client.PostAsync("api/mail/send", content);
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
