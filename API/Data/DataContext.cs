using System;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Data;


    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        
        // DbSet property should be outside the constructor
        public DbSet<AppUser> Users { get; set; }

    public static implicit operator ControllerContext(DataContext v)
    {
        throw new NotImplementedException();
    }
}
