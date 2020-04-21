using System;
using System.Collections.Generic;
using System.Text;

namespace FireVideoEvent
{
    public class Email
    {
        public string To { get; set; }
        public string Body { get; set; }
        public void  Send(object source, UpdateReservationEventArgs args) {
            Console.WriteLine("Email is sent");
        }
    }
}
