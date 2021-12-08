using System;
using System.Collections.Generic;
using System.Text;

namespace Aliens.Database
{
    public class Excursion
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public Aliens id_alien { get; set; }
        public GroupsOfPeople id_group_people { get; set; }
        public Spaceship id_spaceship { get; set; }
    }
}
