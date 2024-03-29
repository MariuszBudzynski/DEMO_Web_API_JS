﻿using DEMO_Web_API_JS.Models;
using Microsoft.EntityFrameworkCore;

namespace DEMO_Web_API_JS.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder model) {

            //Fluent API configuration
            model.Entity<Note>().HasKey(e => e.Id);
        }
    }
}
