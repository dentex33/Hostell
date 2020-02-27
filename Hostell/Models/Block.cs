using System.Collections.Generic;

namespace Hostell.Models
{
    public class Block
    {
        
        public int Id { get; set; }
        public string NoBlock { get; set; }
        public int NumberOfPlace { get; set; }
        public int OccupiedPlace { get; set; }
        public int Floor { get; set; }
        public bool Balcony { get; set; }
        public List<Resident> People { get; set; }
    }
}
