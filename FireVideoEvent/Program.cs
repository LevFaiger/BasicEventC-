using System;

namespace FireVideoEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservation = new Reservation { Name="Name"};
            var updateR = new UpdateReservation();
            var Email = new Email();
            updateR.ReservationValidatedEvent += Email.Send;
            updateR.ValidateReservation(reservation);
        }
    }
}
