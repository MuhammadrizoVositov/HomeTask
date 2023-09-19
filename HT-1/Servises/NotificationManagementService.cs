using HT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1.Servises
{
    public class NotificationManagementService
    {
        private readonly UserServise _userService;
        private readonly EmailServise _emailService;
        private readonly EmailSenderService _emailSenderService;
        private readonly EmailTemplateService _emailTemplateService;

        public NotificationManagementService(UserServise userService, EmailServise emailService, 
            EmailSenderService emailSenderService, EmailTemplateService emailTemplateService)
        {
            _userService = userService;
            _emailService = emailService;
            _emailSenderService = emailSenderService;
            _emailTemplateService = emailTemplateService;
        }

        public async void NotifyUsers()
        {
            var users = _userService.GetUsers();
            var templates = _emailTemplateService.GetTemplates(users);
            var messages = _emailService.GetMessages(templates,users);
            await _emailSenderService.SendEmailsAsync(messages);
        }
    }
}
