using System;
using System.Collections.Generic;
using System.Text;

namespace Aliens.Database
{
    public class Transportation
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public People id_person { get; set; }
        public Spaceship id_spaceship_from { get; set; }
        public Spaceship id_spaceship_to { get; set; }
        public Aliens id_alien { get; set; }
    }
}
