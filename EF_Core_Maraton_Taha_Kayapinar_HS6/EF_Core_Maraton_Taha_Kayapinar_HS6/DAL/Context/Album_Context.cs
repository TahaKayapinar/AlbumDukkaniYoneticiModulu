using EF_Core_Maraton_Taha_Kayapinar_HS6.DAL.Configuration;
using EF_Core_Maraton_Taha_Kayapinar_HS6.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Maraton_Taha_Kayapinar_HS6.DAL.Context
{
    public class Album_Context : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TAHAKAYAPINAR; Database=AlbumDB; uid=sa; pwd=1");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Album>(new AlbumConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());

           // modelBuilder.Entity<User>().HasIndex(t0 => t0.UserName).IsUnique();    // kullanıcı adları uniq olsun !!!

            base.OnModelCreating(modelBuilder);
        }
    }
}
