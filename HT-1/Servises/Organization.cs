using HT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1.Servises
{
    public class Organization
    {
        private readonly UserServise _userServise;
        private readonly EmailTemplateService _emailTemplateService;
        private readonly EmailServise _emailServise;
        private readonly EmailSenderService _emailSenderService;

        public Organization(UserServise userServise, EmailTemplateService emailTemplateService, EmailServise emailServise, EmailSenderService emailSenderService)
        {
            _userServise = userServise;
            _emailTemplateService = emailTemplateService;
            _emailServise = emailServise;
            _emailSenderService = emailSenderService;
        }
        
    }
}
