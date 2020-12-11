using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PhBuyModels
{
    public partial class PhBuyContext : DbContext
    {
        public PhBuyContext()
        {
        }

        public PhBuyContext(DbContextOptions<PhBuyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ProductImages> ProductImages { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<SellerTypes> SellerTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SQL5097.site4now.net;Initial Catalog=DB_A6A7CB_PhBuy;User Id=DB_A6A7CB_PhBuy_admin;Password=ryanpogi123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.DateOrdered).HasColumnType("datetime");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.SellerId)
                    .HasColumnName("SellerID")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__36B12243");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Orders__ProductI__2F10007B");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK__Orders__SellerID__35BCFE0A");
            });

            modelBuilder.Entity<ProductImages>(entity =>
            {
                entity.HasKey(e => e.ImageiD)
                    .HasName("PK__ProductI__7511F8C4CFF1BF2E");

                entity.Property(e => e.ImageiD).ValueGeneratedNever();

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("smallmoney");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductIm__Produ__34C8D9D1");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__B40CC6ED0F059608");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.Condition)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FdaNumber)
                    .HasColumnName("FDA_Number")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnType("smallmoney");

                entity.Property(e => e.Length).HasColumnType("smallmoney");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId)
                    .HasColumnName("SellerID")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.Property(e => e.Width).HasColumnType("smallmoney");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK__Products__Seller__267ABA7A");
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.Contact)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Descrption)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fblink)
                    .HasColumnName("FBLink")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SellerTypes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SellerId)
                    .HasColumnName("SellerID")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Seller)
                    .WithMany()
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK__SellerTyp__Selle__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
