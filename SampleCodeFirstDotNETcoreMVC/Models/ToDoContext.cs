using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SampleCodeFirstDotNETcoreMVC.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
           
             modelBuilder.Entity<TodoItem>().HasData(
              new TodoItem() { Id = 1, Name = "Meeting with management", IsComplete = true, Description = "In meeting need to discuss some points." },
              new TodoItem() { Id = 2, Name = "Go for shopping", IsComplete = false, Description = "List of this this item buy." },
              new TodoItem() { Id = 3, Name = "Call for someone to do some task", IsComplete = true, Description = "here is a task to do on a call" });

        }
    }
}
