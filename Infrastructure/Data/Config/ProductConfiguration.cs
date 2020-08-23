using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            //builder.Property(p=>p.ProdId).IsRequired();
            builder.Property(p=>p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p=>p.ProdDescription).IsRequired();
           // builder.Property(p=>p.ProdDescription).IsRequired().HasMaxLength(200);
          //  builder.Property(p=>p.ProdFormat).IsRequired();
          //  builder.Property(p=>p.ProdGender).IsRequired();
          //  builder.Property(p=>p.ProdSize).IsRequired();
            builder.Property(p=>p.SalePrice).HasColumnType("decimal(18,2)");
          //  builder.Property(p=>p.ProdPicture).IsRequired();

            builder.HasOne(b=>b.ProductBrand).WithMany()
                .HasForeignKey(p=>p.ProductBrandId);

            builder.HasOne(t=>t.ProductType).WithMany()
                .HasForeignKey(p=>p.ProductTypeId);


        }
        
        
        
    }
}