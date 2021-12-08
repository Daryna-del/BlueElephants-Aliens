using System;
using System.Collections.Generic;
using System.Text;

namespace Aliens.Database
{
    public class GroupAndPerson
    {
        public int id { get; set; }
        public GroupsOfPeople id_group { get; set; }
        public People id_person { get; set; }
     }
}
