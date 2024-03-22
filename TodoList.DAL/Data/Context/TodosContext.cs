using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DAL.Configrations;
using TodoList.DAL.Data.Models;

namespace TodoList.DAL.Data.Context
{
    public class TodosContext : DbContext
    {
        public TodosContext()
        {
            
        }
        public TodosContext(DbContextOptions options): base(options) { }
        public virtual DbSet<Todo> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var Todos = new List<Todo>{
                new Todo {
                    Id = 1,
                    Name = "Models",
                    Description = "Models for Every Entity",
                    DeadLine = DateTime.Now.AddDays(1)
                },
                new Todo {
                    Id = 2,
                    Name = "Views",
                    Description = "Views for Every Controller",
                    DeadLine = DateTime.Now.AddDays(2)
                },                new Todo {
                    Id = 3,
                    Name="Validations",
                    Description = "Validate User input",
                    DeadLine = DateTime.Now.AddDays(3)
                }

            };

            modelBuilder.Entity<Todo>().HasData(Todos);
            new TodoTypeConfigrations().Configure(modelBuilder.Entity<Todo>());
        }

    }
}
