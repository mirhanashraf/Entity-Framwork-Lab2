namespace EntityFramework.Lab2
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }
        

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Cover> Covers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>()
                .ToTable("Country")
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<City>()
                .ToTable("City")
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Country>()
              .HasMany(c => c.Cities)
              .WithRequired(e => e.Country)
              .HasForeignKey(e => e.FK_CountryId)
              .WillCascadeOnDelete(false);


            modelBuilder.Entity<User>()
               .ToTable("User")
               .Property(u => u.Name)
               .IsRequired()
               .HasMaxLength(50);

            modelBuilder.Entity<User>()
               .HasMany(c => c.Cities)
               .WithMany(u => u.Users)
               .Map(m => m.ToTable("User_City")
               .MapLeftKey("U_Id")
               .MapRightKey("C_Id"));

            modelBuilder.Entity<Book>()
               .ToTable("Book")
               .Property(c => c.Title)
               .IsRequired()
               .HasMaxLength(50);

            modelBuilder.Entity<City>()
               .HasOptional(c => c.Book)
               .WithRequired(b => b.City);

            modelBuilder.Entity<Cover>()
               .ToTable("Cover")
               .Property(c => c.Code)
               .IsRequired()
               .HasMaxLength(50);

            modelBuilder.Entity<Book>()
               .HasRequired(b=>b.Cover)
               .WithRequiredPrincipal(c=>c.Book);
        }
    }

}