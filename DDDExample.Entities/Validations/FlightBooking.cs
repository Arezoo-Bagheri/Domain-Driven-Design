namespace DDDExample.Entities.Validations
{
    public class FlightBooking
    {
        private bool confirmed = false;

        public Guid Id { get; private set; }
        public DateTime DepartureDate { get; private set; }
        public Guid CustomerId { get; private set; }

        public FlightBooking(Guid id, DateTime departureDate, Guid customerId)
        {
            if (id == null)
                throw new Exception("Id Missing");

            if (departureDate == null)
                throw new Exception("Departure Date Missing");

            if (customerId == null)
                throw new Exception("Customer Id Missing");
        }

        public void Reschedule(DateTime newDeparture)
        {
            if (confirmed)
                throw new Exception("Could not change Departure Date confirmation ");

            DepartureDate = newDeparture;
        }

        public void Confirm()
        {
            confirmed = true;
        }

    }
}
