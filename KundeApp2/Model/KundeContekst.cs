using System;
using Microsoft.EntityFrameworkCore;

namespace KundeApp2.Model
{
    public class KundeContekst : DbContext
    {
            public KundeContekst (DbContextOptions<KundeContekst> options)
                    : base(options)
            {
                Database.EnsureCreated();
            }

        public DbSet<Kunde> Kunder { get; set; }
    }
}
