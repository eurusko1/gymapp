using System;
using System.Threading.Tasks;
using Gymapp1.Models;

namespace Gymapp1.Service
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }


    
}
