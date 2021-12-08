using System;
using System.Collections.Generic;
using System.Text;

namespace Aliens.Database
{
    public class GroupAndAlien
    {
        public int id { get; set; }
        public GroupsOfAliens id_group { get; set; }
        public Aliens id_alien { get; set; }
    }
}
