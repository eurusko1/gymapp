using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymapp1.Models;

namespace Gymapp1.Service
{
    public interface IMailService
    {
        Task SendEmailAsync(string ToEmail, string Subject, string HTMLBody);
   
    }
}

