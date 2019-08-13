using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab28.Models
{
    public class DeckContext : DbContext
    {
        public DeckContext (DbContextOptions<DeckContext> options)
            : base(options)
        {
        }

        public DbSet<Lab28.Models.Deck> Deck { get; set; }
    }
}
