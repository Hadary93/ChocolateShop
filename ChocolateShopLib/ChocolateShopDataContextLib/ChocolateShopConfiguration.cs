using ChocolateShopLib.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopDataContextLib
{
    public class ChocolateShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            // Add comment to table
            builder.ToTable(t => t.HasComment("Shop managed on the website"));
        }
    }
}
