namespace DDDExample.Entities.Booking_LogicToValueObject
{
    public class Stay
    {
        public DateTime FirstNight { get; private set; }
        public DateTime LastNight { get; private set; }

        public Stay(DateTime firstNight, DateTime lastNight)
        {
            if (firstNight > lastNight)
                throw new Exception("First Night Of Stay Cannot Be After Last Night");

            if (DoesNotMeetMinimumStayDuration(firstNight, lastNight))
                throw new Exception("Stay Does Not Meet Minimum Duration");

            this.FirstNight = firstNight;
            this.LastNight = lastNight;
        }

        private bool DoesNotMeetMinimumStayDuration(DateTime firstNight, DateTime lastNight)
        {
            return (lastNight - firstNight) < TimeSpan.FromDays(3);
        }

    }
}
