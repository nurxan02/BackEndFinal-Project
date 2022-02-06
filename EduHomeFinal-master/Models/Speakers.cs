using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class Speakers
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
