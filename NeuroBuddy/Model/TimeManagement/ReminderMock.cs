using NeuroBuddy.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model.TimeHandling
{
   public class ReminderMock: iReminder
    {

        public TimeSpan TimeBeforeEvent { get; set; }
        public string Message { get; set; }

        public ReminderMock(TimeSpan timeBeforeEvent, string message)
        {
            TimeBeforeEvent = timeBeforeEvent;
            Message = message;
        }
    }
}

