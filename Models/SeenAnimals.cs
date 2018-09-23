using System;

namespace take_the_safari_online.Models
{
    public class SeenAnimals
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public int CountOfTimesSeen { get; set; }
        public string LocationOfLastSeen { get; set; }

        public DateTime LastSeenAt { get; set; } = DateTime.Now;
    }
}