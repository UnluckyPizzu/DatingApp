using System.ComponentModel.DataAnnotations;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data{

    public class DataContext : DbContext
    {
        //dotnet ef databse update to create db
        //dotnet ef migrations add "name" -o Data/Migrations
        public DbSet<AppUser> Users {get;set;}
        public DataContext(DbContextOptions options) : base(options)
        {

        }
    }
}