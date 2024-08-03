﻿using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreGraphQL.GraphQl.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}
