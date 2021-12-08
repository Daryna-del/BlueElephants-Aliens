﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aliens.Database
{
    public class Abduction
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public People id_person { get; set; }
        public Aliens id_alien { get; set; }
        public Spaceship id_spaceship { get; set; }
    }
}
