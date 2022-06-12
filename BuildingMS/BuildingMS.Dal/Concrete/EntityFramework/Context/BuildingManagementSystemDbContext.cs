using System;
using BuildingMS.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BuildingMS.Dal.Concrete.EntityFramework.Context
{ 
    public partial class BuildingManagementSystemDbContext : DbContext
    {
        IConfiguration configuration;
        public BuildingManagementSystemDbContext(IConfiguration configuration)
        {
            this.configuration = configuration; 

        }

        /*public BuildingManagementSystemDbContext(DbContextOptions<BuildingManagementSystemDbContext> options)
            : base(options)
        {
        }
        */
        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // if (!optionsBuilder.IsConfigured)
           // {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer"));

                // optionsBuilder.UseSqlServer("Server=DESKTOP-BM5NO11;Database=BuildingManagementSystemDb;Trusted_Connection=True;");
           // }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Apartment>(entity =>
            {
                entity.Property(e => e.ApartmentId).HasColumnName("ApartmentID");

                entity.Property(e => e.ApartmentBlock)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApartmentFlat)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ApartmentNo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ApartmentStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApartmentType)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.BuildingsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApartmentManagerNavigation)
                    .WithMany(p => p.Apartments)
                    .HasForeignKey(d => d.ApartmentManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Apartments_Manager");

                entity.HasOne(d => d.ApartmentUserNavigation)
                    .WithMany(p => p.Apartments)
                    .HasForeignKey(d => d.ApartmentUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Apartments_Users");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.CommonUsage)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Dues)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceElectric)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceGas)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceWater)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApartmentNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.Apartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Apartments");

                entity.HasOne(d => d.ManagerNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.Manager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Manager");

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.Users)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Users");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("Manager");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ManagerMail)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerPass)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ManagerPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerSurname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerTc)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ManagerTC");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.MessageBody)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MessageStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTime).HasColumnType("datetime");

                entity.Property(e => e.MessageTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ReceiverNavigation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.Receiver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_Users");

                entity.HasOne(d => d.SenderNavigation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.Sender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_Manager");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserPlate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserRole)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserSurname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserTc)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("UserTC");

                entity.HasOne(d => d.ManagerNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Manager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Manager");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
