using System;
using Microsoft.EntityFrameworkCore;
using ToDoList2.Models;

namespace ToDoList2.Models
{
    public class ToDoList2Context : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=todolist2;uid=root;pwd=root;");
    }
}
