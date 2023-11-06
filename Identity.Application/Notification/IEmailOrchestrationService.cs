using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Notification
{
    public interface IEmailOrchestrationService
    {
        ValueTask<bool> SendAsync(string emailAdress, string message);
    }
}
