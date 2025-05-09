﻿public class Venue
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public int Capacity { get; set; }
    public string ImageUrl { get; set; } // Placeholder image
    public ICollection<Event> Events { get; set; }
}
