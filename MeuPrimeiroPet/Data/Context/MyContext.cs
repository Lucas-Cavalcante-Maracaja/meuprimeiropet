using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Animal> Animal { get; set; }
    }
}
