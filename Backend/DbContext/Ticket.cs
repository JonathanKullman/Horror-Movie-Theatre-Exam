namespace Backend
{
    public class Ticket
    {
        public int Id { get; set; }
        public virtual Theatre Theatre { get; set; }
        public int TheatreId { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public int Seat { get; set; }
        public bool Wheelchair { get; set; }

    }
}