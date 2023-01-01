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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t0 => t0.UserID);
            builder.Property(p => p.UserName).HasMaxLength(15);


        }
    }
}
