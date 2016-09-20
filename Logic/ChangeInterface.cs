using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Lync.Model;

namespace LyncTracker.Logic
{
    interface ChangeInterface
    {
        void SendStatusChange(string email, string lastName, string firstName, ContactAvailability status, DateTime date);

        void SendStatusChange(string email, ContactAvailability status);

        void SetStatus(string status);
    }
}
