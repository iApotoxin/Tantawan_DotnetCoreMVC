using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tantawan_DotnetCoreMVC.Models;
using TantawanMVC.Models;

namespace Tantawan_DotnetCoreMVC.Services
{
    public interface IMailBody
    {
        String CreateContactBody (Contact contact);
        String CreateCareerBody (Career career);
    }
}