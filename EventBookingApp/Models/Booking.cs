public class Booking
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public int EventId { get; set; }
    public Event Event { get; set; }
}
