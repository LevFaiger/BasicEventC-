using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FireVideoEvent
{
    public class UpdateReservation
    {
        // 1. Create delegate that point on method will be called then event triggered
        //public delegate void ReservationValidatedEventHandler(object source, UpdateReservationEventArgs args);
        // 2. Create event based on delegate
        // C# - Event. In general terms, an event is something special that is going to happen
        //public event ReservationValidatedEventHandler ReservationValidatedEvent;

        public event EventHandler<UpdateReservationEventArgs> ReservationValidatedEvent;

        public void ValidateReservation(Reservation resevation)
        {
            Console.WriteLine("Begin update reservation");
            Thread.Sleep(4000);
            // rise event
            ReservationValidatedEvent?.Invoke(this, new UpdateReservationEventArgs { reservation= resevation });
        }

       
    }

    public class UpdateReservationEventArgs : EventArgs
    {
        public Reservation reservation { get; set; }
    }
}
