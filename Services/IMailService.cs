using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantawanMVC.Models;

namespace TantawanMVC.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}