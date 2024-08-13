using Microsoft.EntityFrameworkCore;
using ContactManager.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager.DB;

public class ContactManagerContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Trainee> Trainees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=ContactManager;User=root;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>().ToTable("Person");
        modelBuilder.Entity<Customer>().ToTable("Customer");
        modelBuilder.Entity<Employee>().ToTable("Employee");
        modelBuilder.Entity<Trainee>().ToTable("Trainee");

        modelBuilder.Entity<Person>(entity =>
        {
            entity.OwnsOne(e => e.CommunicationInfo, communicationInfo =>
            {
                communicationInfo.Property(c => c.PhoneNumberPrivate).HasColumnName("phoneNumberPrivate");
                communicationInfo.Property(c => c.PhoneNumberMobile).HasColumnName("phoneNumberMobile");
                communicationInfo.Property(c => c.PhoneNumberBusiness).HasColumnName("phoneNumberBusiness");
                communicationInfo.Property(c => c.Email).HasColumnName("email");
            });

            entity.OwnsOne(e => e.Address, address =>
            {
                address.Property(a => a.Street).HasColumnName("street");
                address.Property(a => a.StreetNumber).HasColumnName("streetNumber");
                address.Property(a => a.ZipCode).HasColumnName("zipCode");
                address.Property(a => a.City).HasColumnName("place");
            });
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.OwnsOne(e => e.CommunicationInfo, communicationInfo =>
            {
                communicationInfo.Property(c => c.PhoneNumberPrivate).HasColumnName("phoneNumberPrivate");
                communicationInfo.Property(c => c.PhoneNumberMobile).HasColumnName("phoneNumberMobile");
                communicationInfo.Property(c => c.PhoneNumberBusiness).HasColumnName("phoneNumberBusiness");
                communicationInfo.Property(c => c.Email).HasColumnName("email");
            });

            entity.OwnsOne(e => e.Address, address =>
            {
                address.Property(a => a.Street).HasColumnName("street");
                address.Property(a => a.StreetNumber).HasColumnName("streetNumber");
                address.Property(a => a.ZipCode).HasColumnName("zipCode");
                address.Property(a => a.City).HasColumnName("place");
            });
        });

        //modelBuilder.Entity<Person>(entity =>
        //{
        //    entity.ToTable("person");

        //    entity.HasKey(p => p.Id);

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Gender).HasColumnName("gender");
        //    entity.Property(e => e.Title).HasColumnName("title");
        //    entity.Property(e => e.FirstName).HasColumnName("firstName");
        //    entity.Property(e => e.LastName).HasColumnName("lastName");
        //    entity.Property(e => e.DateOfBirth).HasColumnName("dateOfBirth");
        //    entity.Property(e => e.SocialSecurityNumber).HasColumnName("socialSecurityNumber");
        //    entity.Property(e => e.Status).HasColumnName("status");
        //    entity.Property(e => e.Nationality).HasColumnName("nationality");

        //    entity.OwnsOne(e => e.CommunicationInfo, communicationInfo =>
        //    {
        //        communicationInfo.Property(c => c.PhoneNumberPrivate).HasColumnName("phoneNumberPrivate");
        //        communicationInfo.Property(c => c.PhoneNumberMobile).HasColumnName("phoneNumberMobile");
        //        communicationInfo.Property(c => c.PhoneNumberBusiness).HasColumnName("phoneNumberBusiness");
        //        communicationInfo.Property(c => c.Email).HasColumnName("email");
        //    });

        //    entity.OwnsOne(e => e.Address, address =>
        //    {
        //        address.Property(a => a.Street).HasColumnName("street");
        //        address.Property(a => a.StreetNumber).HasColumnName("streetNumber");
        //        address.Property(a => a.ZipCode).HasColumnName("zipCode");
        //        address.Property(a => a.City).HasColumnName("place");
        //    });
        //});
    }
}
