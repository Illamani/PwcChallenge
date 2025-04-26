using Microsoft.EntityFrameworkCore;
using RentalCar.Domain.Entities;

namespace RentalCar.Models
{
	public class RentalContext : DbContext
	{
		public RentalContext(DbContextOptions<RentalContext> options)
			: base(options) { }

		public DbSet<Car> Cars { get; set; }

		public DbSet<Customer> Customers { get; set; }

		public DbSet<Rental> Rentals { get; set; }

		public DbSet<Service> Services { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Car>().ToTable("Car");
			modelBuilder.Entity<Customer>().ToTable("Customer");
			modelBuilder.Entity<Rental>().ToTable("Rental");
			modelBuilder.Entity<Service>().ToTable("Service");
		}
	}
}
