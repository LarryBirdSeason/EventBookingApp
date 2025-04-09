public class Event
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; } // Placeholder image
    public int VenueId { get; set; }
    public Venue Venue { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}
