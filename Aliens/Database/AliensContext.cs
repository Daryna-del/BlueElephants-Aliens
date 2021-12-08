using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aliens.Database
{
    class AliensContext: DbContext
    {
        public DbSet<Aliens> aliens { get; set; }
        public DbSet<People> people { get; set; }
        public DbSet<Spaceship> spaceships { get; set; }
        public DbSet<Murder> murders { get; set; }
        public DbSet<Experiment> experiments { get; set; }
        public DbSet<Excursion> excursions { get; set; }
        public DbSet<Abduction> abductions { get; set; }
        public DbSet<Escape> escapes { get; set; }
        public DbSet<Transportation> transportations { get; set; }
        public DbSet<GroupAndAlien> group_alien { get; set; }
        public DbSet<GroupAndPerson> group_person { get; set; }
        public DbSet<GroupsOfAliens> groups_aliens { get; set; }
        public DbSet<GroupsOfPeople> groups_people { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=BlueElephantsNew;Username=postgres;Password=post");
        }

        internal void ExecuteStoreCommand(string v)
        {
            throw new NotImplementedException();
        }
    }
}
