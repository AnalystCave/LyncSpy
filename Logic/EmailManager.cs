using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyncTracker.Logic
{
    class EmailManager
    {
        public EmailManager()
        {

        }

        public void SendEmail(string subject, string body, string email)
        {
            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem = app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            mailItem.Subject = subject;
            mailItem.To = email;
            mailItem.Body = body;
            mailItem.Display(false);
            mailItem.Send();
        }
    }
}
