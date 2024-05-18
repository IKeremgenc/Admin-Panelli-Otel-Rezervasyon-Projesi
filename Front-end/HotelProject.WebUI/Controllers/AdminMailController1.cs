using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController1 : Controller
    {
        [HttpGet]
        public IActionResult Index() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();    
            MailboxAddress mailboxAddress=new MailboxAddress("KeremGencAdmin","ismailkeremgenc@gmail.com");
            mimeMessage.From.Add(mailboxAddress);
            MailboxAddress mailboxAddressTo=new MailboxAddress("kerem",model.ReciverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodybuidler = new BodyBuilder();
            bodybuidler.TextBody = model.Body;
            mimeMessage.Body=bodybuidler.ToMessageBody();

            mimeMessage.Subject = model.Subject;    
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("ismailkeremgenc@gmail.com", "hllsubdgetjyfzlj");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            return View();
        }
    }
}
