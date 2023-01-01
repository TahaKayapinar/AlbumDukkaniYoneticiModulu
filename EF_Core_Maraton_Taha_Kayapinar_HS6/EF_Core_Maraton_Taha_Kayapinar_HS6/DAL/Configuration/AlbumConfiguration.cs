using EF_Core_Maraton_Taha_Kayapinar_HS6.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Maraton_Taha_Kayapinar_HS6.DAL.Configuration
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(t0 => t0.AlbumId);
            builder.Property(p => p.AlbumName).HasMaxLength(200);

            // İ L İ Ş K İ   K U R U L M A D I   H E N Ü Z

            //builder.HasData(
            //    new Album() {AlbumName = "BilgeAdam", Singer = "Emre Özbaşkan", BirthDate = "2000-05-29", Price = 15.75, DiscountRate = 0.15, SalesYorN = true }
            //    );
        }
    }
}
