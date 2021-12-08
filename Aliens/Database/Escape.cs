using System;
using System.Collections.Generic;
using System.Text;

namespace Aliens.Database
{
    public class Escape
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public People id_person { get; set; }
        public Spaceship id_spaceship { get; set; }
    }
}
