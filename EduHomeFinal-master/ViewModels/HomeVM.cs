using EduHomeFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<NoticeProfession> NoticeProfessions { get; set; }
        public IEnumerable<Event> Events { get; set; }
    }
}
