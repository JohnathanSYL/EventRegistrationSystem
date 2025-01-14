using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventRegistrationSystem.Domain;

namespace EventRegistrationSystem.Data
{
    public class EventRegistrationSystemContext : DbContext
    {
        public EventRegistrationSystemContext (DbContextOptions<EventRegistrationSystemContext> options)
            : base(options)
        {
        }

        public DbSet<EventRegistrationSystem.Domain.Users> Users { get; set; } = default!;
    }
}
