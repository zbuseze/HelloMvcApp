using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace HelloMvcApp.Models
{
    public class OkulDbContext: DbContext
    {
       
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\MSSQLSERVER01;Integrated Security=true;Initial Catalog=OkulDbMvcEF");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
           

            modelBuilder.Entity<Ogretmen>().ToTable("tblOgretmenler");
            modelBuilder.Entity<Ogretmen>().Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogretmen>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogretmen>().Property(o => o.Tckimlik).HasColumnType("varchar").HasMaxLength(30).IsRequired();

        }
        
        

        //public class OgretmenEntityTypeConfiguration : IEntityTypeConfiguration<Ogretmen>
        //{
        //    public void Configure(EntityTypeBuilder<Ogretmen> builder)
        //    {
        //        builder.ToTable("tblOgretmenler");
        //        builder.Property(o => o.Ad).IsRequired().HasColumnType("varchar").HasMaxLength(30);
        //        builder.Property(o => o.Soyad).IsRequired().HasColumnType("varchar").HasMaxLength(30);
        //        builder.Property(o => o.Tckimlik).IsRequired().HasColumnType("varchar").HasMaxLength(30);
        //    }
        //    //public void Configure(EntityTypeBuilder<Ogrenci> builder)
        //    //{
        //    //    builder.ToTable("tblOgrenciler");
        //    //    builder.Property(o => o.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
        //    //    builder.Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
        //    //}

        //}
       
    }
}
