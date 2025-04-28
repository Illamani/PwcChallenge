using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Persistence.Context;
using RentalCar.Persistence.Repository.ModelRepository;

namespace RentalCar.Persistence
{
	public static class ServiceExtension
	{
		public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
		{
			var connection = configuration.GetConnectionString("RentalConnection");
			services.AddDbContext<RentalContext>(options => options.UseSqlServer(connection));
			services.AddScoped<ICarRepository, CarRepository>();
		}
	}
}
