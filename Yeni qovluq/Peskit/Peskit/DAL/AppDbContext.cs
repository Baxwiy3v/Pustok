using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Peskit.Models;

namespace Peskit.DAL
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }



        public DbSet<Blog> Blogs { get; set; }


    }





}





